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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.working_day = new CSharpOskaAPI.WF.NumberBox();
            this.employeeList = new CSharpOskaAPI.WF.FilterComboBox();
            this.InputLayout = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.defaultBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.InputLayout.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DATE
            // 
            this.DATE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DATE.AutoSize = true;
            this.DATE.Location = new System.Drawing.Point(34, 27);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(53, 17);
            this.DATE.TabIndex = 0;
            this.DATE.Text = "2018-1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DATE, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.working_day, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.employeeList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.InputLayout, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 604);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee\'s Data";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 93);
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
            this.working_day.Location = new System.Drawing.Point(124, 88);
            this.working_day.Name = "working_day";
            this.working_day.OriText = "";
            this.working_day.Size = new System.Drawing.Size(131, 28);
            this.working_day.TabIndex = 0;
            this.working_day.Text = " DAY";
            // 
            // employeeList
            // 
            this.employeeList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.employeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.employeeList.FormattingEnabled = true;
            this.employeeList.Items.AddRange(new object[] {
            ""});
            this.employeeList.Location = new System.Drawing.Point(124, 146);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(131, 30);
            this.employeeList.StringList = "";
            this.employeeList.TabIndex = 1;
            this.employeeList.SelectedIndexChanged += new System.EventHandler(this.employeeList_SelectedIndexChanged);
            // 
            // InputLayout
            // 
            this.InputLayout.ColumnCount = 2;
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
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
            this.InputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLayout.Location = new System.Drawing.Point(124, 195);
            this.InputLayout.Name = "InputLayout";
            this.InputLayout.RowCount = 5;
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.Size = new System.Drawing.Size(546, 406);
            this.InputLayout.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Worked Day";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Late";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Worked";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Overtime";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 32);
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
            this.leave.Location = new System.Drawing.Point(139, 26);
            this.leave.Name = "leave";
            this.leave.OriText = "";
            this.leave.Size = new System.Drawing.Size(144, 28);
            this.leave.TabIndex = 2;
            // 
            // ot
            // 
            this.ot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ot.Holder = " MINUTES";
            this.ot.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.ot.Location = new System.Drawing.Point(139, 107);
            this.ot.Name = "ot";
            this.ot.OriText = "";
            this.ot.Size = new System.Drawing.Size(144, 28);
            this.ot.TabIndex = 3;
            // 
            // worked
            // 
            this.worked.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.worked.Holder = " DAY";
            this.worked.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.worked.Location = new System.Drawing.Point(139, 188);
            this.worked.Name = "worked";
            this.worked.OriText = "";
            this.worked.Size = new System.Drawing.Size(144, 28);
            this.worked.TabIndex = 4;
            // 
            // late
            // 
            this.late.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.late.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.late.Holder = " TIMES";
            this.late.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.late.Location = new System.Drawing.Point(139, 269);
            this.late.Name = "late";
            this.late.OriText = "";
            this.late.Size = new System.Drawing.Size(144, 28);
            this.late.TabIndex = 5;
            // 
            // worked_day
            // 
            this.worked_day.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worked_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.worked_day.Holder = " DAY";
            this.worked_day.HolderType = CSharpOskaAPI.WF.HolderType.BACK;
            this.worked_day.Location = new System.Drawing.Point(139, 351);
            this.worked_day.Name = "worked_day";
            this.worked_day.OriText = "";
            this.worked_day.Size = new System.Drawing.Size(144, 28);
            this.worked_day.TabIndex = 6;
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(546, 66);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // defaultBtn
            // 
            this.defaultBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultBtn.Image = ((System.Drawing.Image)(resources.GetObject("defaultBtn.Image")));
            this.defaultBtn.Location = new System.Drawing.Point(3, 3);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(267, 60);
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
            this.saveBtn.Size = new System.Drawing.Size(267, 60);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            this.Text = "ReportDataEdit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InputLayout.ResumeLayout(false);
            this.InputLayout.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
    }
}