using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
public partial class StudentProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        this.LoadGrid();
        this.LoadGrid2();
        this.LoadGrid3();

    }
    private void LoadGrid()
    {
        try
        {
            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            Studentinfo.DataSource = objBL.GetStudent_Personal(Session["New"].ToString());//setting data source for the gridview
            Studentinfo.DataBind(); //bind the data source to the gridview
            Studentinfo.HeaderRow.Visible = false;
            Studentinfo.BorderStyle = BorderStyle.None;
            
            for (int i = 0; i < Studentinfo.Rows.Count; i++)
            {
                Studentinfo.Rows[i].Cells[1].BorderStyle = BorderStyle.None;
                Studentinfo.Rows[i].Cells[1].ForeColor = Color.White;
                Studentinfo.Rows[i].Cells[1].Font.Bold = false;
            }
            for (int i = 0; i < Studentinfo.Rows.Count; i++)
            {
                Studentinfo.Rows[i].BorderStyle = BorderStyle.None;
                Studentinfo.Rows[i].Cells[0].BorderStyle = BorderStyle.None;
                Studentinfo.Rows[i].Cells[0].ForeColor = Color.Khaki;
                Studentinfo.Rows[i].Cells[0].Font.Bold = true;
            }
        }
        catch (SqlException)
        {
            throw;
        }
    }

    private void LoadGrid2()
    {
        try
        {
            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            Studentinfo2.DataSource = objBL.GetStudent_University(Session["New"].ToString());//setting data source for the gridview
            Studentinfo2.DataBind(); //bind the data source to the gridview
            Studentinfo2.HeaderRow.Visible = false;
            Studentinfo2.BorderStyle = BorderStyle.None;
            Studentinfo2.Rows[0].Visible = false;
            for (int i = 0; i < Studentinfo2.Rows.Count; i++)
            {
                Studentinfo2.Rows[i].Cells[1].BorderStyle = BorderStyle.None;
                Studentinfo2.Rows[i].Cells[1].ForeColor = Color.White;
                Studentinfo2.Rows[i].Cells[1].Font.Bold = false;
            }
            for (int i = 0; i < Studentinfo2.Rows.Count; i++)
            {
                Studentinfo2.Rows[i].BorderStyle = BorderStyle.None;
                Studentinfo2.Rows[i].Cells[0].BorderStyle = BorderStyle.None;
                Studentinfo2.Rows[i].Cells[0].ForeColor = Color.Khaki;
                Studentinfo2.Rows[i].Cells[0].Font.Bold = true;
            }
        }
        catch (SqlException)
        {
            throw;
        }
    }

    private void LoadGrid3()
    {
        try
        {
            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            Studentinfo3.DataSource = objBL.GetStudent_Contact(Session["New"].ToString());//setting data source for the gridview
            Studentinfo3.DataBind(); //bind the data source to the gridview
            Studentinfo3.HeaderRow.Visible = false;
            Studentinfo3.BorderStyle = BorderStyle.None;
            Studentinfo3.Rows[0].Visible = false;
            for (int i = 0; i < Studentinfo3.Rows.Count; i++)
            {
                Studentinfo3.Rows[i].Cells[1].BorderStyle = BorderStyle.None;
                Studentinfo3.Rows[i].Cells[1].ForeColor = Color.White;
                Studentinfo3.Rows[i].Cells[1].Font.Bold = false;
            }
            for (int i = 0; i < Studentinfo3.Rows.Count; i++)
            {
                Studentinfo3.Rows[i].BorderStyle = BorderStyle.None;
                Studentinfo3.Rows[i].Cells[0].BorderStyle = BorderStyle.None;
                Studentinfo3.Rows[i].Cells[0].ForeColor = Color.Khaki;
                Studentinfo3.Rows[i].Cells[0].Font.Bold = true;
            }
        }
        catch (SqlException)
        {
            throw;
        }
    }
}