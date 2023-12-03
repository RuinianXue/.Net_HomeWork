namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLog = new System.Windows.Forms.Button();
            this.ReloadDatabase = new System.Windows.Forms.Button();
            this.NewPeople = new System.Windows.Forms.Button();
            this.NewClass = new System.Windows.Forms.Button();
            this.NewSchool = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.dataGridViewSchool = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeleteSchool = new System.Windows.Forms.Button();
            this.buttonDeleteClass = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchool)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 774);
            this.panel1.TabIndex = 2;
            // 
            // buttonLog
            // 
            this.buttonLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLog.Location = new System.Drawing.Point(611, 91);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(163, 43);
            this.buttonLog.TabIndex = 10;
            this.buttonLog.Text = "View Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // ReloadDatabase
            // 
            this.ReloadDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReloadDatabase.Location = new System.Drawing.Point(1150, 91);
            this.ReloadDatabase.Name = "ReloadDatabase";
            this.ReloadDatabase.Size = new System.Drawing.Size(163, 43);
            this.ReloadDatabase.TabIndex = 9;
            this.ReloadDatabase.Text = "Reload Database";
            this.ReloadDatabase.UseVisualStyleBackColor = true;
            this.ReloadDatabase.Click += new System.EventHandler(this.ReloadDatabase_Click);
            // 
            // NewPeople
            // 
            this.NewPeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPeople.Location = new System.Drawing.Point(1167, 19);
            this.NewPeople.Name = "NewPeople";
            this.NewPeople.Size = new System.Drawing.Size(129, 37);
            this.NewPeople.TabIndex = 8;
            this.NewPeople.Text = "New Student";
            this.NewPeople.UseVisualStyleBackColor = true;
            this.NewPeople.Click += new System.EventHandler(this.NewStudent_Click);
            // 
            // NewClass
            // 
            this.NewClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewClass.Location = new System.Drawing.Point(629, 19);
            this.NewClass.Name = "NewClass";
            this.NewClass.Size = new System.Drawing.Size(127, 37);
            this.NewClass.TabIndex = 7;
            this.NewClass.Text = "New Class";
            this.NewClass.UseVisualStyleBackColor = true;
            this.NewClass.Click += new System.EventHandler(this.NewClass_Click);
            // 
            // NewSchool
            // 
            this.NewSchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewSchool.Location = new System.Drawing.Point(169, 19);
            this.NewSchool.Name = "NewSchool";
            this.NewSchool.Size = new System.Drawing.Size(127, 37);
            this.NewSchool.TabIndex = 6;
            this.NewSchool.Text = "New School";
            this.NewSchool.UseVisualStyleBackColor = true;
            this.NewSchool.Click += new System.EventHandler(this.NewSchool_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.64103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.35897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 622F));
            this.tableLayoutPanel1.Controls.Add(this.NewSchool, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NewClass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NewPeople, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReloadDatabase, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonLog, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1543, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1543, 64);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewClass, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewSchool, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewStudent, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, -4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1543, 714);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudent.Location = new System.Drawing.Point(1008, 3);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 62;
            this.dataGridViewStudent.RowTemplate.Height = 30;
            this.dataGridViewStudent.Size = new System.Drawing.Size(532, 708);
            this.dataGridViewStudent.TabIndex = 2;
            this.dataGridViewStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbvStudent_CellDoubleClick);
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClass.Location = new System.Drawing.Point(472, 3);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.RowHeadersWidth = 62;
            this.dataGridViewClass.RowTemplate.Height = 30;
            this.dataGridViewClass.Size = new System.Drawing.Size(530, 708);
            this.dataGridViewClass.TabIndex = 1;
            this.dataGridViewClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellClick);
            this.dataGridViewClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellClick);
            this.dataGridViewClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbvClass_CellDoubleClick);
            // 
            // dataGridViewSchool
            // 
            this.dataGridViewSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSchool.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSchool.Name = "dataGridViewSchool";
            this.dataGridViewSchool.RowHeadersWidth = 62;
            this.dataGridViewSchool.RowTemplate.Height = 30;
            this.dataGridViewSchool.Size = new System.Drawing.Size(463, 708);
            this.dataGridViewSchool.TabIndex = 0;
            this.dataGridViewSchool.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchool_CellClick);
            this.dataGridViewSchool.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchool_CellClick);
            this.dataGridViewSchool.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbvSchool_CellDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.52087F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.47913F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 536F));
            this.tableLayoutPanel3.Controls.Add(this.buttonDeleteStudent, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDeleteClass, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDeleteSchool, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1543, 64);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonDeleteSchool
            // 
            this.buttonDeleteSchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteSchool.Location = new System.Drawing.Point(157, 13);
            this.buttonDeleteSchool.Name = "buttonDeleteSchool";
            this.buttonDeleteSchool.Size = new System.Drawing.Size(154, 37);
            this.buttonDeleteSchool.TabIndex = 11;
            this.buttonDeleteSchool.Text = "Delete School";
            this.buttonDeleteSchool.UseVisualStyleBackColor = true;
            this.buttonDeleteSchool.Click += new System.EventHandler(this.buttonDeleteSchool_Click);
            // 
            // buttonDeleteClass
            // 
            this.buttonDeleteClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteClass.Location = new System.Drawing.Point(660, 13);
            this.buttonDeleteClass.Name = "buttonDeleteClass";
            this.buttonDeleteClass.Size = new System.Drawing.Size(154, 37);
            this.buttonDeleteClass.TabIndex = 14;
            this.buttonDeleteClass.Text = "Delete Class";
            this.buttonDeleteClass.UseVisualStyleBackColor = true;
            this.buttonDeleteClass.Click += new System.EventHandler(this.buttonDeleteClass_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(1197, 13);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(154, 37);
            this.buttonDeleteStudent.TabIndex = 15;
            this.buttonDeleteStudent.Text = "Delete Student";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 924);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchool)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.DataGridView dataGridViewSchool;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button ReloadDatabase;
        private System.Windows.Forms.Button NewPeople;
        private System.Windows.Forms.Button NewClass;
        private System.Windows.Forms.Button NewSchool;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonDeleteSchool;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonDeleteClass;
    }
}

