using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class StudentOrder
    {
        public int Order { get; set; }
        public string Sno { get; set; }
        public string Sname { get; set; }
        public double GradeSum { get; set; }

        public StudentOrder()
        {

        }

        public StudentOrder(int order,string sno,string sname,double gradesum)
        {
            Order = order;
            Sno = sno;
            Sname = sname;
            GradeSum = gradesum;
        }
    }
}
