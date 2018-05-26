namespace DawnTech.wfgui
{
    partial class EmployeeDataDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDataDisplay));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.InputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.eistype = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.socsoType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empno = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.percentageEPF = new CSharpOskaAPI.WF.NumberBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.basic = new CSharpOskaAPI.WF.NumberBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeDataDGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.SortBy = new System.Windows.Forms.ComboBox();
            this.SortBox = new System.Windows.Forms.TextBox();
            this.age = new CSharpOskaAPI.WF.NumberBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.InputLayout.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataDGV)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 585);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.InputLayout, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(410, 579);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // InputLayout
            // 
            this.InputLayout.ColumnCount = 2;
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.82178F));
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.17822F));
            this.InputLayout.Controls.Add(this.age, 1, 3);
            this.InputLayout.Controls.Add(this.tableLayoutPanel6, 0, 7);
            this.InputLayout.Controls.Add(this.tableLayoutPanel5, 0, 6);
            this.InputLayout.Controls.Add(this.label5, 0, 4);
            this.InputLayout.Controls.Add(this.label4, 0, 3);
            this.InputLayout.Controls.Add(this.dept, 1, 2);
            this.InputLayout.Controls.Add(this.label3, 0, 2);
            this.InputLayout.Controls.Add(this.name, 1, 1);
            this.InputLayout.Controls.Add(this.label2, 0, 1);
            this.InputLayout.Controls.Add(this.label1, 0, 0);
            this.InputLayout.Controls.Add(this.empno, 1, 0);
            this.InputLayout.Controls.Add(this.tableLayoutPanel7, 0, 5);
            this.InputLayout.Controls.Add(this.basic, 1, 4);
            this.InputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLayout.Location = new System.Drawing.Point(3, 3);
            this.InputLayout.Name = "InputLayout";
            this.InputLayout.RowCount = 8;
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InputLayout.Size = new System.Drawing.Size(404, 457);
            this.InputLayout.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.InputLayout.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.25557F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.74443F));
            this.tableLayoutPanel6.Controls.Add(this.checkBox3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.eistype, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 402);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(398, 52);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(58, 15);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 21);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "USE EIS";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // eistype
            // 
            this.eistype.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.eistype.Enabled = false;
            this.eistype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.eistype.FormattingEnabled = true;
            this.eistype.Items.AddRange(new object[] {
            "EMPLOYEE",
            "BOSS"});
            this.eistype.Location = new System.Drawing.Point(147, 12);
            this.eistype.Name = "eistype";
            this.eistype.Size = new System.Drawing.Size(243, 28);
            this.eistype.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.InputLayout.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.40416F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.59584F));
            this.tableLayoutPanel5.Controls.Add(this.checkBox2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.socsoType, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 345);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(398, 51);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(30, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "USE SOCSO";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // socsoType
            // 
            this.socsoType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.socsoType.Enabled = false;
            this.socsoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.socsoType.FormattingEnabled = true;
            this.socsoType.Items.AddRange(new object[] {
            "EMPLOYEE",
            "BOSS"});
            this.socsoType.Location = new System.Drawing.Point(147, 11);
            this.socsoType.Name = "socsoType";
            this.socsoType.Size = new System.Drawing.Size(242, 28);
            this.socsoType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "BASIC";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "AGE";
            // 
            // dept
            // 
            this.dept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept.Location = new System.Drawing.Point(74, 129);
            this.dept.Name = "dept";
            this.dept.ReadOnly = true;
            this.dept.Size = new System.Drawing.Size(242, 27);
            this.dept.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEPT";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(74, 72);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(242, 27);
            this.name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMP NO";
            // 
            // empno
            // 
            this.empno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.empno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empno.Location = new System.Drawing.Point(74, 15);
            this.empno.Name = "empno";
            this.empno.ReadOnly = true;
            this.empno.Size = new System.Drawing.Size(242, 27);
            this.empno.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.InputLayout.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.40416F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.59584F));
            this.tableLayoutPanel7.Controls.Add(this.percentageEPF, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 288);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(398, 51);
            this.tableLayoutPanel7.TabIndex = 10;
            // 
            // percentageEPF
            // 
            this.percentageEPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.percentageEPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.percentageEPF.Holder = "%";
            this.percentageEPF.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.percentageEPF.Location = new System.Drawing.Point(147, 12);
            this.percentageEPF.Name = "percentageEPF";
            this.percentageEPF.ReadOnly = true;
            this.percentageEPF.Size = new System.Drawing.Size(242, 27);
            this.percentageEPF.TabIndex = 14;
            this.percentageEPF.Text = "%";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(53, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "USE EPF";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // basic
            // 
            this.basic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.basic.Holder = "RM ";
            this.basic.HolderType = CSharpOskaAPI.WF.HolderType.FRONT;
            this.basic.Location = new System.Drawing.Point(74, 243);
            this.basic.Name = "basic";
            this.basic.ReadOnly = true;
            this.basic.Size = new System.Drawing.Size(242, 27);
            this.basic.TabIndex = 13;
            this.basic.Text = "RM ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.EditBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ExitBtn, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DeleteBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.SaveBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 466);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(404, 110);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // EditBtn
            // 
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.Location = new System.Drawing.Point(83, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(74, 104);
            this.EditBtn.TabIndex = 11;
            this.EditBtn.Text = "Edit";
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(323, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(78, 104);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(74, 104);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Location = new System.Drawing.Point(243, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 104);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(163, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(74, 104);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.EmployeeDataDGV, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(419, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(411, 579);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // EmployeeDataDGV
            // 
            this.EmployeeDataDGV.AllowUserToAddRows = false;
            this.EmployeeDataDGV.AllowUserToDeleteRows = false;
            this.EmployeeDataDGV.AllowUserToOrderColumns = true;
            this.EmployeeDataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeDataDGV.Location = new System.Drawing.Point(3, 60);
            this.EmployeeDataDGV.MultiSelect = false;
            this.EmployeeDataDGV.Name = "EmployeeDataDGV";
            this.EmployeeDataDGV.ReadOnly = true;
            this.EmployeeDataDGV.RowHeadersVisible = false;
            this.EmployeeDataDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeeDataDGV.RowTemplate.Height = 24;
            this.EmployeeDataDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataDGV.Size = new System.Drawing.Size(405, 516);
            this.EmployeeDataDGV.TabIndex = 3;
            this.EmployeeDataDGV.SelectionChanged += new System.EventHandler(this.EmployeeDataDGV_SelectionChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel9.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.SortBy, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.SortBox, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(405, 51);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sort By";
            // 
            // SortBy
            // 
            this.SortBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortBy.FormattingEnabled = true;
            this.SortBy.Location = new System.Drawing.Point(63, 13);
            this.SortBy.Name = "SortBy";
            this.SortBy.Size = new System.Drawing.Size(115, 24);
            this.SortBy.TabIndex = 1;
            this.SortBy.SelectedIndexChanged += new System.EventHandler(this.SortBy_SelectedIndexChanged);
            // 
            // SortBox
            // 
            this.SortBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SortBox.Location = new System.Drawing.Point(184, 14);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(218, 22);
            this.SortBox.TabIndex = 2;
            this.SortBox.TextChanged += new System.EventHandler(this.SortBox_TextChanged);
            // 
            // age
            // 
            this.age.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.age.Holder = "";
            this.age.HolderType = CSharpOskaAPI.WF.HolderType.NONE;
            this.age.Location = new System.Drawing.Point(74, 186);
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Size = new System.Drawing.Size(242, 27);
            this.age.TabIndex = 14;
            // 
            // EmployeeDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "EmployeeDataDisplay";
            this.Size = new System.Drawing.Size(833, 585);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.InputLayout.ResumeLayout(false);
            this.InputLayout.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataDGV)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TableLayoutPanel InputLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox eistype;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox socsoType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private CSharpOskaAPI.WF.NumberBox percentageEPF;
        private System.Windows.Forms.CheckBox checkBox1;
        private CSharpOskaAPI.WF.NumberBox basic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DataGridView EmployeeDataDGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox SortBy;
        public System.Windows.Forms.TextBox SortBox;
        private CSharpOskaAPI.WF.NumberBox age;
    }
}
