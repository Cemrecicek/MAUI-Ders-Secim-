using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using finaldeneme.Models;

namespace finaldeneme.DataTransactions
{
    public class DBTrans
    {
        public String dbPath;
        private SQLiteConnection conn;

        public DBTrans(String dbPath)
        {
            this.dbPath = dbPath;
        }

        public void Init()
        {
            if(conn == null)
            {
                conn=new SQLiteConnection(this.dbPath);

                conn.CreateTable<StudentClass>();
                conn.CreateTable<CourseClass>();
                conn.CreateTable<EnrollClass>();

            }
        }
        public List<StudentClass>GetAllStudentClasses() 
        {
            Init();
            return conn.Table<StudentClass>().ToList();
        }

        public void Add_St(StudentClass student)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }

        public void Delete_St(int Student_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new StudentClass { ID = Student_id });
        }



        public List<CourseClass> GetAllCourseClasses()
        {
            Init();
            return conn.Table<CourseClass>().ToList();
        }

        public void Add_Crs(CourseClass course)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(course);
        }

        public void Delete_Crs(int Course_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new CourseClass { CourseId = Course_id });
        }




        public List<EnrollClass> GetAllEnrollClasses()
        {
            Init();
            return conn.Table<EnrollClass>().ToList();
        }

        public void Add_En(EnrollClass enroll)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(enroll);
        }

        public void Delete_En(int Enroll_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new EnrollClass {EnrollID = Enroll_id });
        }


    }
}
