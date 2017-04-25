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
    public partial class FrmSCInfo : Form
    {
        public FrmSCInfo()
        {
            InitializeComponent();

            // 手动创建DataGridView的所有列
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.Name = "Sno";
            col.DataPropertyName = "Sno";
            col.HeaderText = "学号";
            col.Width = 60;
            dataGridView1.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Sname";
            col.DataPropertyName = "Sname";
            col.HeaderText = "姓名";
            col.Width = 80;
            dataGridView1.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Cname";
            col.DataPropertyName = "Cname";
            col.HeaderText = "课程名称";
            col.Width = 100;
            dataGridView1.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Grade";
            col.DataPropertyName = "Grade";
            col.HeaderText = "成绩";
            col.Width = 60;
            dataGridView1.Columns.Add(col);
        }

        private void FrmSCInfo_Load(object sender, EventArgs e)
        {
            Query query = new Query();

            // 使用学生表中的姓名数据初始化姓名列表
            List<Student> ss = query.GetStudents();
            cboSname.DataSource = ss;
            cboSname.DisplayMember = "Sname";
            cboSname.ValueMember = "Sno";

            // 使用课程表中的课程名数据初始化课程名列表
            List<Course> cs = query.GetCourses();
            cboCname.DataSource = cs;
            cboCname.DisplayMember = "Cname";
            cboCname.ValueMember = "Cno";

            List<SCAll> scAlls = query.GetSCAlls();
            dataGridView1.DataSource = scAlls;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            cboSname.Text = row.Cells["Sname"].Value.ToString();
            cboCname.Text = row.Cells["Cname"].Value.ToString();
            txtGrade.Text = row.Cells["Grade"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sno = cboSname.SelectedValue.ToString();
            int cno = Convert.ToInt32(cboCname.SelectedValue);
            double grade = double.Parse(txtGrade.Text);
            SC sc = new SC(sno, cno, grade);

            Manager manager = new Manager();
            manager.SCInsert(sc);

            FrmSCInfo_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sno = cboSname.SelectedValue.ToString();
            int cno = Convert.ToInt32(cboCname.SelectedValue);
            double grade = double.Parse(txtGrade.Text);
            SC sc = new SC(sno, cno, grade);

            Manager manager = new Manager();
            manager.SCUpdate(sc);


            FrmSCInfo_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sno = cboSname.SelectedValue.ToString();
            int cno = Convert.ToInt32(cboCname.SelectedValue);
            double grade = double.Parse(txtGrade.Text);
            SC sc = new SC(sno, cno, grade);

            Manager manager = new Manager();
            manager.SCDelete(sc.Sno,sc.Cno);

            FrmSCInfo_Load(null, null);
        }
    }
}
