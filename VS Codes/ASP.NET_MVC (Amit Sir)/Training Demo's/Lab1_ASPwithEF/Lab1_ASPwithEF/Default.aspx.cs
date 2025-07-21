using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Lab1_ASPwithEF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateProductList();
            }
        }

        //TO get product list from the database
        protected void PopulateProductList()
        {
            Database1Entities entity = new Database1Entities();
            List<Product> prodList = entity.SearchProduct(txtProdName.Text).ToList();
            GridView1.DataSource = prodList;
            GridView1.DataBind();
            ddlProduct.DataSource = prodList;
            ddlProduct.DataTextField = "ProductName";
            ddlProduct.DataValueField = "ProductId";
            ddlProduct.DataBind();
            ddlProduct.Items.Insert(0, new ListItem("Insert a Product", "0"));
        }

        //Clear Form
        protected void ClearForm()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtProdName.Text = "";
            txtQuantity.Text = "";
            btnSave.CommandArgument = "0";
            btnSave.Text = "SAVE";
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateProductList();
        }

        protected void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database1Entities entity = new Database1Entities();
            int pId = Convert.ToInt32(ddlProduct.SelectedValue);
            if (pId == 0)
            {
                ClearForm();
            }
            btnSave.CommandArgument = pId.ToString();
            btnSave.Text = "UPDATE";

            var prodValue = from product in entity.Products
                            where product.ProductId == pId
                            select product;
            
            Product prodObj = prodValue.Single();

            txtName.Text = prodObj.ProductName;
            txtPrice.Text = prodObj.Price.ToString();
            txtQuantity.Text = prodObj.Quantity.ToString();

            List<Product> lst = entity.SearchProduct(prodObj.ProductName).ToList();
            GridView1.DataSource = lst;
            GridView1.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Database1Entities entity = new Database1Entities();
            if (btnSave.Text == "SAVE")
            {
                Product prodObj = new Product();
                prodObj.ProductName = txtName.Text;
                prodObj.Price = Convert.ToDouble(txtPrice.Text);
                prodObj.Quantity = Convert.ToInt32(txtQuantity.Text);

                entity.Products.Add(prodObj);
                entity.SaveChanges();
            }
            else
            {
                int pId = Convert.ToInt32(ddlProduct.SelectedValue);
                var prodValue = from product in entity.Products
                                where product.ProductId == pId
                                select product;

                Product prodObj = prodValue.Single();

                prodObj.ProductName = txtName.Text;
                prodObj.Price = Convert.ToDouble(txtPrice.Text);
                prodObj.Quantity = Convert.ToInt32(txtQuantity.Text);
                entity.SaveChanges();
            }
            ClearForm();
            PopulateProductList();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int pID = Convert.ToInt32(btnSave.CommandArgument);
            if(pID!=0)
            {
                Database1Entities entity = new Database1Entities();
                Product prodObj = new Product() { ProductId = pID };
                entity.Products.Attach(prodObj);
                entity.Products.Remove(prodObj);
                entity.SaveChanges();
            }
            ClearForm();
            PopulateProductList();
        }
    }
}