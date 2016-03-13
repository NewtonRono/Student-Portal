using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
public partial class Teacher_Registeration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            status.Visible = false;
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            string username = User_ID.Text;
            string fname = Fname.Text;
            string lname = Lname.Text;
            string password = Passwd.Text;
            int campus = Campus.SelectedIndex + 1;
            string _Mname = Mname.Text;
            string _gid = gid.Text;
            string _gender = gender.SelectedItem.Text;
            string _dob = dob.Text;
            string _temp_addr = temp_addr.Text;
            string _p_addr = pr_addr.Text;
            string _c_no = c_no.Text;
            string _cnic = cnic.Text;
            string _p_em = p_em.Text;
            string _o_em = o_em.Text;
            int _deptid = deptid.SelectedIndex + 1;
            string _d_jn = d_en.Text;
            string _bg = bg.SelectedItem.Text;
            string _status = status1.Text;
            string type = Type.SelectedValue;
            //uplodaing image
            bool image_loaded = true;
            string pathName = null;
            if (imgupload.HasFile)
            {
                string extension = System.IO.Path.GetExtension(imgupload.FileName);
                if (extension.ToLower() != ".gif" && extension.ToLower() != ".png" && extension.ToLower() != ".jpg" && extension.ToLower() != ".jpeg")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('invalid image format');", true);
                }
                else
                {
                    int file_size = imgupload.PostedFile.ContentLength;
                    if (file_size > 1048576)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('max file size is 1 mb');", true);
                        image_loaded = false;
                    }
                    else
                    {
                        pathName = "uploadedimages/" + Path.GetFileName(imgupload.PostedFile.FileName);

                    }
                }
            }
            int temp2 = objBL.check_Emp_username(username);
            if (temp2 == 0)
            {
                int temp = objBL.insertIntoEmployee(username, fname, lname, password, campus, _Mname, _gid, _gender, _dob, _temp_addr, _p_addr, _p_em, _o_em, _c_no, _cnic, _deptid, _bg, _d_jn, _status, type, pathName);
                imgupload.SaveAs(Server.MapPath("~/uploadedimages/" + imgupload.FileName));
                if (temp >= 0 && image_loaded)
                {
                    status.Visible = true;
                    status.Text = "Registration is successful";

                    //Response.Redirect("Admin_Student_Registeration.aspx"); 
                }
                else
                {
                    status.Visible = true;
                    status.Text = "Unable to register";
                }
            }
            else if (temp2 != 0)
            {
                status.Visible = true;
                status.Text = "username already exists";
                //Response.Redirect("Admin_Student_Registeration.aspx");

            }

        }
        catch (SqlException)
        {
            throw;
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        User_ID.Text = "";
        Fname.Text = "";
        Lname.Text = "";
        Passwd.Text = "";
        Mname.Text = "";
    }
}