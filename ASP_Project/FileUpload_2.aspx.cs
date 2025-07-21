using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FileUpload_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Boolean FileOk = false;
        string path = Server.MapPath("~/Upload_Files/");
        if (FileUpload1.HasFile)
        {
            string FileEx = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            string[] alex = { ".txt",".doc", ".xls" };
            for (int i = 0; i < alex.Length; i++)
            {
                if (FileEx == alex[i])
                {
                    FileOk = true;
                    break;
                }
            }
        }
        if (FileOk)
        {
            try
            {
                FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);
                Literal1.Text = "File Uploaded Successfully";
            }
            catch (Exception ex)
            {
                Literal1.Text = "File could not be uploaded" + ex.Message;
            }
        }
        else
        {
            Literal1.Text = "Cannot accept the file of this type";
        }
    }
}