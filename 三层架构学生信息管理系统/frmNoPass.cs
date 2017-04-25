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
    public partial class frmNoPass : Form
    {
        public frmNoPass()
        {
            InitializeComponent();

            // 手动创建DataGridView的所有列
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.Name = "Sno";
            col.DataPropertyName = "Sno";
            col.HeaderText = "学号";
            col.Width = 100;
            dataGridView1.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Sname";
            col.DataPropertyName = "Sname";
            col.HeaderText = "姓名";
            col.Width = 100;
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
            col.Width = 100;
            dataGridView1.Columns.Add(col);

        }

        private void frmNoPass_Load(object sender, EventArgs e)
        {
            Query query = new Query();
            List<SCAll> scAlls = query.GetNOSCAlls();
            dataGridView1.DataSource = scAlls;
        }
    }
}
