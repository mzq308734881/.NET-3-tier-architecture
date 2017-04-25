using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace 三层架构学生信息管理系统
{
    public partial class FrmStudentBySexDept : Form
    {
        public FrmStudentBySexDept()
        {
            InitializeComponent();

            // 初始化性别组合框的选项列表
            cboSex.Items.Add("");
            cboSex.Items.Add("男");
            cboSex.Items.Add("女");
        }

        private void FrmStudentBySexDept_Load(object sender, EventArgs e)
        {
            Query query = new Query();

            List<Student> students = query.GetStudents();
            //var depts = students.Select(s => new { s.Sdept }).Distinct().ToList();

            // 从学生表中得到所有“所在系”的唯一列表
            cboDept.Items.Clear();
            cboDept.Items.Add("");
            //foreach (var dept in depts)
            //cboDept.Items.Add(dept.Sdept);
            foreach (var student in students)
                cboDept.Items.Add(student.Sdept);

            btnFind_Click(this, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Query query = new Query();
            List<Student> students = query.GetStudentsBySexDept(cboSex.Text, cboDept.Text);
            dataGridView1.DataSource = students;

            // 自动创建DataGridView的列后，再修改列的部分属性
            DataGridViewColumn col = dataGridView1.Columns["Sno"];
            col.HeaderText = "学号";
            col.Width = 60;

            col = dataGridView1.Columns["Sname"];
            col.HeaderText = "姓名";
            col.Width = 80;

            col = dataGridView1.Columns["Ssex"];
            col.HeaderText = "性别";
            col.Width = 60;

            col = dataGridView1.Columns["Sage"];
            col.HeaderText = "年龄";
            col.Width = 60;

            col = dataGridView1.Columns["Sdept"];
            col.HeaderText = "所在系";
            col.Width = 80;
        }
    }
}
