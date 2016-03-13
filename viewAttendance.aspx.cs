using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class viewAttendance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            this.loadgrid();
        }
    }
    private void loadgrid()
    {
          DataTable dt = new DataTable();
          DataTable _dt1 = new DataTable();
          DataTable _dt2 = new DataTable();
          DataTable _dt3 = new DataTable();
          DataTable _dt4 = new DataTable();
        //Create an ID column for adding to the Datatable
        DataColumn dcol = new DataColumn("Lecture#" ,typeof(System.String));
        DataColumn dcol1 = new DataColumn("Lecture#", typeof(System.String));
        DataColumn dcol2 = new DataColumn("Lecture#", typeof(System.String));
        DataColumn dcol3 = new DataColumn("Lecture#", typeof(System.String));
        DataColumn dcol4 = new DataColumn("Lecture#", typeof(System.String));
        
        dt.Columns.Add(dcol);
        _dt1.Columns.Add(dcol1);
        _dt2.Columns.Add(dcol2);
        _dt3.Columns.Add(dcol3);
        _dt4.Columns.Add(dcol4);
      
        //Create an ID column for adding to the Datatable
        for (int i = 1; i <= 28; i++)
        {
            dcol = new DataColumn(i.ToString(), typeof(System.String));
            dcol1 = new DataColumn(i.ToString(), typeof(System.String));
            dcol2 = new DataColumn(i.ToString(), typeof(System.String));
            dcol3 = new DataColumn(i.ToString(), typeof(System.String));
            dcol4 = new DataColumn(i.ToString(), typeof(System.String));
           
            dt.Columns.Add(dcol);
            _dt1.Columns.Add(dcol1);
            _dt2.Columns.Add(dcol2);
            _dt3.Columns.Add(dcol3);
            _dt4.Columns.Add(dcol4);
        }
 
        //Now add data for dynamic columns
        //As the first column is auto-increment, we do not have to add any thing.
        //Let's add some data to the second column.
            //Create a new row
            DataRow drow = dt.NewRow();
            DataRow _drow1 = _dt1.NewRow();
            DataRow _drow2 = _dt2.NewRow();
            DataRow _drow3 = _dt3.NewRow();
            DataRow _drow4 = _dt4.NewRow();
 
            //Initialize the row data.
            
 
            //Add the row to the datatable.
            
       
        BLItem objBL=new BLItem();
        DataTable dt1=objBL.get_courses_from_attendance(Session["New"].ToString());
        int count = 0;
        foreach (DataRow row in dt1.Rows) // parse each row of datatable
        {
            if (!row["courseName"].ToString().Equals(DBNull.Value)) // check if ItemNo is not null
            {
                if (count == 0)
                {
                    Head1.Visible = true;
                    Head1.Text = row["courseName"].ToString();
                    DataTable dt2 = objBL.get_lectures_from_Attendance(Session["New"].ToString(),row["courseID"].ToString(),row["sectionID"].ToString());
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            if (i.ToString() == row2["lectureNo"].ToString())
                            {
                                drow[i.ToString()] = "A";
                            }
                            else
                            {
                                if (drow[i.ToString()].ToString()!="A")
                                {
                                    drow[i.ToString()] = "-";
                                }
                            }
                        }
                    
                    }
                    dt.Rows.Add(drow);
                     
                    grd.DataSource = dt;
                    grd.DataBind();
                }
                if (count == 1)
                {
                    Head2.Visible = true;
                    Head2.Text = row["courseName"].ToString();
                    DataTable dt2 = objBL.get_lectures_from_Attendance(Session["New"].ToString(), row["courseID"].ToString(), row["sectionID"].ToString());
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            if (i.ToString() == row2["lectureNo"].ToString())
                            {
                                _drow1[i.ToString()] = "A";
                            }
                            else
                            {
                                if (_drow1[i.ToString()] .ToString()!= "A")
                                {
                                    _drow1[i.ToString()] = "-";
                                }
                            }
                   
                        }
                      }
                    _dt1.Rows.Add(_drow1);
                   
                    grd1.DataSource = _dt1;
                    grd1.DataBind();
                }

                if (count == 2)
                {
                    Head3.Visible = true;
                    Head3.Text = row["courseName"].ToString();
                    DataTable dt2 = objBL.get_lectures_from_Attendance(Session["New"].ToString(), row["courseID"].ToString(), row["sectionID"].ToString());
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            if (i.ToString() == row2["lectureNo"].ToString())
                            {
                                _drow2[i.ToString()] = "A";
                            }
                            else
                            {
                                if (_drow2[i.ToString()].ToString() != "A")
                                {
                                    _drow2[i.ToString()] = "-";
                                }
                            }
                        }
                        _dt2.Rows.Add(_drow2);
                  
                    }
                    _dt2.Rows.Add(_drow2);
                   
                    grd2.DataSource = _dt2;
                    grd2.DataBind();
  
                
                }

                if (count == 3)
                {
                    Head4.Visible = true;
                    Head4.Text = row["courseName"].ToString();
                    DataTable dt2 = objBL.get_lectures_from_Attendance(Session["New"].ToString(), row["courseID"].ToString(), row["sectionID"].ToString());
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            if (i.ToString() == row2["lectureNo"].ToString())
                            {
                                _drow3[i.ToString()] = "A";
                            }
                            else
                            {
                                if (_drow3[i.ToString()].ToString() != "A")
                                {
                                    _drow3[i.ToString()] = "-";
                                }
                            }
                        }
                        _dt3.Rows.Add(_drow3);
                 
                    }
                    _dt3.Rows.Add(_drow3);
                   
                    grd3.DataSource = _dt3;
                    grd3.DataBind();

       
                }
                if (count == 4)
                {
                    Head5.Visible = true;
                    Head5.Text = row["courseName"].ToString();
                    DataTable dt2 = objBL.get_lectures_from_Attendance(Session["New"].ToString(), row["courseID"].ToString(), row["sectionID"].ToString());
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            if (i.ToString() == row2["lectureNo"].ToString())
                            {
                                _drow4[i.ToString()] = "A";
                            }
                            else
                            {
                                if (_drow4[i.ToString()].ToString() != "A")
                                {
                                    _drow4[i.ToString()] = "-";
                                }
                            }
                        }
        
                    }
                    _dt4.Rows.Add(_drow4);
        
                    grd4.DataSource = _dt4;
                    grd4.DataBind();

                }
                 count++;
            }


       
        }

        }



}
