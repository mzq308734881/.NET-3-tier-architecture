using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace 三层架构学生信息管理系统
{
    public partial class FrmStudentByNo : Form
    {
        public FrmStudentByNo()
        {
            InitializeComponent();
        }

        private void FrmStudentByNo_Load(object sender, EventArgs e)
        {
            Query query = new Query();

            List<Student> students = query.GetStudents();
            //var snos = students.Select(s => new { s.Sno }).Distinct().ToList();

            // 从学生表中得到所有“学号”的唯一列表
            cboNo.Items.Clear();
            cboNo.Items.Add("");
            //foreach (var sno in snos)
            //cboSno.Items.Add(sno.Sno);
            foreach (var student in students)
                cboNo.Items.Add(student.Sno);

            btnFind_Click(this, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {


            Query query = new Query();
            List<Student> students = query.GetStudentsByNo(cboNo.Text);
            dataGridView1.DataSource = students;

            // 自动创建DataGridView的列后，再修改列的部分属性
            DataGridViewColumn col = dataGridView1.Columns["Sno"];
            col.HeaderText = "学号";
            col.Width = 80;

            col = dataGridView1.Columns["Sname"];
            col.HeaderText = "姓名";
            col.Width = 100;

            col = dataGridView1.Columns["Ssex"];
            col.HeaderText = "性别";
            col.Width = 100;

            col = dataGridView1.Columns["Sage"];
            col.HeaderText = "年龄";
            col.Width = 100;

            col = dataGridView1.Columns["Sdept"];
            col.HeaderText = "所在系";
            col.Width = 100;
        }
    }
}
