using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data.SqlClient;
public partial class list_of_students_in_class : System.Web.UI.Page
{
    BLItem objBL = new BLItem();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.LoadGrid();
        }
    }
    private void LoadGrid()
    {
        try
        {
            string course_id = Request.QueryString["val1"];
            string sectionid = Request.QueryString["val2"];
            string teacherID = Request.QueryString["val3"];
       
            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            Students.DataSource = objBL.getEnrolledStudents(course_id, sectionid, teacherID);//setting data source for the gridview
            Students.DataBind(); //bind the data source to the gridview    
            if (Students.Rows.Count > 0)
            {
                Students.BorderStyle = BorderStyle.None;
                Students.HeaderRow.ForeColor = Color.Khaki;
                Students.HeaderRow.BorderStyle = BorderStyle.None;
                Students.GridLines = GridLines.None;

                for (int i = 0; i < Students.Rows.Count; i++)
                {
                    Students.Rows[i].BorderStyle = BorderStyle.None;
                    for (int j = 0; j < Students.Columns.Count; j++)
                    {
                        Students.Rows[i].Cells[j].BorderStyle = BorderStyle.None;
                    }
                    Students.Rows[i].ForeColor = Color.White;
                }
            }
            else
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No Students in this class')", true);
            }
        }
        catch (SqlException)
        {
            throw;
        }

    }

    protected void Enter_Marks(object sender, CommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);

        // Retrieve the row that contains the button 
        // from the Rows collection.
        GridViewRow row = Students.Rows[index];
        string roll_no = row.Cells[0].Text;
        Session["roll_no"] = roll_no;
        Session["course_id"] = Request.QueryString["val1"];
        Session["section_id"] = Request.QueryString["val2"];
        Response.Redirect("Enter_Marks.aspx");
    }

    protected void Mark_Present(object sender, CommandEventArgs e)
    {
        string course_id = Request.QueryString["val1"];
        string sectionid = Request.QueryString["val2"];
       
        int index = Convert.ToInt32(e.CommandArgument);

        // Retrieve the row that contains the button 
        // from the Rows collection.
        GridViewRow row = Students.Rows[index];
        string roll_no = row.Cells[0].Text;


        objBL.Mark_Present(roll_no, course_id, sectionid);

    }
    protected void Mark_Absent(object sender, CommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string course_id = Request.QueryString["val1"];
        string sectionid = Request.QueryString["val2"];
       
        // Retrieve the row that contains the button 
        // from the Rows collection.
        GridViewRow row = Students.Rows[index];
        string roll_no = row.Cells[0].Text;
        objBL.Mark_Absent(roll_no, course_id, sectionid);

        // Add code here to add the item to the shopping cart.


    }
}