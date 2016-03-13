using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class viewMarks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.LoadGrid();
    }
    private void LoadGrid()
    {
        BLItem objBL = new BLItem();
        DataTable temp = new DataTable();
        DataTable original = objBL.Get_Marks_Of_Student(Session["New"].ToString());
        List<DataTable> tables = new List<DataTable>();
        int i = 0;
        int j = 1;
        DataTable newDt = original.Clone();
        newDt.TableName = "Table_" + j;
        newDt.Clear();
        foreach (DataRow row in original.Rows)
        {
            DataRow newRow = newDt.NewRow();
            newRow.ItemArray = row.ItemArray;
            newDt.Rows.Add(newRow);
            i++;
            if (i == 1)
            {
                Head1.Visible = true;
                Head1.Text = newDt.Rows[0][2].ToString();
                Course1.DataSource = newDt;
                Course1.DataBind();
                newDt = original.Clone();
                newDt.Clear();
            }
            if (i == 2)
            {
                Head2.Visible = true;
                Head2.Text = newDt.Rows[0][2].ToString();
                Course2.DataSource = newDt;
                Course2.DataBind();
                newDt = original.Clone();
                newDt.Clear();
            }
            if (i == 3)
            {
                Head3.Visible = true;
                Head3.Text = newDt.Rows[0][2].ToString();
                Course3.DataSource = newDt;
                Course3.DataBind();
                newDt = original.Clone();
                newDt.Clear();

            }
            if (i == 4)
            {
                Head4.Visible = true;
                Head4.Text = newDt.Rows[0][2].ToString();
                Course4.DataSource = newDt;
                Course4.DataBind();
                newDt = original.Clone();
                newDt.Clear();

            }
            if (i == 5)
            {
                Head5.Visible = true;
                Head5.Text = newDt.Rows[0][2].ToString();
                Course5.DataSource = newDt;
                Course5.DataBind();
                newDt = original.Clone();
                newDt.Clear();

            }

        }
    }
}