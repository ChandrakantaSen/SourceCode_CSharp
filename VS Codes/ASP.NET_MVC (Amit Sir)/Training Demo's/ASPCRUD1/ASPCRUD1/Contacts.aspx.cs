using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPCRUD1
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateContacts();
            }
        }

        //Populate Contacts to GridView
        private void PopulateContacts()
        {
            List<Contact> allContacts = null;
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var contacts = (from a in dc.Contacts
                                join b in dc.Countries on a.CountryId equals b.CountryId
                                join c in dc.States on a.StateId equals c.StateId
                                select new
                                {
                                    a,
                                    b.CountryName,
                                    c.StateName
                                });
                if(contacts!=null)
                {
                    allContacts = new List<Contact>();
                    foreach(var i in contacts)
                    {
                        Contact c = i.a;
                        c.CountryName = i.CountryName;
                        c.StateName = i.StateName;
                        allContacts.Add(c);
                    }
                }
                if (allContacts == null || allContacts.Count == 0)
                {
                    //Display Footer
                    allContacts.Add(new Contact());
                    gvContacts.DataSource = allContacts;
                    gvContacts.DataBind();
                    gvContacts.Rows[0].Visible = false;
                }
                else
                {
                    gvContacts.DataSource = allContacts;
                    gvContacts.DataBind();
                }

                //Populate and Bind Country
                if (gvContacts.Rows.Count > 0)
                {
                    DropDownList dd = (DropDownList)gvContacts.FooterRow.FindControl("ddlCountry");
                    if(dd==null)
                    {
                        dd = new DropDownList();
                    }
                    BindCountry(dd, PopulateCountry());
                }
            }
        }

        //Fetch Country Names
        private List<Country> PopulateCountry()
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                return dc.Countries.OrderBy(a => a.CountryName).ToList();
            }
        }

        //Fetch State Names
        private List<State> PopulateState(int CountryId)
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                return dc.States.Where(a => a.CountryId.Equals(CountryId)).ToList();
            }
        }

        //Bind Data to Country DropdownList
        private void BindCountry(DropDownList ddlCountry, List<Country> country)
        {
            ddlCountry.Items.Clear();
            ddlCountry.Items.Add(new ListItem { Text = "Select Country", Value = "0" });
            ddlCountry.AppendDataBoundItems = true;
            ddlCountry.DataTextField = "CountryName";
            ddlCountry.DataValueField = "CountryId";
            ddlCountry.DataSource = country;
            ddlCountry.DataBind();
        }

        //Bind Data to State DropdownList

        private void BindState(DropDownList ddlState, int countryId)
        {
            ddlState.Items.Clear();
            ddlState.Items.Add(new ListItem { Text = "Select State", Value = "0" });
            ddlState.AppendDataBoundItems = true;
            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateId";
            ddlState.DataSource = countryId > 0 ? PopulateState(countryId) : null;
            ddlState.DataBind();
        }

        protected void ddlCountry_SelectedIndex(object sender, EventArgs e)
        {
            string countryId = ((DropDownList)sender).SelectedValue;
            var dd = (DropDownList)((System.Web.UI.WebControls.ListControl)(sender)).Parent.Parent.FindControl("ddlState");
            BindState(dd, Convert.ToInt32(countryId));
        }
        protected void gvContacts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Insert New contact
            if(e.CommandName == "Insert")
            {
                Page.Validate("Add");
                if (Page.IsValid)
                {
                    var fRow = gvContacts.FooterRow;
                    TextBox txtContactPerson = (TextBox)fRow.FindControl("txtContactPerson");
                    TextBox txtContactNo = (TextBox)fRow.FindControl("txtContactNo");
                    DropDownList ddlCountry = (DropDownList)fRow.FindControl("ddlCountry");
                    DropDownList ddlState = (DropDownList)fRow.FindControl("ddlState");
                    using (MyDatabaseEntities dc = new MyDatabaseEntities())
                    {
                        dc.Contacts.Add(new Contact
                            {
                                ContactPerson = txtContactPerson.Text.Trim(),
                                ContactNo = txtContactNo.Text.Trim(),
                                CountryId = Convert.ToInt32(ddlCountry.SelectedValue),
                                StateId = Convert.ToInt32(ddlState.SelectedValue)
                            });
                        dc.SaveChanges();
                        PopulateContacts();
                    }
                }
            }
        }
    }
}