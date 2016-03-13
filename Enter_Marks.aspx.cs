using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Enter_Marks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void submit_Click(object sender, EventArgs e)
    {

        BLItem objBL = new BLItem();
        string roll_no = Session["roll_no"].ToString();
        string section_id = Session["section_id"].ToString();

        string q1 = quiz1.ToString();
        string q2 = quiz2.ToString();
        string q3 = quiz3.ToString();
        string a1 = ass1.ToString();
        string a2 = ass2.ToString();
        string a3 = ass3.ToString();
        string m1 = mid1.ToString();
        string m2 = mid2.ToString();
        string fnl = final.ToString();

        objBL.enter_Marks(roll_no, section_id, q1, q2, q3, a1, a2, a3, m1, m2, fnl);

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Marks Entered.')", true);

        resetFields();
    }

    protected void resetFields()
    {
        quiz1.Text = "";
        quiz2.Text = "";
        quiz3.Text = "";
        ass1.Text = "";
        ass2.Text = "";
        ass3.Text = "";
        mid1.Text = "";
        mid2.Text = "";
        final.Text = "";
    }
}