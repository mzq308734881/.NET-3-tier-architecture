using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using MyDbHelper;

namespace DAL
{
     public  class StudentDAO
    {
        public List<Student> GetStudents()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "select * from Student";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<Student> students = new List<Student>();
            while(reader.Read())
            {
                string no = reader["Sno"].ToString().Trim();
                string name = reader["Sname"].ToString().Trim();
                string sex = reader["Ssex"].ToString().Trim();
                int age = Convert.ToInt32(reader["Sage"]);
                string dept = reader["Sdept"].ToString().Trim();

                students.Add(new Student(no,name,sex,age,dept));
            }
            reader.Close();
            return students;
        }

        public void Insert(Student s)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql =string.Format( "insert into Student values('{0}', '{1}', '{2}', {3}, '{4}')",s.Sno, s.Sname, s.Ssex, s.Sage, s.Sdept);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Update(Student s)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("Update Student set Sname='{1}',Ssex='{2}',"+"Sage='{3}',Sdept='{4}' where Sno='{0}'",s.Sno,s.Sname,s.Ssex,s.Sage,s.Sdept);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Delete(string sno)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("delete from Studrnt where Sno='{0}'",sno);
            dbHelper.ExecuteNonQuery(sql);
        }
    }
}
