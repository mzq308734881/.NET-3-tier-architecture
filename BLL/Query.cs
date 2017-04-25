using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class Query
    {
        public List<Student> GetStudents()
        {
            StudentDAO sDAO = new StudentDAO();
            List<Student> students0 = sDAO.GetStudents();
            return students0;
        }

        public List<Student> GetStudentsByNo(string no)
        {
            StudentDAO sDAO = new StudentDAO();
            List<Student> students0 = sDAO.GetStudents();
            if (string.IsNullOrEmpty(no))
                return students0;

            List<Student> students = new List<Student>();
            foreach (Student s in students0)
            {
                if (s.Sno == no)
                    students.Add(s);
            }
            return students;
        }

        public List<Student> GetStudentsBySexDept(string sex, string dept)
        {
            StudentDAO sDAO = new StudentDAO();
            List<Student> students0 = sDAO.GetStudents();
            if (string.IsNullOrEmpty(sex) && string.IsNullOrEmpty(dept))
                return students0;

            List<Student> students = new List<Student>();
            foreach (Student s in students0)
            {
                if (!string.IsNullOrEmpty(sex) && !string.IsNullOrEmpty(dept))
                {
                    if (s.Ssex == sex && s.Sdept.IndexOf(dept) >= 0)
                        students.Add(s);
                }
                else if (!string.IsNullOrEmpty(sex))
                {
                    if (s.Ssex == sex)
                        students.Add(s);
                }
                else if (!string.IsNullOrEmpty(dept))
                {
                    if (s.Sdept.IndexOf(dept) >= 0)
                        students.Add(s);
                }
            }
            return students;
        }

        public List<Course> GetCourses()
        {
            CourseDAO cDAO = new CourseDAO();
            List<Course> courses = cDAO.GetCourse();
            return courses;
        }

        public List<SCAll> GetSCAlls()
        {
            SCDAO sDAO = new SCDAO();
            List<SCAll> scAlls = sDAO.GetSCAll();
            return scAlls;
        }
    }
}
