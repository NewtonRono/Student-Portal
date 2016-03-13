using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
public partial class EmployeeProfile : System.Web.UI.Page
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
            Empinfo.DataSource = objBL.GetEmployee_Personal(Session["New"].ToString());//setting data source for the gridview
            Empinfo.DataBind(); //bind the data source to the gridview
            Empinfo.HeaderRow.Visible = false;
            Empinfo.BorderStyle = BorderStyle.None;
            for (int i = 0; i < Empinfo.Rows.Count; i++)
            {
                Empinfo.Rows[i].Cells[1].BorderStyle = BorderStyle.None;
                Empinfo.Rows[i].Cells[1].ForeColor = Color.White;
                Empinfo.Rows[i].Cells[1].Font.Bold = false;
            }
            for (int i = 0; i < Empinfo.Rows.Count; i++)
            {
                Empinfo.Rows[i].BorderStyle = BorderStyle.None;
                Empinfo.Rows[i].Cells[0].BorderStyle = BorderStyle.None;
                Empinfo.Rows[i].Cells[0].ForeColor = Color.Khaki;
                Empinfo.Rows[i].Cells[0].Font.Bold = true;
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
            Empinfo2.DataSource = objBL.GetEmployee_University(Session["New"].ToString());//setting data source for the gridview
            Empinfo2.DataBind(); //bind the data source to the gridview
            Empinfo2.HeaderRow.Visible = false;
            Empinfo2.BorderStyle = BorderStyle.None;
            Empinfo2.Rows[0].Visible = false;
            for (int i = 0; i < Empinfo2.Rows.Count; i++)
            {
                Empinfo2.Rows[i].Cells[1].BorderStyle = BorderStyle.None;
                Empinfo2.Rows[i].Cells[1].ForeColor = Color.White;
                Empinfo2.Rows[i].Cells[1].Font.Bold = false;
            }
            for (int i = 0; i < Empinfo2.Rows.Count; i++)
            {
                Empinfo2.Rows[i].BorderStyle = BorderStyle.None;
                Empinfo2.Rows[i].Cells[0].BorderStyle = BorderStyle.None;
                Empinfo2.Rows[i].Cells[0].ForeColor = Color.Khaki;
                Empinfo2.Rows[i].Cells[0].Font.Bold = true;
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
            Empinfo3.DataSource = objBL.GetEmployee_Contact(Session["New"].ToString());//setting data source for the gridview
            Empinfo3.DataBind(); //bind the data source to the gridview
            Empinfo3.HeaderRow.Visible = false;
            Empinfo3.Rows[0].Visible = false;
            Empinfo3.BorderStyle = BorderStyle.None;
            for (int i = 0; i < Empinfo3.Rows.Count; i++)
            {
                Empinfo3.Rows[i].Cells[1].BorderStyle = BorderStyle.None;
                Empinfo3.Rows[i].Cells[1].ForeColor = Color.White;
                Empinfo3.Rows[i].Cells[1].Font.Bold = false;
            }
            for (int i = 0; i < Empinfo3.Rows.Count; i++)
            {
                Empinfo3.Rows[i].BorderStyle = BorderStyle.None;
                Empinfo3.Rows[i].Cells[0].BorderStyle = BorderStyle.None;
                Empinfo3.Rows[i].Cells[0].ForeColor = Color.Khaki;
                Empinfo3.Rows[i].Cells[0].Font.Bold = true;
            }
        }

        catch (SqlException)
        {
            throw;
        }
    }
}