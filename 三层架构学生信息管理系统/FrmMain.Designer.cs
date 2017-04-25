namespace 三层架构学生信息管理系统
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiStudentInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MiCourseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MiSCInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miStudentByNo = new System.Windows.Forms.ToolStripMenuItem();
            this.miStudentBySexDept = new System.Windows.Forms.ToolStripMenuItem();
            this.统计分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miGradeSort = new System.Windows.Forms.ToolStripMenuItem();
            this.miNoPassList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据管理ToolStripMenuItem,
            this.数据查询ToolStripMenuItem,
            this.统计分析ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据管理ToolStripMenuItem
            // 
            this.数据管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiStudentInfo,
            this.MiCourseInfo,
            this.MiSCInfo});
            this.数据管理ToolStripMenuItem.Name = "数据管理ToolStripMenuItem";
            this.数据管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据管理ToolStripMenuItem.Text = "数据管理";
            // 
            // MiStudentInfo
            // 
            this.MiStudentInfo.Name = "MiStudentInfo";
            this.MiStudentInfo.Size = new System.Drawing.Size(124, 22);
            this.MiStudentInfo.Text = "学生信息";
            this.MiStudentInfo.Click += new System.EventHandler(this.MiStudentInfo_Click);
            // 
            // MiCourseInfo
            // 
            this.MiCourseInfo.Name = "MiCourseInfo";
            this.MiCourseInfo.Size = new System.Drawing.Size(124, 22);
            this.MiCourseInfo.Text = "课程信息";
            this.MiCourseInfo.Click += new System.EventHandler(this.MiCourseInfo_Click);
            // 
            // MiSCInfo
            // 
            this.MiSCInfo.Name = "MiSCInfo";
            this.MiSCInfo.Size = new System.Drawing.Size(124, 22);
            this.MiSCInfo.Text = "成绩信息";
            this.MiSCInfo.Click += new System.EventHandler(this.MiSCInfo_Click);
            // 
            // 数据查询ToolStripMenuItem
            // 
            this.数据查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStudentByNo,
            this.miStudentBySexDept});
            this.数据查询ToolStripMenuItem.Name = "数据查询ToolStripMenuItem";
            this.数据查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据查询ToolStripMenuItem.Text = "数据查询";
            // 
            // miStudentByNo
            // 
            this.miStudentByNo.Name = "miStudentByNo";
            this.miStudentByNo.Size = new System.Drawing.Size(169, 22);
            this.miStudentByNo.Text = "按学号查询";
            this.miStudentByNo.Click += new System.EventHandler(this.miStudentByNo_Click);
            // 
            // miStudentBySexDept
            // 
            this.miStudentBySexDept.Name = "miStudentBySexDept";
            this.miStudentBySexDept.Size = new System.Drawing.Size(169, 22);
            this.miStudentBySexDept.Text = "按性别+院系查询";
            this.miStudentBySexDept.Click += new System.EventHandler(this.miStudentBySexDept_Click);
            // 
            // 统计分析ToolStripMenuItem
            // 
            this.统计分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGradeSort,
            this.miNoPassList});
            this.统计分析ToolStripMenuItem.Name = "统计分析ToolStripMenuItem";
            this.统计分析ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.统计分析ToolStripMenuItem.Text = "统计分析";
            // 
            // miGradeSort
            // 
            this.miGradeSort.Name = "miGradeSort";
            this.miGradeSort.Size = new System.Drawing.Size(160, 22);
            this.miGradeSort.Text = "按成绩总分排名";
            this.miGradeSort.Click += new System.EventHandler(this.miGradeSort_Click);
            // 
            // miNoPassList
            // 
            this.miNoPassList.Name = "miNoPassList";
            this.miNoPassList.Size = new System.Drawing.Size(160, 22);
            this.miNoPassList.Text = "不及格课程清单";
            this.miNoPassList.Click += new System.EventHandler(this.miNoPassList_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MiStudentInfo;
        private System.Windows.Forms.ToolStripMenuItem MiCourseInfo;
        private System.Windows.Forms.ToolStripMenuItem MiSCInfo;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miStudentByNo;
        private System.Windows.Forms.ToolStripMenuItem miStudentBySexDept;
        private System.Windows.Forms.ToolStripMenuItem 统计分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miGradeSort;
        private System.Windows.Forms.ToolStripMenuItem miNoPassList;
    }
}