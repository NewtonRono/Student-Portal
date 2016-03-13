using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public class DALItem
{
    private static string connString =
    System.Configuration.ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString);
        
    public DALItem()
    {
        
    }
   
    public int Course_Studies(int id,int course,int s_id)
    {
        SqlCommand cmd = new SqlCommand("CourseStudies", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = id;
        cmd.Parameters.Add("@courseID", SqlDbType.Int).Value = course;
        cmd.Parameters.Add("@semsID", SqlDbType.Int).Value = s_id;
        cmd.Parameters.Add("@retval", SqlDbType.Int).Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        return int.Parse(cmd.Parameters["@retval"].Value.ToString());
    }
    public void drop_Courses(int id,int course)
    {
        SqlCommand cmd = new SqlCommand("DropCourse", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = id;
        cmd.Parameters.Add("@courseID", SqlDbType.Int).Value = course;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public int get_credit_hours(int id, int sems)
    {
        SqlCommand cmd = new SqlCommand("getCrdHrs", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@student",SqlDbType.Int).Value=id;
        cmd.Parameters.Add("@semester",SqlDbType.Int).Value=sems;
        cmd.Parameters.Add("@crdHrs", SqlDbType.Int).Direction =ParameterDirection.Output ;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        return int.Parse(cmd.Parameters["@crdHrs"].Value.ToString());
    }

    public void enter_Marks(string roll_no, string section_id, string q1, string q2, string q3,
        string a1, string a2, string a3, string m1, string m2, string fnl)
    {
            float number;
            SqlCommand cmd = new SqlCommand("enter_Marks", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = int.Parse(roll_no);
            cmd.Parameters.Add("@sectionID", SqlDbType.Int).Value = int.Parse(section_id);
            cmd.Parameters.Add("@quiz1", SqlDbType.Float).Value = float.TryParse(q1, out number); ;
            cmd.Parameters.Add("@quiz2", SqlDbType.Float).Value = float.TryParse(q2, out number);
            cmd.Parameters.Add("@quiz3", SqlDbType.Float).Value = float.TryParse(q3, out number);
            cmd.Parameters.Add("@assignment1", SqlDbType.Float).Value = float.TryParse(a1, out number);
            cmd.Parameters.Add("@assignment2", SqlDbType.Float).Value = float.TryParse(a2, out number);
            cmd.Parameters.Add("@assignment3", SqlDbType.Float).Value = float.TryParse(a3, out number);
            cmd.Parameters.Add("@mid1", SqlDbType.Float).Value = float.TryParse(m1, out number);
            cmd.Parameters.Add("@mid2", SqlDbType.Float).Value = float.TryParse(m2, out number);
            cmd.Parameters.Add("@final", SqlDbType.Float).Value = float.TryParse(fnl, out number);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
    }

    public void Mark_Present(string roll_no,string courseid,string sectionid)
    {
        try
        {

            SqlCommand cmd = new SqlCommand("Mark_Present", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = int.Parse(roll_no);
            cmd.Parameters.Add("@courseid", SqlDbType.Int).Value = int.Parse(courseid);
            cmd.Parameters.Add("@sectionid", SqlDbType.Int).Value = int.Parse(sectionid);
            conn.Open();
            cmd.ExecuteNonQuery();

        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }

    }
    public void Mark_Absent(string roll_no, string courseid, string sectionid)
    {
        try
        {

            SqlCommand cmd = new SqlCommand("Mark_Absent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = int.Parse(roll_no);
            cmd.Parameters.Add("@courseid", SqlDbType.Int).Value = int.Parse(courseid);
            cmd.Parameters.Add("@sectionid", SqlDbType.Int).Value = int.Parse(sectionid);
            conn.Open();
            cmd.ExecuteNonQuery();

        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }

    }
    public int get_current_semester_of_student(int id,int status)
    {
        SqlCommand cmd = new SqlCommand("StudentStudies", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = id;
        cmd.Parameters.Add("@semesterID", SqlDbType.Int).Direction = ParameterDirection.Output;
        cmd.Parameters.Add("@semesterNO", SqlDbType.Int).Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        if (status == 0)
        {
            return int.Parse(cmd.Parameters["@semesterNO"].Value.ToString());
        }
        else
        {
            return int.Parse(cmd.Parameters["@semesterID"].Value.ToString());
       
        }
    }
    public DataTable getEnrolledStudents(string courseid,string sectionid,string teacherID)
    {
        DataTable dt = new DataTable();
           
        try
        {
            SqlCommand cmd = new SqlCommand("studentsOfTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@courseID", SqlDbType.Int).Value = int.Parse(courseid);
            cmd.Parameters.Add("@sectionID", SqlDbType.Int).Value = int.Parse(sectionid);
            cmd.Parameters.Add("@teacherID", SqlDbType.Int).Value = int.Parse(teacherID);
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            conn.Close(); // close the sql connection
        }

        return dt;

    }
    public void enter_teacher_courses(string teacherID,string courseID,string sectionID)
    {
        SqlCommand cmd;
        cmd = new SqlCommand("Teaches_Update", conn);
       cmd.CommandType = CommandType.StoredProcedure;
       try
       {
           cmd.Parameters.Add("@teacherID", SqlDbType.Int).Value = int.Parse(teacherID);
           cmd.Parameters.Add("@sectionID", SqlDbType.Int).Value = int.Parse(sectionID);
           cmd.Parameters.Add("@courseID", SqlDbType.Int).Value = int.Parse(courseID);
       
             conn.Open();
            cmd.ExecuteNonQuery();
        
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex);
        }
         finally
        {
            conn.Close();
        }

       
    }
    public DataTable get_available_sections(string courseID)
    {
        SqlCommand cmd;
        cmd = new SqlCommand("select SectionID from Section where courseID='" + courseID + "'", conn);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;

    }

    public DataTable get_available_courses(int id,int crdHrs)
    {
        //int semsno=get_current_semester_of_student(id,0);
        SqlCommand cmd = new SqlCommand("Select distinct(courseName),Courses_Available.courseID from Courses_Available,Courses where Courses_Available.courseID=Courses.courseID and Courses.crdtHrs= '" + crdHrs + "' ", conn);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    public void add_Courses_to_DB(int id,string c_id,int s_id,int s_no)
    {
        SqlCommand cmd;
        cmd = new SqlCommand("NewCourseChosen", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        try
        {
            cmd.Parameters.Add("@studentID", SqlDbType.Int);
            cmd.Parameters.Add("@courseID", SqlDbType.Int);
            cmd.Parameters.Add("@semesterID", SqlDbType.Int);
            cmd.Parameters.Add("@semesterNo", SqlDbType.Int);

            cmd.Parameters["@studentID"].Value = id;
            cmd.Parameters["@courseID"].Value = int.Parse(c_id);
            cmd.Parameters["@semesterID"].Value = s_id;
            cmd.Parameters["@semesterNo"].Value = s_no;
            conn.Open();
            cmd.ExecuteNonQuery();
        
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex);
        }
         finally
        {
            conn.Close();
        }

        
    }
    public void insert_image(string imgurl)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into student(photo) values(@photo)", conn);
        cmd.Parameters.AddWithValue("@photo", imgurl);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public string getNameofUser(string user_id, int type)
    {
        conn.Open();
        string str;
        if (type == 0)  // admin
            str = "select first_name from admin where emp_id = '" + user_id + "'";
        else if (type == 1)  // student
            str = "select first_name from Student where roll_no = '" + user_id + "'";
        else  // employee
            str = "select first_name from Employee where emp_id = '" + user_id + "'";
        SqlCommand com = new SqlCommand(str, conn);
        com.CommandType = CommandType.Text;
        string temp = (string)com.ExecuteScalar();
        conn.Close();
        return temp;
    }

    public int insert_into_Student(string userid, string fname, string lname, string password, int campus, string Mname,string _gid,string _gender,string _dob,string _temp_addr,string _p_addr,string _p_em,string _o_em,float _cgpa,string _c_no,string _cnic,int _deptid,string _bg,string _d_en,int _wc,string _status,string Section,string pathName)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlCommand cmd4;
        SqlCommand cmd5;
        SqlCommand cmd6;

        int ret = 0;
        
        try
        {
            int username = Convert.ToInt32(userid);
            cmd = new SqlCommand("newStudentEntry", conn);
            cmd6 = new SqlCommand("get_curr_sems", conn);
            cmd6.CommandType = CommandType.StoredProcedure;
            cmd6.Parameters.Add("@sems", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd6.ExecuteNonQuery();
            int sems= int.Parse(cmd6.Parameters["@sems"].Value.ToString());

            cmd1 = new SqlCommand("insert into studies(studentID,courseID,sectionID,semesterID,semesterNo) values(@studentID,@courseId,@sectionID,@semesterID,@semesterNo)", conn);
            cmd2 = new SqlCommand("insert into studies(studentID,courseID,sectionID,semesterID,semesterNo) values(@studentID,@courseId,@sectionID,@semesterID,@semesterNo)", conn);
            cmd3 = new SqlCommand("insert into studies(studentID,courseID,sectionID,semesterID,semesterNo) values(@studentID,@courseId,@sectionID,@semesterID,@semesterNo)", conn);
            cmd4 = new SqlCommand("insert into studies(studentID,courseID,sectionID,semesterID,semesterNo) values(@studentID,@courseId,@sectionID,@semesterID,@semesterNo)", conn);
            cmd5 = new SqlCommand("insert into studies (studentID,courseID,sectionID,semesterID,semesterNo)values(@studentID,@courseId,@sectionID,@semesterID,@semesterNo)", conn);
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;
            cmd3.CommandType = CommandType.Text;
            cmd4.CommandType = CommandType.Text;
            cmd5.CommandType = CommandType.Text;
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@r_no", SqlDbType.Int);
            cmd.Parameters.Add("@guardID", SqlDbType.VarChar,50);
            cmd.Parameters.Add("@fName", SqlDbType.VarChar,50);
            cmd.Parameters.Add("@mName", SqlDbType.VarChar,50);
            cmd.Parameters.Add("@lName", SqlDbType.VarChar,50);
            cmd.Parameters.Add("@gender", SqlDbType.VarChar,50);
            cmd.Parameters.Add("@dob", SqlDbType.Date);
            cmd.Parameters.Add("@tAddress", SqlDbType.VarChar,100);
            cmd.Parameters.Add("@pAddress", SqlDbType.VarChar,100);
            cmd.Parameters.Add("@contactNo", SqlDbType.VarChar,12);
            cmd.Parameters.Add("@cnic", SqlDbType.VarChar,13);
            cmd.Parameters.Add("@PEmail", SqlDbType.VarChar,100);
            cmd.Parameters.Add("@OEmail", SqlDbType.VarChar,100);
            cmd.Parameters.Add("@deptid", SqlDbType.Int);
            cmd.Parameters.Add("@dateEnroll", SqlDbType.Date);
            cmd.Parameters.Add("@bloodGrp", SqlDbType.VarChar,3);
            cmd.Parameters.Add("@campusid", SqlDbType.Int);
            cmd.Parameters.Add("@cgpa", SqlDbType.Float);
            cmd.Parameters.Add("@wrngCount", SqlDbType.VarChar);
            cmd.Parameters.Add("@status", SqlDbType.VarChar,20);
            cmd.Parameters.Add("@password", SqlDbType.VarChar,60);
            cmd.Parameters.Add("@picture", SqlDbType.VarChar);

            cmd.Parameters["@r_no"].Value = username;
            cmd.Parameters["@guardID"].Value = _gid;
            cmd.Parameters["@fName"].Value = fname;
            cmd.Parameters["@mName"].Value = Mname;
            cmd.Parameters["@lName"].Value = lname;
            cmd.Parameters["@gender"].Value = _gender;
            cmd.Parameters["@dob"].Value = _dob;
            cmd.Parameters["@tAddress"].Value = _temp_addr;
            cmd.Parameters["@pAddress"].Value = _p_addr;
            cmd.Parameters["@contactNo"].Value = _c_no;
            cmd.Parameters["@cnic"].Value = _cnic;
            cmd.Parameters["@PEmail"].Value = _p_em;
            cmd.Parameters["@OEmail"].Value = _o_em;
            cmd.Parameters["@deptid"].Value = _deptid;
            cmd.Parameters["@dateEnroll"].Value = _d_en;
            cmd.Parameters["@bloodGrp"].Value = _bg;
            cmd.Parameters["@campusid"].Value = campus;
            cmd.Parameters["@cgpa"].Value = _cgpa;
            cmd.Parameters["@wrngCount"].Value = _wc;
            cmd.Parameters["@status"].Value = _status;
            cmd.Parameters["@password"].Value = password;
            cmd.Parameters["@picture"].Value = pathName;
            
            cmd.ExecuteNonQuery();
            cmd1.Parameters.Add("@studentID", SqlDbType.Int).Value = username;
            cmd1.Parameters.Add("@semesterNo", SqlDbType.Int).Value = 1;
            cmd1.Parameters.Add("@semesterID", SqlDbType.Int).Value = sems;
            cmd1.Parameters.Add("@courseId", SqlDbType.Int).Value = 102;
            cmd1.Parameters.Add("@sectionID", SqlDbType.Int).Value = Section;

            cmd2.Parameters.Add("@studentID", SqlDbType.Int).Value = username;
            cmd2.Parameters.Add("@semesterNo", SqlDbType.Int).Value = 1;
            cmd2.Parameters.Add("@semesterID", SqlDbType.Int).Value = sems;
            cmd2.Parameters.Add("@courseId", SqlDbType.Int).Value = 103;
            cmd2.Parameters.Add("@sectionID", SqlDbType.Int).Value = Section;

            cmd3.Parameters.Add("@studentID", SqlDbType.Int).Value = username;
            cmd3.Parameters.Add("@semesterNo", SqlDbType.Int).Value = 1;
            cmd3.Parameters.Add("@semesterID", SqlDbType.Int).Value = sems;
            cmd3.Parameters.Add("@courseId", SqlDbType.Int).Value = 105;
            cmd3.Parameters.Add("@sectionID", SqlDbType.Int).Value = Section;

            cmd4.Parameters.Add("@studentID", SqlDbType.Int).Value = username;
            cmd4.Parameters.Add("@semesterNo", SqlDbType.Int).Value = 1;
            cmd4.Parameters.Add("@semesterID", SqlDbType.Int).Value = sems;
            cmd4.Parameters.Add("@courseId", SqlDbType.Int).Value = 106;
            cmd4.Parameters.Add("@sectionID", SqlDbType.Int).Value = Section;

            cmd5.Parameters.Add("@studentID", SqlDbType.Int).Value = username;
            cmd5.Parameters.Add("@semesterNo", SqlDbType.Int).Value = 1;
            cmd5.Parameters.Add("@semesterID", SqlDbType.Int).Value = sems;
            cmd5.Parameters.Add("@courseId", SqlDbType.Int).Value = 201;
            cmd5.Parameters.Add("@sectionID", SqlDbType.Int).Value = Section;
           
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
          
            ret = 1;
        }

        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex);
        }

        finally
        {
            conn.Close();
        }

        return ret;
    }


    public int check_student_username_from_table(string User_ID)
    {
        conn.Open();
        string checkuser = "Select COUNT(*) from Student where roll_no='" + User_ID + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        return temp;
    }
    public int check_student_campus_from_table(string User_ID, string _campus)
    {
        conn.Open();
        string getCampus = "select Campus.campus_name from student join Campus on student.campus_id=Campus.campus_id where roll_no='" + User_ID + "'";
        SqlCommand CampusCom = new SqlCommand(getCampus, conn);
        string temp = CampusCom.ExecuteScalar().ToString();
        if (temp == _campus)
        {
            conn.Close();
            return 0;
        }
        else
        {
            conn.Close();
            return 1;
        }
    }
    public int check_student_password_from_table(string User_ID, string password)
    {
        conn.Open();
        string getPassword = "Select password from Student where roll_no='" + User_ID + "'";
        SqlCommand passCom = new SqlCommand(getPassword, conn);
        string temp = passCom.ExecuteScalar().ToString().Replace(" ", "");
        if (temp == password)
        {
            conn.Close();
            return 0;
        }
        else
        {
            conn.Close();
            return 1;
        }
    }
    public int check_admin_username_from_table(string User_ID)
    {
        conn.Open();
        string checkuser = "Select COUNT(*) from admin where emp_id='" + User_ID + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        return temp;
    }
    public int check_admin_campus_from_table(string User_ID, string _campus)
    {
        conn.Open();
        string getCampus = "select campus_name from admin, Employee join Campus on Employee.campus_id=Campus.campus_id where Employee.emp_id='" + User_ID + "'";
        SqlCommand CampusCom = new SqlCommand(getCampus, conn);
        string temp = CampusCom.ExecuteScalar().ToString();
        if (temp == _campus)
        {
            conn.Close();
            return 0;
        }
        else
        {
            conn.Close();
            return 1;
        }
    }
    public int check_admin_password_from_table(string User_ID, string password)
    {
        conn.Open();
        string getPassword = "Select password from Admin,Employee where Employee.emp_id='" + User_ID + "'";
        SqlCommand passCom = new SqlCommand(getPassword, conn);
        string temp = passCom.ExecuteScalar().ToString().Replace(" ", "");
        if (temp == password)
        {
            conn.Close();
            return 0;
        }
        else
        {
            conn.Close();
            return 1;
        }
    }
    public int check_Emp_username_from_table(string User_ID)
    {
        conn.Open();
        string checkuser = "Select COUNT(*) from Employee where emp_id='" + User_ID + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        return temp;
    }
    public int check_Emp_campus_from_table(string User_ID, string _campus)
    {
       // conn.Open();
        string getCampus = "select Campus.campus_name from Employee join Campus on Employee.campus_id=Campus.campus_id where emp_id='" + User_ID + "'";
        SqlCommand CampusCom = new SqlCommand(getCampus, conn);
        string temp = CampusCom.ExecuteScalar().ToString();
        if (temp == _campus)
        {
            conn.Close();
            return 0;
        }
        else
        {
            conn.Close();
            return 1;
        }
    }
    public int check_Emp_password_from_table(string User_ID, string password)
    {
        conn.Open();
        string getPassword = "Select password from Employee where emp_id='" + User_ID + "'";
        SqlCommand passCom = new SqlCommand(getPassword, conn);
        string temp = passCom.ExecuteScalar().ToString().Replace(" ", "");
        if (temp == password)
        {
            conn.Close();
            return 0;
        }
        else
        {
            conn.Close();
            return 1;
        }
    }
    public DataTable get_image_from_emp(string userid)
    {
        //conn.Open();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        cmd = new SqlCommand("Select photo from Employee where emp_id='" + userid + "'", conn);  //instantiate SQL command
        cmd.CommandType = CommandType.Text;
        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        {
            da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
        }
        conn.Close();
        return dt;
    }
    public DataTable get_image_from_db(string userid)
    {
        //conn.Open();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        cmd = new SqlCommand("Select photo from Student where roll_no ='" + userid + "'", conn);  //instantiate SQL command
        cmd.CommandType = CommandType.Text;
        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        return dt;
        
    }
    public int updateStudent(string olduser, string fname, string lname, string password, int campus, string Mname, string _gid, string _gender, string _dob, string _temp_addr, string _p_addr, string _p_em, string _o_em, float _cgpa, string _c_no, string _cnic, string _bg, string _d_en, int _wc, string _status, string pathName)
    {
        conn.Open();
        SqlCommand cmd;
        int ret = 0;

        try
        {
            cmd = new SqlCommand("update_Student", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@olduserID", SqlDbType.Int).Value = int.Parse(olduser);
            cmd.Parameters.Add("@guardianID", SqlDbType.VarChar, 50).Value = _gid;
            cmd.Parameters.Add("@fName", SqlDbType.VarChar, 50).Value = fname;
            cmd.Parameters.Add("@mName", SqlDbType.VarChar, 50).Value = lname;
            cmd.Parameters.Add("@lName", SqlDbType.VarChar, 50).Value = Mname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 50).Value = _gender;
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = _dob;
            cmd.Parameters.Add("@tAddress", SqlDbType.VarChar, 100).Value = _temp_addr;
            cmd.Parameters.Add("@pAddress", SqlDbType.VarChar, 100).Value = _p_addr;
            cmd.Parameters.Add("@contactNo", SqlDbType.VarChar, 12).Value = _c_no;
            cmd.Parameters.Add("@cnic", SqlDbType.VarChar, 13).Value = _cnic;
            cmd.Parameters.Add("@PEmail", SqlDbType.VarChar, 100).Value = _p_em;
            cmd.Parameters.Add("@OEmail", SqlDbType.VarChar, 100).Value = _o_em;
            cmd.Parameters.Add("@dateJoin", SqlDbType.Date).Value = _d_en;
            cmd.Parameters.Add("@bGroup", SqlDbType.VarChar, 3).Value = _bg;
            cmd.Parameters.Add("@campid", SqlDbType.Int).Value = campus;
            cmd.Parameters.Add("@cgpa", SqlDbType.Float).Value = _cgpa;
            cmd.Parameters.Add("@wc", SqlDbType.VarChar).Value = _wc;
            cmd.Parameters.Add("@status", SqlDbType.VarChar, 20).Value = _status;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 60).Value = password;
            cmd.Parameters.Add("@pic", SqlDbType.VarChar, 100).Value = pathName;
            cmd.ExecuteNonQuery();

            ret = 1;
        }

        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex);
        }

        finally
        {
            conn.Close();
        }

        return ret;
    }
    public int updateEmployee(string olduser, string fname, string lname, string password, int campus, string Mname, string _gid, string _gender, string _dob, string _temp_addr, string _p_addr, string _p_em, string _o_em, string _c_no, string _cnic, string _bg, string _d_en, string _status, string pathName)
    {
        conn.Open();
        SqlCommand cmd;
        int ret = 0;

        try
        {
            cmd = new SqlCommand("update_Employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@olduserID", SqlDbType.Int).Value = int.Parse(olduser);
            cmd.Parameters.Add("@guardianID", SqlDbType.VarChar, 50).Value = _gid;
            cmd.Parameters.Add("@fName", SqlDbType.VarChar, 50).Value = fname;
            cmd.Parameters.Add("@mName", SqlDbType.VarChar, 50).Value = lname;
            cmd.Parameters.Add("@lName", SqlDbType.VarChar, 50).Value = Mname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 50).Value = _gender;
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = _dob;
            cmd.Parameters.Add("@tAddress", SqlDbType.VarChar, 100).Value = _temp_addr;
            cmd.Parameters.Add("@pAddress", SqlDbType.VarChar, 100).Value = _p_addr;
            cmd.Parameters.Add("@contactNo", SqlDbType.VarChar, 12).Value = _c_no;
            cmd.Parameters.Add("@cnic", SqlDbType.VarChar, 13).Value = _cnic;
            cmd.Parameters.Add("@PEmail", SqlDbType.VarChar, 100).Value = _p_em;
            cmd.Parameters.Add("@OEmail", SqlDbType.VarChar, 100).Value = _o_em;
            cmd.Parameters.Add("@dateJoin", SqlDbType.Date).Value = _d_en;
            cmd.Parameters.Add("@bGroup", SqlDbType.VarChar, 3).Value = _bg;
            cmd.Parameters.Add("@campid", SqlDbType.Int).Value = campus;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 60).Value = password;
            cmd.Parameters.Add("@pic", SqlDbType.VarChar, 100).Value = pathName;
            cmd.ExecuteNonQuery();

            ret = 1;
        }

        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex);
        }

        finally
        {
            conn.Close();
        }

        return ret;
    }
     public DataTable GetStudent(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection

            cmd = new SqlCommand("Select roll_no as Roll_Number,guardian_id as Guardian_ID,first_name as First_Name,last_name as Last_Name,middle_name as Middle_Name,gender as Gender,dob as Date_of_Birth,Temp_address as Temporary_Address,Permanent_address,contact_no as Contact_No,cnic as CNIC,personnel_email as Personal_Email,official_email as Official_Email,s.dept_id,date_enrolled,blood_group,s.campus_id,cgpa as CGPA,warning_count,password,photo,name as Department,campus_name,status from Student s,Department d,Campus c where s.roll_no='" + userid + "' and d.dept_id=s.dept_id and c.campus_id=s.campus_id", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }
    
    public DataTable GetStudent_Personal(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection

            cmd = new SqlCommand("select * from Student_Profile_Personal where Roll_No = '"+userid+"'", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }

    public DataTable GetStudent_University(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection

            cmd = new SqlCommand("select * from Student_Profile_University where Roll_No = '"+userid+"'", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable

            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }

    public DataTable GetStudent_Contact(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection

            cmd = new SqlCommand("select * from Student_Profile_Contact where Roll_No = '"+userid+"'", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable

            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }
    public DataTable GetAdmin(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection

            cmd = new SqlCommand("Select s.emp_id as Employee_ID, admin.type as Type,guardian_id as Guardian_ID,first_name as First_Name,last_name as Last_Name,middle_name as Middle_Name,gender as Gender,dob as Date_of_Birth,Temp_address as Temporary_Address,Permanent_address,contact_no as Contact_No,cnic as CNIC,personnel_email as Personal_Email,official_email as Official_Email,s.dept_id,date_joined,blood_group,s.campus_id,password,photo,name as Department,campus_name from admin,Employee s,Department d,Campus c where s.emp_id='"+userid+"' and d.dept_id=s.dept_id and c.campus_id=s.campus_id", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }
    public DataTable Get_Marks_Of_Student(string userid)
    {
        int _user = int.Parse(userid);
        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlCommand cmd;
        try
        {
            conn.Open(); // open sql Connection
            cmd = new SqlCommand("Select * from Student_Marks_Display where roll_no='" + _user + "'", conn);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            conn.Close(); // close the sql connection
        }

        return dt; //return the dataset

    }
    
    public DataTable get_lectures_from_Attendance(string userid,string courseid,string sectionid)
    {
        DataTable dt = new DataTable(); //declare and instantiate new datatable
        try
        {
            int user = int.Parse(userid);
            SqlCommand cmd;
            cmd = new SqlCommand("get_lectures_from_Attendance", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = user;
            cmd.Parameters.Add("@section", SqlDbType.Int).Value = sectionid;
            cmd.Parameters.Add("@courseID", SqlDbType.Int).Value = courseid;
            
            conn.Open(); // open sql Connection

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }

        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            conn.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }
    public DataTable get_courses_from_attendance(string userid)
    {
        DataTable dt = new DataTable(); //declare and instantiate new datatable
        try
        {
            int user = int.Parse(userid);
            SqlCommand cmd;
            cmd = new SqlCommand("get_courses_from_attendance", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = user;
            conn.Open(); // open sql Connection

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            conn.Close(); // close the sql connection
        }

        return dt; //return the dataset

            
    }
    public DataTable Get_Employee_Current_Courses(string userid)
    {
        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlCommand cmd;
         try
        {
            conn.Open(); // open sql Connection

            cmd = new SqlCommand("select distinct(courseName),section.sectionID,teacherID,Courses.courseID from Teacher_Teaches,Section,Courses where section.sectionID= Teacher_Teaches.sectionID and Courses.courseID=Teacher_Teaches.CourseID and teacherID='"+userid+"'", conn);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        }
         catch (SqlException)
         {
             throw;
         }
         finally
         {
             conn.Close(); // close the sql connection
         }

         return dt; //return the dataset


    }
    public DataTable GetEmployee_Personal(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection
            int userid1 = int.Parse(userid);
            cmd = new SqlCommand("select * from Employee_Profile_Personal where Employee_ID = '"+userid1+"'", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }
    public int insert_into_Employee(string userid, string fname, string lname, string password, int campus, string Mname, string _gid, string _gender, string _dob, string _temp_addr, string _p_addr, string _p_em, string _o_em, string _c_no, string _cnic, int _deptid, string _bg, string _d_jn, string _status, string type, string pathName)
    {
        SqlCommand cmd;
        cmd = new SqlCommand("Add_Employee", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        int ret = 0;
        try
        {
            int username = Convert.ToInt32(userid);
            cmd.Parameters.Add("@teacherID ", SqlDbType.Int).Value = username;
            cmd.Parameters.Add("@guardianID", SqlDbType.VarChar, 50).Value = _gid;
            cmd.Parameters.Add("@fName", SqlDbType.VarChar, 50).Value = fname;
            cmd.Parameters.Add("@mName", SqlDbType.VarChar, 50).Value = Mname;
            cmd.Parameters.Add("@lName ", SqlDbType.VarChar, 50).Value = lname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 50).Value = _gender;
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = _dob;
            cmd.Parameters.Add("@tAddress", SqlDbType.VarChar, 100).Value = _temp_addr;
            cmd.Parameters.Add("@pAddress ", SqlDbType.VarChar, 100).Value = _p_addr;
            cmd.Parameters.Add("@contactNo ", SqlDbType.VarChar, 12).Value = _c_no;
            cmd.Parameters.Add("@cnic", SqlDbType.VarChar, 13).Value = _cnic;
            cmd.Parameters.Add("@pEmail", SqlDbType.VarChar, 50).Value = _p_em;
            cmd.Parameters.Add("@oEmail ", SqlDbType.VarChar, 50).Value = _o_em;
            cmd.Parameters.Add("@deptID ", SqlDbType.Int).Value = _deptid;
            cmd.Parameters.Add("@dateJoin", SqlDbType.Date).Value = _d_jn;
            cmd.Parameters.Add("@bGroup", SqlDbType.VarChar, 3).Value = _bg;
            cmd.Parameters.Add("@campID ", SqlDbType.Int).Value = campus;
            cmd.Parameters.Add("@password ", SqlDbType.VarChar, 60).Value = password;
            cmd.Parameters.Add("@pic", SqlDbType.VarChar, 100).Value = pathName;
            cmd.Parameters.Add("@type ", SqlDbType.Int).Value = type;
            //conn.Open();
            cmd.ExecuteNonQuery();
            ret = 1;
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex);
        }
        finally
        {
            conn.Close();
        }
        return ret;

    }
    public DataTable GetEmployee(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection

            cmd = new SqlCommand("select emp_id as Employee_ID,guardian_id as Guardian_ID,first_name as First_Name,last_name as Last_Name,middle_name as Middle_Name,gender as Gender,dob as Date_of_Birth,Temp_address as Temporary_Address,Permanent_address,contact_no as Contact_No,cnic as CNIC,personnel_email as Personal_Email,official_email as Official_Email,s.dept_id,date_joined,blood_group,s.campus_id,password,photo,name as Department,campus_name from Employee s,Department d,Campus c where s.emp_id='" + userid + "' and d.dept_id=s.dept_id and c.campus_id=s.campus_id", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }
  
    
    public DataTable GetEmployee_University(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection
            int userid1 = int.Parse(userid);
            cmd = new SqlCommand("select * from Employee_Profile_University where Employee_ID = '"+userid1+"'", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }

    public DataTable GetEmployee_Contact(string userid) //to get the values of all the items from table Items and return the Dataset
    {

        DataTable dt = new DataTable(); //declare and instantiate new datatable
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString); //declare and instantiate new SQL connection
        SqlCommand cmd;

        try
        {
            con.Open(); // open sql Connection
            int userid1 = int.Parse(userid);

            cmd = new SqlCommand("select * from Employee_Profile_Contact where Employee_ID = '"+userid+"'", con);  //instantiate SQL command 
            cmd.CommandType = CommandType.Text; //set type of sqL Command

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt); //Add the result  set  returned from SQLCommand to datatable
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close(); // close the sql connection
        }

        return dt; //return the dataset
    }
  
    public DataTable SearchItem(string name, ref bool found)
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(connString);
        SqlCommand cmd;

        try
        {
            con.Open();

            cmd = new SqlCommand("searchitem ", con); //name of stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ItemName", SqlDbType.VarChar, 15);
            cmd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            // set parameter values
            cmd.Parameters["@ItemName"].Value = name;


            cmd.ExecuteNonQuery();

            // read output value 
            found = Convert.ToBoolean(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

            if (found)
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);

                }
            }
        }
        catch (SqlException)
        {
            throw;
        }
        finally
        {
            con.Close();
        }

        return dt;

    }

}