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
    public partial class FrmGradeSort : Form
    {
        public FrmGradeSort()
        {
            InitializeComponent();


            dataGridView1.AutoGenerateColumns = false;

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.Name = "Order";
            col.DataPropertyName = "Order";
            col.HeaderText = "名次";
            col.Width = 100;
            dataGridView1.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
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
            col.Name = "GradeSum";
            col.DataPropertyName = "GradeSum";
            col.HeaderText = "总成绩";
            col.Width = 100;
            dataGridView1.Columns.Add(col);
        }

        private void FrmGradeSort_Load(object sender, EventArgs e)
        {
            StatAnaly statAnaly = new StatAnaly();
            List<StudentOrder> studentOrders = statAnaly.GetStudentOrders();
            dataGridView1.DataSource = studentOrders;
        }
    }
}
