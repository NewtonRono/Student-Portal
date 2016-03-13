using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
           

        }

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        try
        {
            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            string username = user_id.Text;
            string campus = logincampus.SelectedItem.ToString();
            int LoginAs = Login_As.SelectedIndex;
            int temp=0,temp2=1;
            if (LoginAs == 0)
            {
               temp = objBL.check_student_username(username);
               if (temp == 1 )
               {
                   temp2 = objBL.check_student_campus(username, campus);
                   if (temp2 == 0)
                   {
                       string password = user_pass.Text;
                       int temp1 = objBL.check_student_password(username, password);
                       if (temp1 == 0)
                       {
                           Session["New"] = user_id.Text;

                           Response.Write("Password is correct");
                           Response.Redirect("StudentProfile.aspx");

                       }
                       else
                       {
                           Response.Write("Incorrect Password");
                       }
                   }
                   else
                   {
                       Response.Write("incorrect username");

                   }
               }
               else
               {
                   Response.Write("incorrect username");


               }
            }
            else if (LoginAs == 2)
            {
                temp = objBL.check_admin_username(username);
                if (temp == 1 )
                {
                    temp2 = objBL.check_admin_campus(username, campus);
                    if (temp2 == 0)
                    {
                        string password = user_pass.Text;
                        int temp1 = objBL.check_admin_password(username, password);
                        if (temp1 == 0)
                        {
                            Session["New"] = user_id.Text;
                            Response.Write("Password is correct");
                            Response.Redirect("Admin_Profile.aspx");
                        }
                        else
                        {
                            Response.Write("Incorrect Password");
                        }
                    }
                    else
                    {
                        Response.Write("incorrect username");
                    }
                }
                else
                {
                    Response.Write("incorrect username");

                }
            }
            else if (LoginAs == 1)
            {
                temp = objBL.check_Emp_username(username);
                if (temp == 1)
                {
                    temp2 = objBL.check_Emp_campus(username, campus);
                    if (temp2 == 0)
                    {
                        string password = user_pass.Text;
                        int temp1 = objBL.check_Emp_password(username, password);
                        if (temp1 == 0)
                        {
                            Session["New"] = user_id.Text;
                            Response.Write("Password is correct");
                            Response.Redirect("EmployeeProfile.aspx");
                        }
                        else
                        {
                            Response.Write("Incorrect Password");
                        }
                    }
                    else
                    {
                        Response.Write("incorrect username");
                    }
                }
                else
                {
                    Response.Write("incorrect username");

                }
            }
        }
        catch (SqlException)
        {
            throw;
        }
        
    }
}