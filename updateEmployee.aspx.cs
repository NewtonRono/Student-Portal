using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
public partial class updateEmployee : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            status.Visible = false;
            this.LoadGrid();

        }
    }
    private void LoadGrid()
    {
        string userid = Request.QueryString["val1"];
        BLItem objBL = new BLItem(); // declare and initialize BLItem object
        int temp = objBL.check_Emp_username(userid);
        if (temp == 1)
        {
            string image = objBL.get_image_from_emp(userid);
            if (image.Length <= 0)
            {
                image = "uploadedimages/default.png";
            }
            //   Image1.ImageUrl = image;

            DataTable dt = objBL.GetEmployee(userid, 0);
            grdContact.DataSource = dt;
            grdContact.DataBind();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Student Does Not Exist.')", true);
            //Response.Redirect("View_Student.aspx");
        }

    }
    protected void grdContact_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdContact.EditIndex = e.NewEditIndex;
        this.LoadGrid();
    }
    protected void grdContact_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    }
    protected void grdContact_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdContact.EditIndex = -1;
        this.LoadGrid();

    }
    protected void grdContact_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        BLItem objBL = new BLItem();
        TextBox guardianid = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t2");
        TextBox fname = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t3");
        TextBox mname = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t4");
        TextBox lname = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t5");
        DropDownList gender = (DropDownList)grdContact.Rows[e.RowIndex].FindControl("gen");
        TextBox dob = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t7");
        TextBox temp_addr = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t8");
        TextBox p_addr = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t9");
        TextBox c_no = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t10");
        TextBox cnic = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t11");
        TextBox p_em = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t12");
        TextBox o_em = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t13");
        TextBox d_en = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t14");
        DropDownList bg = (DropDownList)grdContact.Rows[e.RowIndex].FindControl("t15");
        DropDownList c_id = (DropDownList)grdContact.Rows[e.RowIndex].FindControl("cmp");
        TextBox cgpa = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t17");
        TextBox password = (TextBox)grdContact.Rows[e.RowIndex].FindControl("t19");
        FileUpload photo = (FileUpload)grdContact.Rows[e.RowIndex].FindControl("t20");
        string userid = Request.QueryString["val1"];
        bool image_loaded = true;

        string pathName = null;
        if (photo.HasFile)
        {
            string extension = System.IO.Path.GetExtension(photo.FileName);
            if (extension.ToLower() != ".gif" && extension.ToLower() != ".png" && extension.ToLower() != ".jpg" && extension.ToLower() != ".jpeg")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('invalid image format');", true);
            }
            else
            {
                int file_size = photo.PostedFile.ContentLength;
                if (file_size > 1048576)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('max file size is 1 mb');", true);
                    image_loaded = false;
                }
                else
                {
                    pathName = "uploadedimages/" + Path.GetFileName(photo.PostedFile.FileName);

                }
            }
        }
        
        int temp = objBL.updateEmployee(userid, fname.Text, lname.Text, password.Text, c_id.SelectedIndex + 1, mname.Text, guardianid.Text, gender.SelectedItem.Text, dob.Text, temp_addr.Text, p_addr.Text, p_em.Text, o_em.Text, c_no.Text, cnic.Text, bg.SelectedItem.Value, d_en.Text, status.Text, pathName);
        photo.SaveAs(Server.MapPath("~/uploadedimages/" + photo.FileName));
        if (temp >= 0 && image_loaded)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Update is Successfull')", true);

            //Response.Redirect("Admin_Student_Registeration.aspx"); 
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Unable To Update')", true);

        }





    }
    protected void grdContact_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
    }
    protected void grdContact_RowCommand(object sender, GridViewCommandEventArgs e)
    {
    }

}