using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Employee_Teaches : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.LoadGrid(); 
        }
        
    }
    private void LoadGrid()
    {
        try
        {
            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            teacher_course_info.DataSource = objBL.Get_Employee_Current_Courses(Session["New"].ToString());//setting data source for the gridview
            teacher_course_info.DataBind(); //bind the data source to the gridview
         }
        catch (SqlException)
        {
            throw;
        }
    }
    protected void GridView1_RowCommand(object sender, CommandEventArgs e)
    {
            int index = Convert.ToInt32(e.CommandArgument);
            
            // Retrieve the row that contains the button 
            // from the Rows collection.
            GridViewRow row = teacher_course_info.Rows[index];
           string course_id= row.Cells[0].Text;
           string sectionid = row.Cells[2].Text;
           string teahcerid = Session["New"].ToString();
           Response.Redirect("list_of_students_in_class.aspx?val1="+course_id+"&val2="+sectionid+"&val3="+teahcerid);
           
        // Add code here to add the item to the shopping cart.
        

    }
   
}