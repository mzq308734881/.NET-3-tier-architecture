using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SC
    {
        public string Sno { get; set; }
        public int Cno { get; set; }
        public double Grade { get; set; }

        public SC()
        {

        }

        public SC(string sno,int cno,double grade)
        {
            Sno = sno;
            Cno = cno;
            Grade = grade;
        }
    }

    public class SCAll
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
        public string Ssex { get; set; }
        public int Sage { get; set; }
        public string Sdept { get; set; }

        public int Cno { get; set; }
        public string Cname { get; set; }
        public int Cpno { get; set; }
        public int Credit { get; set; }


        public double Grade { get; set; }

        public SCAll(Student s,Course c,SC sc)
        {
            Sno = s.Sno;
            Sname = s.Sname;
            Ssex = s.Ssex;
            Sage = s.Sage;
            Sdept = s.Sdept;

            Cno = c.Cno;
            Cname = c.Cname;
            Cpno = c.Cpno;
            Credit = c.Credit;

            Grade = sc.Grade;
        }
    }
}
