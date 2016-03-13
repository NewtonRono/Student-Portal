using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BLItem objBL = new BLItem();
        if (!Page.IsPostBack)
        {
            if (Session["New"] != null)
            {
                Label_welcome.Text += Session["New"].ToString();
                string image = objBL.get_image_from_emp(Session["New"].ToString());
                if (image.Length <= 0)
                {
                    image = "uploadedimages/default.png";
                }
                Image1.ImageUrl = image;
            }
            else
            {
                Response.Redirect("Login.aspx");

            }
        }
        else
        {
            if (Session["New"] == null)
            {
                Response.Redirect("Login.aspx");

            }
         
        }
    }
    protected void Log_Out(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Login.aspx");
    }

    private void ShowSelectedImage(int id)
    {
        Image1.ImageUrl = "ShowStudentImage.ashx?imageid=" + id.ToString();
    }
}
