using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
public partial class Admin_Profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.LoadGrid();
    }
    private void LoadGrid()
    {
        try
        {
            BLItem objBL = new BLItem(); // declare and initialize BLItem object
            Admininfo.DataSource = objBL.GetAdmin(Session["New"].ToString());//setting data source for the gridview
            Admininfo.DataBind(); //bind the data source to the gridview
            Admininfo.HeaderRow.Visible = false;
            Admininfo.BorderStyle = BorderStyle.None;
            Admininfo.Rows[14].Visible = false;
            Admininfo.Rows[17].Visible = false;
            Admininfo.Rows[18].Visible = false;
            Admininfo.Rows[19].Visible = false;
            for (int i = 0; i < Admininfo.Rows.Count; i++)
            {
                Admininfo.Rows[i].Cells[1].BorderStyle = BorderStyle.None;
                Admininfo.Rows[i].Cells[1].ForeColor = Color.White;
                Admininfo.Rows[i].Cells[1].Font.Bold = false;
            }
            for (int i = 0; i < Admininfo.Rows.Count; i++)
            {
                Admininfo.Rows[i].BorderStyle = BorderStyle.None;
                Admininfo.Rows[i].Cells[0].BorderStyle = BorderStyle.None;
                Admininfo.Rows[i].Cells[0].ForeColor = Color.Khaki;
                Admininfo.Rows[i].Cells[0].Font.Bold = true;
            }
        }
        catch (SqlException)
        {
            throw;
        }
    }
}