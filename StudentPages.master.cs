using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
public partial class StudentPages : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BLItem objBL=new BLItem();
        if (!Page.IsPostBack)
        {

            if (Session["New"] != null)
            {
                Label_welcome.Text += Session["New"].ToString();
                string image=objBL.get_image(Session["New"].ToString());
                if (image.Length<=0)
                {
                    image = "uploadedimages/default.png";
                }
                    Image1.ImageUrl=image;
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
    private void LoadImage()
    {


    }
    protected void Log_Out(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Login.aspx");
    }
    
}
