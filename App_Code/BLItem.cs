using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public class BLItem
{   
    
    public DALItem objDal = null;
    public BLItem()
    {
        objDal = new DALItem();
    }
    public void drop_Courses(int id,int course)
    {
        objDal.drop_Courses(id,course);
    }
    public int Course_Studies(int id,int course,int s_id)
    {
        return objDal.Course_Studies(id,course,s_id);

    }
    public DataTable get_courses_from_attendance(string userid)
    {
        return objDal.get_courses_from_attendance(userid);

    }
    public int updateStudent(string olduser, string fname, string lname, string password, int campus, string Mname, string _gid, string _gender, string _dob, string _temp_addr, string _p_addr, string _p_em, string _o_em, float _cgpa, string _c_no, string _cnic, string _bg, string _d_en, int _wc, string _status, string pathName)
    {
        int id = objDal.updateStudent(olduser, fname, lname, password, campus, Mname, _gid, _gender, _dob, _temp_addr, _p_addr, _p_em, _o_em, _cgpa, _c_no, _cnic, _bg, _d_en, _wc, _status, pathName);
        return id;
    }
    public int updateEmployee(string olduser, string fname, string lname, string password, int campus, string Mname, string _gid, string _gender, string _dob, string _temp_addr, string _p_addr, string _p_em, string _o_em, string _c_no, string _cnic, string _bg, string _d_en, string _status, string pathName)
    {
        int id = objDal.updateEmployee(olduser, fname, lname, password, campus, Mname, _gid, _gender, _dob, _temp_addr, _p_addr, _p_em, _o_em,  _c_no, _cnic, _bg, _d_en, _status, pathName);
        return id;
    }
    public int get_credit_hours(int id,int sems)
    {
        return objDal.get_credit_hours(id,sems);
    }
    public int get_current_semester_no(int id,int status)
    {
        return objDal.get_current_semester_of_student(id, status);

    }
    public void enter_teacher_courses(string teacherID, string courseID, string sectionID)
    {
        objDal.enter_teacher_courses(teacherID,courseID,sectionID);

    }
    public int insertIntoEmployee(string userid, string fname, string lname, string password, int campus, string Mname, string _gid, string _gender, string _dob, string _temp_addr, string _p_addr, string _p_em, string _o_em, string _c_no, string _cnic, int _deptid, string _bg, string _d_jn, string _status, string type, string pathName)
    {
        int id = objDal.insert_into_Employee(userid, fname, lname, password, campus, Mname, _gid, _gender, _dob, _temp_addr, _p_addr, _p_em, _o_em, _c_no, _cnic, _deptid, _bg, _d_jn, _status, type, pathName);
        return id;
    }
    public DataTable GetEmployee(string userid,int _flag)
    {
        try
        {
            DataTable dt = objDal.GetEmployee(userid); // get all items in a datatable
            List<Employee> lstItems = new List<Employee>(); // declare and initialize a list for items

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows) // parse each row of datatable
                {
                    Employee std = new Employee();

                    if (!row["Employee_ID"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.emp_id = Convert.ToInt32(row["Employee_ID"].ToString());
                    }
                    if (!row["First_Name"].ToString().Equals(DBNull.Value)) // check if ItemNo is not null
                    {
                        std.first_name = row["First_Name"].ToString();
                    }
                    if (!row["Last_Name"].ToString().Equals(DBNull.Value)) // check if ItemName is not null
                    {
                        std.last_name = row["Last_Name"].ToString();
                    }
                    if (!row["Guardian_ID"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.guardian_id = (row["Guardian_ID"].ToString());
                    }
                    if (!row["Gender"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.gender = row["Gender"].ToString();
                    }
                    if (!row["Middle_Name"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.middle_name = (row["Middle_Name"].ToString());
                    }
                    if (!row["campus_id"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.campus_id = (row["campus_id"].ToString());
                    }

                    if (!row["Date_of_Birth"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.dob = (row["Date_of_Birth"].ToString());
                    }
                    if (!row["Temporary_Address"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.Temp_address = (row["Temporary_Address"].ToString());
                    }
                    if (!row["Permanent_address"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.Permanent_address = (row["Permanent_address"].ToString());
                    }
                    if (!row["Contact_No"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.contact_no = (row["Contact_No"].ToString());
                    }
                    if (!row["CNIC"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.cnic = (row["CNIC"].ToString());
                    }
                    if (!row["Personal_Email"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.personnel_email = (row["Personal_Email"].ToString());
                    }
                    if (!row["Official_Email"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.official_email = (row["Official_Email"].ToString());
                    }

                    if (!row["dept_id"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.dept_id = (row["dept_id"].ToString());
                    }
                    if (!row["date_joined"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.date_joined = (row["date_joined"].ToString());
                    }
                    if (!row["password"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.password = (row["password"].ToString());
                    }
                    lstItems.Add(std); // add item to item list
                }
            }
            if (_flag == 1)
            {
                dt = TransposeDataTable(dt);
            }
                return dt;
        }
        catch (SqlException)
        {
            throw;
        }

    }

    public DataTable get_available_sections(string courseID){

      return  objDal.get_available_sections(courseID);
    }
    public DataTable get_available_courses(int id,int crdHrs)
    {
        return objDal.get_available_courses(id,crdHrs);
    }
    public string getNameofUser(string user_id, int type)
    {
        string str = objDal.getNameofUser(user_id, type);
        return str;
    }
    public int check_student_username(string User_ID){
        int temp=objDal.check_student_username_from_table(User_ID);
        return temp;
    }
    public void enter_Marks(string roll_no, string section_id, string q1, string q2, string q3,
        string a1, string a2, string a3, string m1, string m2, string fnl)
    {
        objDal.enter_Marks(roll_no, section_id, q1, q2, q3, a1, a2, a3, m1, m2, fnl);
    }

    public void Mark_Present(string roll_no,string courseid,string sectionid)
    {
         objDal.Mark_Present(roll_no,courseid,sectionid);

    }
    public void Mark_Absent(string roll_no, string courseid, string sectionid)
    {
        objDal.Mark_Absent(roll_no, courseid, sectionid);

    }
    public int check_student_campus(string User_ID ,string _campus)
    {
        int temp = objDal.check_student_campus_from_table(User_ID,_campus);
        return temp;
    }
    public void insert_image(string imgurl)
    {
        objDal.insert_image(imgurl);
    }
    public int check_student_password(string User_ID,string password)
    {
        int temp = objDal.check_student_password_from_table(User_ID,password);
        return temp;
    }
    public DataTable get_lectures_from_Attendance(string userid,string courseid,string sectionid)
    {

        return objDal.get_lectures_from_Attendance(userid,courseid,sectionid);
    }
    public int check_admin_username(string User_ID)
    {
        int temp = objDal.check_admin_username_from_table(User_ID);
        return temp;
    }
    public int check_admin_campus(string User_ID, string _campus)
    {
        int temp = objDal.check_admin_campus_from_table(User_ID, _campus);
        return temp;
    }
    public int check_admin_password(string User_ID, string password)
    {
        int temp = objDal.check_admin_password_from_table(User_ID, password);
        return temp;
    }
    public int check_Emp_username(string User_ID)
    {
        int temp = objDal.check_Emp_username_from_table(User_ID);
        return temp;
    }
    public int check_Emp_campus(string User_ID, string _campus)
    {
        int temp = objDal.check_Emp_campus_from_table(User_ID, _campus);
        return temp;
    }
    public int check_Emp_password(string User_ID, string password)
    {
        int temp = objDal.check_Emp_password_from_table(User_ID, password);
        return temp;
    }
    public string get_image_from_emp(string userid)
    {
        List<Student> lstItems = new List<Student>();
        DataTable dt = new DataTable();
        dt = objDal.get_image_from_emp(userid);
        string image = null;
        if (dt != null && dt.Rows.Count > 0)
        {
            foreach (DataRow row in dt.Rows) // parse each row of datatable
            {
                Employee std = new Employee();
                if (!row["photo"].ToString().Equals(DBNull.Value)) // check if ItemNo is not null
                {
                    std.photo = row["photo"].ToString();
                    image = row["photo"].ToString();
                }

            }
        }
        return image;
    }
    public string get_image(string userid)
    {
        List<Student> lstItems = new List<Student>();
        DataTable dt = new DataTable();
        dt=objDal.get_image_from_db(userid);
        string image=null;
        if (dt != null && dt.Rows.Count > 0)
        {
            foreach (DataRow row in dt.Rows) // parse each row of datatable
            {
                Student std = new Student();
                if (!row["photo"].ToString().Equals(DBNull.Value)) // check if ItemNo is not null
                {
                    std.photo = row["photo"].ToString();
                    image = row["photo"].ToString();
                }
                
            }
        }
        return image;
      }
    public int insertIntoStudent(string userid,string fname,string lname,string password,int campus,string Mname,string _gid,string _gender,string _dob,string _temp_addr,string _p_addr,string _p_em,string _o_em,float _cgpa,string _c_no,string _cnic,int _deptid,string _bg,string _d_en,int _wc,string _status,string section,string pathName)
    {
        int id = objDal.insert_into_Student(userid, fname, lname, password, campus, Mname, _gid, _gender, _dob, _temp_addr, _p_addr, _p_em, _o_em, _cgpa, _c_no, _cnic, _deptid, _bg, _d_en, _wc, _status,section,pathName);
        return id;
    }

    public static DataTable TransposeDataTable(DataTable dt)
    {
        DataTable table = new DataTable();
        //Get all the rows and change into columns
        for (int i = 0; i <= dt.Rows.Count; i++)
        {
            table.Columns.Add(Convert.ToString(i));
        }
        DataRow dr;
        //get all the columns and make it as rows
        for (int j = 0; j < dt.Columns.Count; j++)
        {
            dr = table.NewRow();
            dr[0] = dt.Columns[j].ToString();
            for (int k = 1; k <= dt.Rows.Count; k++)
                dr[k] = dt.Rows[k - 1][j];
            table.Rows.Add(dr);
        }

        return table;
  }
    public DataTable GetStudent(string userid, int flag)
    {
        try
        {
            DataTable dt = new DataTable();
            dt = objDal.GetStudent(userid); // get all items in a datatable
            List<Student> lstItems = new List<Student>(); // declare and initialize a list for items
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows) // parse each row of datatable
                {
                    Student std = new Student();

                    if (!row["First_Name"].ToString().Equals(DBNull.Value)) // check if ItemNo is not null
                    {
                        std.first_name = row["First_Name"].ToString();
                    }
                    if (!row["Last_Name"].ToString().Equals(DBNull.Value)) // check if ItemName is not null
                    {
                        std.last_name = row["Last_Name"].ToString();
                    }
                    if (!row["Guardian_ID"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.guardian_id = (row["Guardian_ID"].ToString());
                    }
                    if (!row["password"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.password = row["password"].ToString();
                    }
                    if (!row["campus_id"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.campus_id = Convert.ToInt32(row["campus_id"].ToString());
                    }
                    if (!row["Roll_Number"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.roll_no = Convert.ToInt32(row["Roll_Number"].ToString());
                    }
                    if (!row["Gender"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.gender = row["Gender"].ToString();
                    }
                    if (!row["Middle_Name"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.middle_name = (row["Middle_Name"].ToString());
                    }/*
                    if (!row["course1"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.course1 = (row["course1"].ToString());
                    }
                    if (!row["course2"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.course2 = (row["course2"].ToString());
                    }

                    if (!row["course3"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.course3 = (row["course3"].ToString());
                    }

                    if (!row["course4"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.course4 = (row["course4"].ToString());
                    }
                    if (!row["course5"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.course5 = (row["course5"].ToString());
                    }*/

                    if (!row["Date_of_Birth"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.dob = (row["Date_of_Birth"].ToString());
                    }
                    if (!row["Temporary_Address"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.Temp_address = (row["Temporary_Address"].ToString());
                    }
                    if (!row["Permanent_address"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.Permanent_address = (row["Permanent_address"].ToString());
                    }
                    if (!row["Contact_No"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.contact_no = (row["Contact_No"].ToString());
                    }
                    if (!row["CNIC"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.cnic = (row["CNIC"].ToString());
                    }
                    if (!row["Personal_Email"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.personnel_email = (row["Personal_Email"].ToString());
                    }
                    if (!row["Official_Email"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.official_email = (row["Official_Email"].ToString());
                    }

                    if (!row["dept_id"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.dept_id = (row["dept_id"].ToString());
                    }
                    if (!row["date_enrolled"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.date_enrolled = (row["date_enrolled"].ToString());
                    }

                    if (!row["CGPA"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.cgpa = (row["CGPA"].ToString());
                    }
                    if (!row["warning_count"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.warning_count = Convert.ToInt32(row["warning_count"].ToString());
                    }
                    if (!row["status"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        std.status = (row["status"].ToString());
                    }

                    lstItems.Add(std); // add item to item list
                }
            }
            if (flag != 1)
            {
                dt = TransposeDataTable(dt);
            }
            return dt;
        }
        catch (SqlException)
        {
            throw;
        }
    }
    public DataTable Get_Employee_Current_Courses(string userid)
    {
        try
        {
            DataTable dt = new DataTable();
            dt = objDal.Get_Employee_Current_Courses(userid); // get all items in a datatable
            List<Employee_Teaching> lstItems = new List<Employee_Teaching>(); // declare and initialize a list for items
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows) // parse each row of datatable
                {
                    Employee_Teaching emp_t = new Employee_Teaching();
                    if (!row["teacherID"].ToString().Equals(DBNull.Value)) // check if ItemNo is not null
                    {
                        emp_t.teacherID = row["teacherID"].ToString();
                    }
                    if (!row["CourseID"].ToString().Equals(DBNull.Value)) // check if ItemName is not null
                    {
                        emp_t.CourseID = row["CourseID"].ToString();
                    }
                    if (!row["sectionID"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        emp_t.sectionID = (row["sectionID"].ToString());
                    }
                    lstItems.Add(emp_t);
                }
             }
            return dt;
          
        }
        catch (SqlException)
        {
            throw;
        }
    }

    public DataTable Get_Marks_Of_Student(string userid)
    {
        return objDal.Get_Marks_Of_Student(userid);
    }

    public DataTable GetStudent_Personal(string userid)
    {
        try
        {
            DataTable dt = new DataTable();
            dt = objDal.GetStudent_Personal(userid); // get all items in a datatable
            List<Student> lstItems = new List<Student>(); // declare and initialize a list for items
            if (dt != null && dt.Rows.Count > 0)
            {
                    Student std = new Student();                    
                    lstItems.Add(std); // add item to item list
            }
            dt = TransposeDataTable(dt);
            return dt;
        }
        catch (SqlException)
        {
            throw;
        }
    }

    public DataTable GetStudent_University(string userid)
    {
        try
        {
            DataTable dt = new DataTable();
            dt = objDal.GetStudent_University(userid); // get all items in a datatable
            List<Student> lstItems = new List<Student>(); // declare and initialize a list for items
            if (dt != null && dt.Rows.Count > 0)
            {
                Student std = new Student();
                lstItems.Add(std); // add item to item list
            }
            dt = TransposeDataTable(dt);
            return dt;
        }
        catch (SqlException)
        {
            throw;
        }
    }

    public DataTable GetStudent_Contact(string userid)
    {
        try
        {
            DataTable dt = new DataTable();
            dt = objDal.GetStudent_Contact(userid); // get all items in a datatable
            List<Student> lstItems = new List<Student>(); // declare and initialize a list for items
            if (dt != null && dt.Rows.Count > 0)
            {
                Student std = new Student();
                lstItems.Add(std); // add item to item list
            }
            dt = TransposeDataTable(dt);
            return dt;
        }
        catch (SqlException)
        {
            throw;
        }
    }
    public DataTable GetAdmin(string userid)
    {
        try
        {
            DataTable dt = objDal.GetAdmin(userid); // get all items in a datatable
            List<Admin> lstItems = new List<Admin>(); // declare and initialize a list for items

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows) // parse each row of datatable
                {
                    Admin adm = new Admin();
                    if (!row["Employee_ID"].ToString().Equals(DBNull.Value)) // check if ItemNo is not null
                    {
                        adm.emp_id = Convert.ToInt32(row["Employee_ID"].ToString());
                        
                    }
                    if (!row["Type"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        adm.type = row["Type"].ToString();
                    }
                    
                    lstItems.Add(adm); // add item to item list
                }
            }
          dt = TransposeDataTable(dt);
            return dt;
        }
        catch (SqlException)
        {
            throw;
        }
    }
    public void add_Courses(int id,string c_id,int s_id,int s_no)
    {
        objDal.add_Courses_to_DB(id,c_id,s_id,s_no);

    }
    public DataTable getEnrolledStudents(string courseid,string sectionid,string teacherID){
       
            return objDal.getEnrolledStudents(courseid,sectionid,teacherID); // get all items in a datatable
            
     }
    public DataTable GetEmployee_Personal(string userid)
    {
        try
        {
            DataTable dt = objDal.GetEmployee_Personal(userid); // get all items in a datatable
            List<Employee> lstItems = new List<Employee>(); // declare and initialize a list for items

            if (dt != null && dt.Rows.Count > 0)
            {
                    Employee std = new Employee();
                    lstItems.Add(std); // add item to item list
            }
         dt = TransposeDataTable(dt);
            return dt;
        }
        catch (SqlException)
        {
            throw;
        }
        
    }

    public DataTable GetEmployee_University(string userid)
    {
        try
        {
            DataTable dt = objDal.GetEmployee_University(userid); // get all items in a datatable
            List<Employee> lstItems = new List<Employee>(); // declare and initialize a list for items

            if (dt != null && dt.Columns.Count > 0 && dt.Rows.Count > 0)
            {
                Employee std = new Employee();
                lstItems.Add(std); // add item to item list
            }
            dt = TransposeDataTable(dt);
            return dt;
        }
        catch (SqlException)
        {
            throw;
        }

    }

    public DataTable GetEmployee_Contact(string userid)
    {
        try
        {
            DataTable dt = objDal.GetEmployee_Contact(userid); // get all items in a datatable
            List<Employee> lstItems = new List<Employee>(); // declare and initialize a list for items

            if (dt != null && dt.Rows.Count > 0)
            {
                Employee std = new Employee();
                lstItems.Add(std); // add item to item list
            }
            dt = TransposeDataTable(dt);
            return dt;
        }
        catch (SqlException)
        {
            throw;
        }

    }

   /*/ public List<Student> SearchItem(string name, ref bool found)
    {
        try
        {
            DataTable dt = objDal.SearchItem(name, ref found); // get the item that is being searched
            List<Item> lstItems = new List<Item>(); // declare and initialize a list for items

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows) // parse each row of datatable
                {
                    Item item = new Item();

                    if (!row["ItemNo"].ToString().Equals(DBNull.Value)) // check if ItemNo is not null
                    {
                        item.ItemNumber = Convert.ToInt32(row["ItemNo"].ToString());
                    }
                    if (!row["ItemName"].ToString().Equals(DBNull.Value)) // check if ItemName is not null
                    {
                        item.ItemName = row["ItemName"].ToString();
                    }
                    if (!row["TotalUnits"].ToString().Equals(DBNull.Value)) // check if TotalUnits is not null
                    {
                        item.TotalUnit = Convert.ToInt32(row["TotalUnits"].ToString());
                    }

                    lstItems.Add(item); // add item to item list
                }
            }
            return lstItems;
        }
        catch (Exception)
        {
            throw;
        }
    }/*/
}