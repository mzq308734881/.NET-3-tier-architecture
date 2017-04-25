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
    public partial class frmCourseInfo : Form
    {
        public frmCourseInfo()
        {
            InitializeComponent();

            Query query = new Query();
            List<Course> students = query.GetCourses();
            dataGridView1.DataSource = students;

            // 自动创建DataGridView的列后，再修改列的部分属性
            DataGridViewColumn col = dataGridView1.Columns["Cno"];
            col.HeaderText = "课程号";
            col.Width = 100;

            col = dataGridView1.Columns["Cname"];
            col.HeaderText = "课程名";
            col.Width = 100;

            col = dataGridView1.Columns["CPno"];
            col.HeaderText = "先修课号";
            col.Width = 100;

            col = dataGridView1.Columns["Credit"];
            col.HeaderText = "学分";
            col.Width = 60;
               
        }

        private void frmCourseInfo_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            List<Course> students = query.GetCourses();
            dataGridView1.DataSource = students;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Cname = txtCname.Text;
            c.Cno = int.Parse(txtCno.Text);
            c.Cpno =int.Parse(txtpno.Text);
            c.Credit = int.Parse(txtCredit.Text);            

            Manager manager = new Manager();
            manager.CourseInsert(c);

            frmCourseInfo_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Cname = txtCname.Text;
            c.Cno = int.Parse(txtCno.Text);
            c.Cpno = int.Parse(txtpno.Text);
            c.Credit = int.Parse(txtCredit.Text);

            Manager manager = new Manager();
            manager.CourseUpdate(c);

            frmCourseInfo_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.CourseDelete(int.Parse(txtCno.Text));

            frmCourseInfo_Load(null, null);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtCname.Text = row.Cells["Cname"].Value.ToString();
            txtCno.Text = row.Cells["Cno"].Value.ToString();     
            txtpno.Text = row.Cells["CPno"].Value.ToString();
            txtCredit.Text = row.Cells["Credit"].Value.ToString();            
        }
    }
}
