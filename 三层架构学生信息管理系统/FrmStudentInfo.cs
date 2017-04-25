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
using BLL;


namespace 三层架构学生信息管理系统
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();

            Query query = new Query();
            List<Student> students = query.GetStudents();
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

        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            List<Student> students = query.GetStudents();
            dataGridView1.DataSource = students;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtSno.Text = row.Cells["Sno"].Value.ToString();
            txtSname.Text = row.Cells["Sname"].Value.ToString();
            txtSsex.Text = row.Cells["Ssex"].Value.ToString();
            txtSage.Text = row.Cells["Sage"].Value.ToString();
            txtSdept.Text = row.Cells["Sdept"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Sno = txtSno.Text;
            s.Sname = txtSname.Text;
            s.Ssex = txtSsex.Text;
            s.Sage = int.Parse(txtSage.Text);
            s.Sdept = txtSdept.Text;

            Manager manager = new Manager();
            manager.StudentInsert(s);

            FrmStudentInfo_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Sno = txtSno.Text;
            s.Sname = txtSname.Text;
            s.Ssex = txtSsex.Text;
            s.Sage = int.Parse(txtSage.Text);
            s.Sdept = txtSdept.Text;

            Manager manager = new Manager();
            manager.StudentUpdate(s);

            FrmStudentInfo_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.StudentDelete(txtSno.Text);

            FrmStudentInfo_Load(null, null);
        }
    }
}
