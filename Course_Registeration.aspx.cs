using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Course_Registeration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            status.Visible = false;
            FillDeptDropdownList();

        }

    }
    protected void FillDeptDropdownList()
    {
        BLItem objBL = new BLItem();
 
        DataTable dt = objBL.get_available_courses(int.Parse(Session["New"].ToString()),3);
        DataTable dt1 = objBL.get_available_courses(int.Parse(Session["New"].ToString()), 1);
        
        DropDownList0.DataSource = dt;
        DropDownList0.DataTextField = "courseName";
        DropDownList0.DataValueField = "courseID";
        DropDownList0.DataBind();
        //DropDownList0.Items.Insert(0, "Select Course");
        DropDownList0.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = "courseName";
        DropDownList1.DataValueField = "courseID";
        DropDownList1.DataBind();
        //DropDownList1.Items.Insert(0, "Select Course");
        DropDownList1.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList2.DataSource = dt;
        DropDownList2.DataTextField = "courseName";
        DropDownList2.DataValueField = "courseID";
        DropDownList2.DataBind();
        //DropDownList2.Items.Insert(0, "Select Course");
        DropDownList2.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList3.DataSource = dt;
        DropDownList3.DataTextField = "courseName";
        DropDownList3.DataValueField = "courseID";
        DropDownList3.DataBind();
        //DropDownList3.Items.Insert(0, "Select Course");
        DropDownList3.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList4.DataSource = dt;
        DropDownList4.DataTextField = "courseName";
        DropDownList4.DataValueField = "courseID";
        DropDownList4.DataBind();
        //DropDownList4.Items.Insert(0, "Select Course");
        DropDownList4.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList5.DataSource = dt1;
        DropDownList5.DataTextField = "courseName";
        DropDownList5.DataValueField = "courseID";
        DropDownList5.DataBind();
        //DropDownList5.Items.Insert(0, "Select Course");
        DropDownList5.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList6.DataSource = dt1;
        DropDownList6.DataTextField = "courseName";
        DropDownList6.DataValueField = "courseID";
        DropDownList6.DataBind();
        //DropDownList6.Items.Insert(0, "Select Course");
        DropDownList6.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList7.DataSource = dt1;
        DropDownList7.DataTextField = "courseName";
        DropDownList7.DataValueField = "courseID";
        DropDownList7.DataBind();
        //DropDownList7.Items.Insert(0, "Select Course");
        DropDownList7.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList8.DataSource = dt1;
        DropDownList8.DataTextField = "courseName";
        DropDownList8.DataValueField = "courseID";
        DropDownList8.DataBind();
        //DropDownList8.Items.Insert(0, "Select Course");
        DropDownList8.Items.Insert(0, new ListItem("Select Course", "-1"));       

        DropDownList9.DataSource = dt1;
        DropDownList9.DataTextField = "courseName";
        DropDownList9.DataValueField = "courseID";
        DropDownList9.DataBind();
        //DropDownList9.Items.Insert(0, "Select Course");
        DropDownList9.Items.Insert(0, new ListItem("Select Course", "-1"));       

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        BLItem objBL = new BLItem();
        int crdHrs=objBL.get_credit_hours(int.Parse(Session["New"].ToString()),1);
        int curr_sems_no = objBL.get_current_semester_no(int.Parse(Session["New"].ToString()),0);
        int curr_sems_id = objBL.get_current_semester_no(int.Parse(Session["New"].ToString()), 1);
        bool flag1 = false, flag2 = false, flag3 = false, flag4 = false, flag5 = false, flag6 = false, flag7 = false, flag8 = false, flag9 = false, flag10 = false;
        string course1 = DropDownList0.SelectedItem.Value;
        if (course1 != "-1" && add31.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course1), curr_sems_id) == 1)
            {
                Label1.Visible = true;
                Label1.Text = "You have already added this course.";
                flag1 = true;
        
            }
            else
            {
                crdHrs += 3;
            }
        }
        else if (course1 != "-1" && drop31.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course1), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course1));
                crdHrs -= 3;
                Label1.Visible = true;
                Label1.Text = "Course dropped successfully.";
        
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "You can not drop Course which you are not studying.";
        
            }
        }
        string course2 = DropDownList1.SelectedValue.ToString();
        if (course2 != "-1" && add32.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course2), curr_sems_id) == 1)
            {
                Label3.Visible = true;
                Label3.Text = "You have already added this course.";
                flag2 = true;
        
            }
            else
            {
                crdHrs += 3;
            }
        }
        else if (course2 != "-1" && drop32.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course2), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course2));
                crdHrs -= 3;
                Label3.Visible = true;
                Label3.Text = "Course dropped successfully.";
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "You can not drop Course which you are not studying.";
        
            }
        }
        string course3 = DropDownList2.SelectedValue.ToString();
        if (course3 != "-1" && add33.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course3), curr_sems_id) == 1)
            {
                Label5.Visible = true;
                Label5.Text = "You have already added this course.";
                flag3 = true;
        
            }
            else
            {
                crdHrs += 3;
            }
        }
        else if (course3 != "-1" && drop33.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course3), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course3));
                crdHrs -= 3;
                Label5.Visible = true;
                Label5.Text = "Course dropped successfully.";
            }
            else
            {
                Label5.Visible = true;
                Label5.Text = "You can not drop Course which you are not studying.";
        
            }
        }
        string course4 = DropDownList3.SelectedValue.ToString();
        if (course4 != "-1" && add34.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course4), curr_sems_id) == 1)
            {
                Label7.Visible = true;
                Label7.Text = "You have already added this course.";
                flag4 = true;
        
            }
            else
            {
                crdHrs += 3;
            }
        }
        else if (course4 != "-1" && drop34.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course4), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course4));
                crdHrs -= 3;
                Label7.Visible = true;
                Label7.Text = "Course dropped successfully.";
            }
            else
            {
                Label7.Visible = true;
                Label7.Text = "You can not drop Course which you are not studying.";
            }
        }
        string course5 = DropDownList4.SelectedValue.ToString();
        if (course5 != "-1" && add35.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course5), curr_sems_id) == 1)
            {
                Label9.Visible = true;
                Label9.Text = "You have already added this course.";
                flag5 = true;
        
            }
            else
            {
                crdHrs += 3;
            }
        }
        else if (course5 != "-1" && drop35.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course5), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course5));
                crdHrs -= 3;
                Label9.Visible = true;
                Label9.Text = "Course dropped successfully.";
            }
            else
            {
                Label9.Visible = true;
                Label9.Text = "You can not drop Course which you are not studying.";
            }
        }
        string course6 = DropDownList5.SelectedValue.ToString();
        if (course6 != "-1" && add11.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course6), curr_sems_id) == 1)
            {
                Label2.Visible = true;
                Label2.Text = "You have already added this course.";
                flag6 = true;
        
            }
            else
            {
                crdHrs += 1;
            }

        }
        else  if (course6 != "-1" && drop11.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course6), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course6));
                crdHrs -= 1;
                Label2.Visible = true;
                Label2.Text = "Course dropped successfully.";
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "You can not drop Course which you are not studying.";
        
            }
        }
        string course7 = DropDownList6.SelectedValue.ToString();
        if (course7 != "-1" && add12.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course7), curr_sems_id) == 1)
            {
                Label4.Visible = true;
                Label4.Text = "You have already added this course.";
                flag7 = true;
        
            }
            else
            {
                crdHrs += 1;
            }

        }
        else if (course7 != "-1" && drop12.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course7), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course7));
                crdHrs -= 1;
                Label4.Visible = true;
                Label4.Text = "Course dropped successfully.";
            }
            else
            {
                Label4.Visible = true;
                Label4.Text = "You can not drop Course which you are not studying.";
                
            }
        }
        string course8 = DropDownList7.SelectedValue.ToString();
        if (course8 != "-1" && add13.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course8), curr_sems_id) == 1)
            {
                Label6.Visible = true;
                Label6.Text = "You have already added this course.";
                flag8 = true;
        
            }
            else
            {
                crdHrs += 1;
            }
        }

        else if (course8 != "-1" && drop13.Checked){
        if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course8), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course8));
                crdHrs -= 1;
                Label6.Visible = true;
                Label6.Text = "Course dropped successfully.";
            }
            else
            {
                Label6.Visible = true;
                Label6.Text = "You can not drop Course which you are not studying.";
                
            }
        }
        string course9 = DropDownList8.SelectedValue.ToString();
        if (course9 != "-1" && add14.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course9), curr_sems_id) == 1)
            {
                Label8.Visible = true;
                Label8.Text = "You have already added this course.";
                flag9 = true;
        
            }
            else
            {
                crdHrs += 1;
            }

        }
        else if (course9 != "-1" && drop14.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course9), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course9));
                crdHrs -= 1;
                Label8.Visible = true;
                Label8.Text = "Course dropped successfully.";
            }
            else
            {
                Label8.Visible = true;
                Label8.Text = "You can not drop Course which you are not studying.";
            }

        }
        string course10 = DropDownList9.SelectedValue.ToString();
        if (course10 != "-1" && add15.Checked )
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course10), curr_sems_id) == 1)
            {
                Label10.Visible = true;
                Label10.Text = "You have already added this course.";
                flag10 = true;
        
            }
            else
            {
                crdHrs += 1;
            }
        }
        else if (course10 != "-1" && drop15.Checked)
        {
            if (objBL.Course_Studies(int.Parse(Session["New"].ToString()), int.Parse(course10), curr_sems_id) == 1)
            {
                objBL.drop_Courses(int.Parse(Session["New"].ToString()), int.Parse(course10));
                crdHrs -= 1;
                Label10.Visible = true;
                Label10.Text = "Course dropped successfully.";
            }
            else
            {
                Label10.Visible = true;
                Label10.Text = "You can not drop Course which you are not studying.";
        
            }
        }

        if ((!add11.Checked && !drop11.Checked) && (!add12.Checked&&!drop12.Checked) && (!add13.Checked&&!drop13.Checked)
            && (!add14.Checked&&!drop14.Checked) && (!add15.Checked&&!drop15.Checked) &&
            (!add31.Checked&&!drop31.Checked) && (!add32.Checked&&!drop32.Checked) && (!add33.Checked&&!drop33.Checked)
            && (!add34.Checked&&!drop34.Checked) && (!add35.Checked&&!drop35.Checked))
        {
            status.Visible = true;
            status.Text = "You didnt add/drop any courses.";
        
        }
        else if (crdHrs > 17)
        {
            status.Visible = true;
            status.Text = "Maximum 17 credit hours is allowed to add courses.";
        }
        else if (crdHrs > 0 && crdHrs <= 17)
        {
            if (course1 != "-1" && add31.Checked)
            {
                if (!flag1)
                {
                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course1, curr_sems_id, curr_sems_no);
                    Label1.Visible = true;
                    Label1.Text = "Course registered successfully";
                }
            }
            if (course2 != "-1" && add32.Checked)
            {
                if (!flag2)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course2, curr_sems_id, curr_sems_no);
                    Label3.Visible = true;
                    Label3.Text = "Course registered successfully";
                }
            }
            if (course3 != "-1" && add33.Checked)
            {
                if (!flag3)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course3, curr_sems_id, curr_sems_no);
                    Label5.Visible = true;
                    Label5.Text = "Course registered successfully";
                }
            }
            if (course4 != "-1" && add34.Checked)
            {
                if (!flag4)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course4, curr_sems_id, curr_sems_no);
                    Label7.Visible = true;
                    Label7.Text = "Course registered successfully";
                }
            }
            if (course5 != "-1" && add35.Checked)
            {
                if (!flag5)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course5, curr_sems_id, curr_sems_no);
                    Label9.Visible = true;
                    Label9.Text = "Course registered successfully";
                }
            }
            if (course6 != "-1" && add11.Checked)
            {
                if (!flag6)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course6, curr_sems_id, curr_sems_no);
                    Label2.Visible = true;
                    Label2.Text = "Course registered successfully";
                }
            }
            if (course7 != "-1" && add12.Checked)
            {
                if (!flag7)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course7, curr_sems_id, curr_sems_no);
                    Label4.Visible = true;
                    Label4.Text = "Course registered successfully";
                }
            }
            if (course8 != "-1" && add13.Checked)
            {
                if (!flag8)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course8, curr_sems_id, curr_sems_no);
                    Label6.Visible = true;
                    Label6.Text = "Course registered successfully";
                }
            }
            if (course9 != "-1" && add14.Checked)
            {
                if (!flag9)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course9, curr_sems_id, curr_sems_no);
                    Label8.Visible = true;
                    Label8.Text = "Course registered successfully";
                }
            }
            if (course10 != "-1" && add15.Checked)
            {
                if (!flag10)
                {

                    objBL.add_Courses(int.Parse(Session["New"].ToString()), course10, curr_sems_id, curr_sems_no);
                    Label10.Visible = true;
                    Label10.Text = "Course registered successfully";
                }
            }
            
        }
        
    }
}