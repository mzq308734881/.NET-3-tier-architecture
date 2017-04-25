using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Student
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
        public string Ssex { get; set; }
        public int Sage { get; set; }
        public string Sdept { get; set; }

        public Student()
        {

        }

        public Student(string sno,string sname,string ssex,int sage,string sdept)
        {
            Sno = sno;
            Sname = sname;
            Ssex = ssex;
            Sage = sage;
            Sdept = sdept;
        }
    }
}
