using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class StatAnaly
    {
        public List<StudentOrder> GetStudentOrders()
        {
            SCDAO scDAO = new SCDAO();
            List<StudentOrder> studentOrders = scDAO.GetStudentOrders();
            return studentOrders;
        }
    }
}
