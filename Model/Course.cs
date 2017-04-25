using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Course
    {
        public int Cno { get; set; }
        public string Cname { get; set; }
        public int Cpno { get; set; }
        public int Credit { get; set; }

        public Course()
        {

        }
        public Course(int cno,string cname,int cpno,int credit)
        {
            Cno = cno;
            Cname = cname;
            Cpno = cpno;
            Credit = credit;
        }
    }
}
