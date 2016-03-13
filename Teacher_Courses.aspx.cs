using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Teacher_Courses : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Button1.Visible = false;
            dd1.Visible = false;
            status.Visible = false;
            FillDeptDropdownList();

        }
    }
    protected void FillDeptDropdownList()
    {
        BLItem objBL = new BLItem();

        DataTable dt = objBL.get_available_courses(int.Parse(Session["New"].ToString()), 3);
        
        dd.DataSource = dt;
        dd.DataTextField = "courseName";
        dd.DataValueField = "courseID";
        dd.DataBind();
        dd.Items.Insert(0, new ListItem("Select Course", "-1"));
        
    }
    protected void insert_courses(object sender, EventArgs e)
    
    {
        BLItem objBL = new BLItem();
        string courseID = dd.SelectedValue;
        string teacherID = empID.Text;
        int temp=objBL.check_Emp_username(teacherID);
        if (temp == 1)
        {
            submit.Visible = false;
            Button1.Visible = true;
        
            DataTable dt = objBL.get_available_sections(courseID);
            dd1.Visible = true;
            dd1.DataSource = dt;
            dd1.DataTextField = "SectionID";
            dd1.DataValueField = "SectionID";
            dd1.DataBind();
            dd1.Items.Insert(0, new ListItem("Select SectionID", "-1"));
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Employee Does Not Exist.')", true);

        }
    }
   protected void insert_courses1(object sender, EventArgs e)
    {

        BLItem objBL = new BLItem();
        string sectionID = dd1.SelectedItem.Text;
        string courseID = dd.SelectedValue;
        string teacherID = empID.Text;
        objBL.enter_teacher_courses(teacherID, courseID, sectionID);
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Registration Is Successfull.')", true);

    }
}