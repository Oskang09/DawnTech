namespace DawnTech.wfgui
{
    partial class LeaveEditDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveEditDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LeaveData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.leaveDate = new System.Windows.Forms.DateTimePicker();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.fee = new CSharpOskaAPI.WF.NumberBox();
            this.label4 = new System.Windows.Forms.Label();
            this.employee = new CSharpOskaAPI.WF.FilterComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveData)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.LeaveData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.leaveDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.notes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fee, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.employee, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LeaveData
            // 
            this.LeaveData.AllowUserToAddRows = false;
            this.LeaveData.AllowUserToDeleteRows = false;
            this.LeaveData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.LeaveData, 2);
            this.LeaveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeaveData.Location = new System.Drawing.Point(3, 95);
            this.LeaveData.Name = "LeaveData";
            this.LeaveData.ReadOnly = true;
            this.LeaveData.RowTemplate.Height = 24;
            this.LeaveData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LeaveData.Size = new System.Drawing.Size(844, 210);
            this.LeaveData.TabIndex = 0;
            this.LeaveData.SelectionChanged += new System.EventHandler(this.LeaveData_SelectionChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leave Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medical Fee";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 525);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(844, 90);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(416, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(425, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(416, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "DELETE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // leaveDate
            // 
            this.leaveDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leaveDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.leaveDate.Location = new System.Drawing.Point(173, 327);
            this.leaveDate.Name = "leaveDate";
            this.leaveDate.Size = new System.Drawing.Size(254, 22);
            this.leaveDate.TabIndex = 7;
            // 
            // notes
            // 
            this.notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notes.Location = new System.Drawing.Point(173, 372);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(674, 86);
            this.notes.TabIndex = 8;
            this.notes.Text = "";
            // 
            // fee
            // 
            this.fee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.fee.Holder = "RM ";
            this.fee.HolderType = CSharpOskaAPI.WF.HolderType.FRONT;
            this.fee.Location = new System.Drawing.Point(173, 477);
            this.fee.Name = "fee";
            this.fee.OriText = "";
            this.fee.Size = new System.Drawing.Size(166, 28);
            this.fee.TabIndex = 9;
            this.fee.Text = "RM ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employee";
            // 
            // employee
            // 
            this.employee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.employee.FormattingEnabled = true;
            this.employee.Items.AddRange(new object[] {
            ""});
            this.employee.Location = new System.Drawing.Point(173, 30);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(180, 30);
            this.employee.StringList = "";
            this.employee.TabIndex = 11;
            this.employee.SelectedIndexChanged += new System.EventHandler(this.employee_SelectedIndexChanged);
            // 
            // LeaveEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "LeaveEditDialog";
            this.Size = new System.Drawing.Size(850, 618);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveData)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView LeaveData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker leaveDate;
        private System.Windows.Forms.RichTextBox notes;
        private CSharpOskaAPI.WF.NumberBox fee;
        private System.Windows.Forms.Label label4;
        private CSharpOskaAPI.WF.FilterComboBox employee;
    }
}