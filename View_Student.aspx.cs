using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
public partial class View_Student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {


        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            int temp = objBL.check_student_username(TextBox1.Text);
            if (temp == 1)
            {
                string image=objBL.get_image(TextBox1.Text);
                if (image.Length<=0)
                {
                    image = "uploadedimages/default.png";
                }
                    Image1.ImageUrl=image;
                student.DataSource = objBL.GetStudent_Personal(TextBox1.Text);
                student.DataBind();
                student.HeaderRow.Visible = false;
                student.BorderStyle = BorderStyle.None;
                update.Visible = true;
             
                for (int i = 0; i < student.Rows.Count; i++)
                {
                    student.Rows[i].Cells[1].BorderStyle = BorderStyle.None;
                    student.Rows[i].Cells[1].ForeColor = Color.White;
                    student.Rows[i].Cells[1].Font.Bold = false;
                }
                for (int i = 0; i < student.Rows.Count; i++)
                {
                    student.Rows[i].BorderStyle = BorderStyle.None;
                    student.Rows[i].Cells[0].BorderStyle = BorderStyle.None;
                    student.Rows[i].Cells[0].ForeColor = Color.Khaki;
                    student.Rows[i].Cells[0].Font.Bold = true;
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Student Does Not Exist.')", true);
                //Response.Redirect("View_Student.aspx");
            }
        }
        catch (SqlException)
        {
            throw;
        }
    }
    protected void EditRow(object sender, CommandEventArgs e)
    {
        Response.Redirect("updateStudent.aspx?val1=" + TextBox1.Text);

    }

}