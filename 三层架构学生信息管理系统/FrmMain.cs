using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 三层架构学生信息管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MiStudentInfo_Click(object sender, EventArgs e)
        {
            FrmStudentInfo frmStudentInfo = new FrmStudentInfo();
            frmStudentInfo.ShowDialog();
        }

        private void MiCourseInfo_Click(object sender, EventArgs e)
        {
            frmCourseInfo frmcourseIndfo = new frmCourseInfo();
            frmcourseIndfo.ShowDialog();
        }

        private void MiSCInfo_Click(object sender, EventArgs e)
        {

            FrmSCInfo frmSCInfo = new FrmSCInfo();
            frmSCInfo.ShowDialog();
        }

        private void miStudentByNo_Click(object sender, EventArgs e)
        {
            FrmStudentByNo frmStudentByNo = new FrmStudentByNo();
            frmStudentByNo.ShowDialog();
        }

        private void miStudentBySexDept_Click(object sender, EventArgs e)
        {
            FrmStudentBySexDept frmStudentbysexdept = new FrmStudentBySexDept();
            frmStudentbysexdept.ShowDialog();
        }

        private void miGradeSort_Click(object sender, EventArgs e)
        {
            FrmGradeSort frmGradeSort = new FrmGradeSort();
            frmGradeSort.ShowDialog();
        }

        private void miNoPassList_Click(object sender, EventArgs e)
        {
            frmNoPass frmnopass = new frmNoPass();
            frmnopass.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
