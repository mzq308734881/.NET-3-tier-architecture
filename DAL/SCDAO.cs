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
     public  class SCDAO
    {
        public List<SCAll> GetSCAll()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "SELECT S.Sno, S.Sname, S.Ssex, S.Sage, S.Sdept, " +
                "C.Cno, C.Cname, C.Cpno, C.Credit, SC.Grade " +
                "FROM Student S INNER JOIN SC ON S.Sno=SC.Sno " +
                "INNER JOIN Course C ON SC.Cno=C.Cno";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<SCAll> scAlls = new List<SCAll>();
            while(reader.Read())
            {
                string sno = reader["Sno"].ToString().Trim();
                string sname = reader["Sname"].ToString().Trim();
                string ssex = reader["Ssex"].ToString().Trim();
                int sage = Convert.ToInt32(reader["Sage"]);
                string sdept = reader["Sdept"].ToString().Trim();
                Student s = new Student(sno,sname,ssex,sage,sdept);

                int cno = Convert.ToInt32(reader["Cno"]);
                string cname = reader["Cname"].ToString().Trim();
                int cpno = Convert.IsDBNull(reader["Cpno"]) ? -1 : Convert.ToInt32(reader["Cpno"]);
                int credit = Convert.ToInt32(reader["Credit"]);
                Course c = new Course(cno,cname,cpno,credit);

                double grade = Convert.ToDouble(reader["Grade"]);
                SC sc = new SC(sno,cno,grade);

                scAlls.Add(new SCAll(s,c,sc));
            }
            reader.Close();
            return scAlls;
        }


        public List<SCAll> GetNOSCAll()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "SELECT S.Sno, S.Sname, S.Ssex, S.Sage, S.Sdept, " +
                "C.Cno, C.Cname, C.Cpno, C.Credit, SC.Grade " +
                "FROM Student S INNER JOIN SC ON S.Sno=SC.Sno " +
                "INNER JOIN Course C ON SC.Cno=C.Cno";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<SCAll> scAlls = new List<SCAll>();
            while (reader.Read())
            {
                string sno = reader["Sno"].ToString().Trim();
                string sname = reader["Sname"].ToString().Trim();
                string ssex = reader["Ssex"].ToString().Trim();
                int sage = Convert.ToInt32(reader["Sage"]);
                string sdept = reader["Sdept"].ToString().Trim();
                Student s = new Student(sno, sname, ssex, sage, sdept);

                int cno = Convert.ToInt32(reader["Cno"]);
                string cname = reader["Cname"].ToString().Trim();
                int cpno = Convert.IsDBNull(reader["Cpno"]) ? -1 : Convert.ToInt32(reader["Cpno"]);
                int credit = Convert.ToInt32(reader["Credit"]);
                Course c = new Course(cno, cname, cpno, credit);

                double grade = Convert.ToDouble(reader["Grade"]);
                SC sc = new SC(sno, cno, grade);

                scAlls.Add(new SCAll(s, c, sc));
            }
            reader.Close();
            return scAlls;
        }

      
        public List<StudentOrder> GetStudentOrders()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "SELECT S.Sno, S.Sname, A.GradeSum " +
                    "FROM Student S INNER JOIN (" +
                    "SELECT Sno, SUM(Grade) GradeSum FROM SC " +
                    "GROUP BY Sno) A ON S.Sno = A.Sno " +
                    "ORDER BY A.GradeSum DESC";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<StudentOrder> studentOrders = new List<StudentOrder>();
            int count = 0, order = 0;
            double gradeSumLast = -1;
            while(reader.Read())
            {
                string sno = reader["Sno"].ToString().Trim();
                string sname = reader["Sname"].ToString().Trim();
                double gradeSum = Convert.ToDouble(reader["GradeSum"]);
                count++;
                if (gradeSum != gradeSumLast || order <= 0)
                    order = count;
                studentOrders.Add(new StudentOrder(order,sno,sname,gradeSum));
            }
            reader.Close();
            return studentOrders;
        }

        public List<SC> GetSCs()
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = "select * from SC";
            SqlDataReader reader = dbHelper.ExecuteReader(sql);
            List<SC> scs = new List<SC>();
            while(reader.Read())
            {
                string sno = reader["Sno"].ToString().Trim();
                int cno = Convert.ToInt32(reader["Cno"]);
                double grade = Convert.ToDouble(reader["Grade"]);
                SC sc = new SC(sno,cno,grade);

                scs.Add(new SC(sno,cno,grade));
            }
            reader.Close();
            return scs;
        }

        public void Insert(SC sc)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("INSERT INTO SC VALUES('{0}', {1}, {2})",
                sc.Sno, sc.Cno, sc.Grade);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Update(SC sc)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("UPDATE SC SET Grade={2} WHERE Sno='{0}' AND Cno={1}",
                sc.Sno, sc.Cno, sc.Grade);
            dbHelper.ExecuteNonQuery(sql);
        }

        public void Delete(string sno,int cno)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();
            string sql = string.Format("DELETE FROM SC WHERE Sno='{0}' AND Cno={1}", sno, cno);
            dbHelper.ExecuteNonQuery(sql);
        }
    }
}
