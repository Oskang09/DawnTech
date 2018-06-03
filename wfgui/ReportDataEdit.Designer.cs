namespace DawnTech.wfgui
{
    partial class ReportDataEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDataEdit));
            this.DATE = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.holidayEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.working_day = new CSharpOskaAPI.WF.NumberBox();
            this.InputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pbcEdit = new System.Windows.Forms.Button();
            this.allowanceEdit = new System.Windows.Forms.Button();
            this.leaveEdit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leave = new CSharpOskaAPI.WF.NumberBox();
            this.ot = new CSharpOskaAPI.WF.NumberBox();
            this.worked = new CSharpOskaAPI.WF.NumberBox();
            this.late = new CSharpOskaAPI.WF.NumberBox();
            this.worked_day = new CSharpOskaAPI.WF.NumberBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.defaultBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeList = new CSharpOskaAPI.WF.FilterComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ph_counter = new CSharpOskaAPI.WF.NumberBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.allowance = new CSharpOskaAPI.WF.NumberBox();
            this.pbc = new CSharpOskaAPI.WF.NumberBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.InputLayout.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DATE
            // 
            this.DATE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DATE.AutoSize = true;
            this.DATE.Location = new System.Drawing.Point(18, 24);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(85, 17);
            this.DATE.TabIndex = 0;
            this.DATE.Text = "DATE_TIME";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DATE, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.working_day, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.InputLayout, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.employeeList, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.81818F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 604);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // holidayEdit
            // 
            this.holidayEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.holidayEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("holidayEdit.BackgroundImage")));
            this.holidayEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.holidayEdit.Location = new System.Drawing.Point(150, 4);
            this.holidayEdit.Name = "holidayEdit";
            this.holidayEdit.Size = new System.Drawing.Size(40, 40);
            this.holidayEdit.TabIndex = 9;
            this.holidayEdit.UseVisualStyleBackColor = true;
            this.holidayEdit.Click += new System.EventHandler(this.holidayEdit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee\'s Data";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Working Day";
            // 
            // working_day
            // 
            this.working_day.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.working_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.working_day.Holder = " DAY";
            this.working_day.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.working_day.Location = new System.Drawing.Point(124, 78);
            this.working_day.Name = "working_day";
            this.working_day.OriText = "";
            this.working_day.Size = new System.Drawing.Size(144, 28);
            this.working_day.TabIndex = 0;
            this.working_day.Text = " DAY";
            // 
            // InputLayout
            // 
            this.InputLayout.ColumnCount = 4;
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.InputLayout.Controls.Add(this.leaveEdit, 3, 0);
            this.InputLayout.Controls.Add(this.label12, 2, 0);
            this.InputLayout.Controls.Add(this.label8, 0, 4);
            this.InputLayout.Controls.Add(this.label7, 0, 3);
            this.InputLayout.Controls.Add(this.label6, 0, 2);
            this.InputLayout.Controls.Add(this.label5, 0, 1);
            this.InputLayout.Controls.Add(this.label4, 0, 0);
            this.InputLayout.Controls.Add(this.leave, 1, 0);
            this.InputLayout.Controls.Add(this.ot, 1, 1);
            this.InputLayout.Controls.Add(this.worked, 1, 2);
            this.InputLayout.Controls.Add(this.late, 1, 3);
            this.InputLayout.Controls.Add(this.worked_day, 1, 4);
            this.InputLayout.Controls.Add(this.label11, 2, 1);
            this.InputLayout.Controls.Add(this.label10, 2, 2);
            this.InputLayout.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.InputLayout.Controls.Add(this.tableLayoutPanel5, 3, 2);
            this.InputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLayout.Location = new System.Drawing.Point(124, 230);
            this.InputLayout.Name = "InputLayout";
            this.InputLayout.RowCount = 5;
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.Size = new System.Drawing.Size(546, 371);
            this.InputLayout.TabIndex = 5;
            this.InputLayout.Visible = false;
            // 
            // pbcEdit
            // 
            this.pbcEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbcEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcEdit.BackgroundImage")));
            this.pbcEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbcEdit.Location = new System.Drawing.Point(143, 14);
            this.pbcEdit.Name = "pbcEdit";
            this.pbcEdit.Size = new System.Drawing.Size(40, 40);
            this.pbcEdit.TabIndex = 12;
            this.pbcEdit.UseVisualStyleBackColor = true;
            this.pbcEdit.Click += new System.EventHandler(this.pbcEdit_Click);
            // 
            // allowanceEdit
            // 
            this.allowanceEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.allowanceEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allowanceEdit.BackgroundImage")));
            this.allowanceEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.allowanceEdit.Location = new System.Drawing.Point(143, 14);
            this.allowanceEdit.Name = "allowanceEdit";
            this.allowanceEdit.Size = new System.Drawing.Size(40, 40);
            this.allowanceEdit.TabIndex = 11;
            this.allowanceEdit.UseVisualStyleBackColor = true;
            this.allowanceEdit.Click += new System.EventHandler(this.allowanceEdit_Click);
            // 
            // leaveEdit
            // 
            this.leaveEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leaveEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leaveEdit.BackgroundImage")));
            this.leaveEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leaveEdit.Location = new System.Drawing.Point(356, 17);
            this.leaveEdit.Name = "leaveEdit";
            this.leaveEdit.Size = new System.Drawing.Size(40, 40);
            this.leaveEdit.TabIndex = 10;
            this.leaveEdit.UseVisualStyleBackColor = true;
            this.leaveEdit.Click += new System.EventHandler(this.leaveEdit_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Leave";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Work Day";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Late";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Worked";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Overtime";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Leave";
            // 
            // leave
            // 
            this.leave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.leave.Holder = " DAY";
            this.leave.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.leave.Location = new System.Drawing.Point(84, 23);
            this.leave.Name = "leave";
            this.leave.OriText = "";
            this.leave.Size = new System.Drawing.Size(144, 28);
            this.leave.TabIndex = 2;
            this.leave.Text = " DAY";
            // 
            // ot
            // 
            this.ot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ot.Holder = " MINUTES";
            this.ot.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.ot.Location = new System.Drawing.Point(84, 97);
            this.ot.Name = "ot";
            this.ot.OriText = "";
            this.ot.Size = new System.Drawing.Size(144, 28);
            this.ot.TabIndex = 3;
            this.ot.Text = " MINUTES";
            // 
            // worked
            // 
            this.worked.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.worked.Holder = " DAY";
            this.worked.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.worked.Location = new System.Drawing.Point(84, 171);
            this.worked.Name = "worked";
            this.worked.OriText = "";
            this.worked.Size = new System.Drawing.Size(144, 28);
            this.worked.TabIndex = 4;
            this.worked.Text = " DAY";
            // 
            // late
            // 
            this.late.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.late.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.late.Holder = " TIMES";
            this.late.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.late.Location = new System.Drawing.Point(84, 245);
            this.late.Name = "late";
            this.late.OriText = "";
            this.late.Size = new System.Drawing.Size(144, 28);
            this.late.TabIndex = 5;
            this.late.Text = " TIMES";
            // 
            // worked_day
            // 
            this.worked_day.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worked_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.worked_day.Holder = " DAY";
            this.worked_day.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.worked_day.Location = new System.Drawing.Point(84, 319);
            this.worked_day.Name = "worked_day";
            this.worked_day.OriText = "";
            this.worked_day.Size = new System.Drawing.Size(144, 28);
            this.worked_day.TabIndex = 6;
            this.worked_day.Text = " DAY";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Allowance";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "PBC";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.defaultBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.saveBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(124, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(546, 59);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // defaultBtn
            // 
            this.defaultBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultBtn.Image = ((System.Drawing.Image)(resources.GetObject("defaultBtn.Image")));
            this.defaultBtn.Location = new System.Drawing.Point(3, 3);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(267, 53);
            this.defaultBtn.TabIndex = 0;
            this.defaultBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.defaultBtn.UseVisualStyleBackColor = true;
            this.defaultBtn.Click += new System.EventHandler(this.defaultBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(276, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(267, 53);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee";
            // 
            // employeeList
            // 
            this.employeeList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.employeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.employeeList.FormattingEnabled = true;
            this.employeeList.Items.AddRange(new object[] {
            ""});
            this.employeeList.Location = new System.Drawing.Point(124, 184);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(144, 30);
            this.employeeList.StringList = "";
            this.employeeList.TabIndex = 1;
            this.employeeList.SelectedIndexChanged += new System.EventHandler(this.employeeList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Public Holiday";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel2.Controls.Add(this.holidayEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ph_counter, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(124, 122);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(546, 48);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // ph_counter
            // 
            this.ph_counter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ph_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ph_counter.Holder = "";
            this.ph_counter.HolderType = CSharpOskaAPI.WF.HolderType.NONE;
            this.ph_counter.Location = new System.Drawing.Point(3, 10);
            this.ph_counter.Name = "ph_counter";
            this.ph_counter.OriText = "";
            this.ph_counter.ReadOnly = true;
            this.ph_counter.Size = new System.Drawing.Size(141, 28);
            this.ph_counter.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.allowanceEdit, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.allowance, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(356, 77);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(187, 68);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.pbcEdit, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.pbc, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(356, 151);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(187, 68);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // allowance
            // 
            this.allowance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.allowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.allowance.Holder = "RM ";
            this.allowance.HolderType = CSharpOskaAPI.WF.HolderType.FRONT;
            this.allowance.Location = new System.Drawing.Point(3, 20);
            this.allowance.Name = "allowance";
            this.allowance.OriText = "";
            this.allowance.ReadOnly = true;
            this.allowance.Size = new System.Drawing.Size(134, 28);
            this.allowance.TabIndex = 12;
            // 
            // pbc
            // 
            this.pbc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.pbc.Holder = "RM ";
            this.pbc.HolderType = CSharpOskaAPI.WF.HolderType.FRONT;
            this.pbc.Location = new System.Drawing.Point(3, 20);
            this.pbc.Name = "pbc";
            this.pbc.OriText = "";
            this.pbc.ReadOnly = true;
            this.pbc.Size = new System.Drawing.Size(134, 28);
            this.pbc.TabIndex = 13;
            // 
            // ReportDataEdit
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 604);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "ReportDataEdit";
            this.Text = "Report Data Edit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InputLayout.ResumeLayout(false);
            this.InputLayout.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DATE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private CSharpOskaAPI.WF.NumberBox working_day;
        private System.Windows.Forms.Label label2;
        private CSharpOskaAPI.WF.FilterComboBox employeeList;
        private System.Windows.Forms.TableLayoutPanel InputLayout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CSharpOskaAPI.WF.NumberBox leave;
        private CSharpOskaAPI.WF.NumberBox ot;
        private CSharpOskaAPI.WF.NumberBox worked;
        private CSharpOskaAPI.WF.NumberBox late;
        private CSharpOskaAPI.WF.NumberBox worked_day;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button defaultBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button holidayEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button pbcEdit;
        private System.Windows.Forms.Button allowanceEdit;
        private System.Windows.Forms.Button leaveEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CSharpOskaAPI.WF.NumberBox ph_counter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private CSharpOskaAPI.WF.NumberBox allowance;
        private CSharpOskaAPI.WF.NumberBox pbc;
    }
}