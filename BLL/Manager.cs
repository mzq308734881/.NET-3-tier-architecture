using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class Manager
    {
        public void StudentInsert(Student s)
        {
            StudentDAO sDAO = new StudentDAO();
            sDAO.Insert(s);
        }

        public void StudentUpdate(Student s)
        {
            StudentDAO sDAO = new StudentDAO();
            sDAO.Update(s);
        }

        public void StudentDelete(string no)
        {
            StudentDAO sDAO = new StudentDAO();
            sDAO.Delete(no);
        }

        public void CourseInsert(Course c)
        {
            CourseDAO cDAO = new CourseDAO();
            cDAO.Insert(c);
        }

        public void SCInsert(SC sc)
        {
            SCDAO scDAO = new SCDAO();
            scDAO.Insert(sc);
        }

        public void SCUpdate(SC sc)
        {
            SCDAO scDAO = new SCDAO();
            scDAO.Update(sc);
        }
    }
}
