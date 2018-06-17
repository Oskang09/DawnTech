namespace DawnTech.wfgui
{
    partial class CustomPrintDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPrintDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nric = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.TextBox();
            this.join_date = new System.Windows.Forms.DateTimePicker();
            this.month = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.done = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.45679F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.54321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.empno, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nric, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dept, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.join_date, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.month, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.91935F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMP NO";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NRIC";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Join Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "DEPT";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "MONTH";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // empno
            // 
            this.empno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.empno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.empno.Location = new System.Drawing.Point(117, 23);
            this.empno.Name = "empno";
            this.empno.Size = new System.Drawing.Size(210, 28);
            this.empno.TabIndex = 6;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.name.Location = new System.Drawing.Point(117, 97);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(210, 28);
            this.name.TabIndex = 7;
            // 
            // nric
            // 
            this.nric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.nric.Location = new System.Drawing.Point(117, 171);
            this.nric.Name = "nric";
            this.nric.Size = new System.Drawing.Size(210, 28);
            this.nric.TabIndex = 8;
            // 
            // dept
            // 
            this.dept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dept.Location = new System.Drawing.Point(117, 245);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(210, 28);
            this.dept.TabIndex = 9;
            // 
            // join_date
            // 
            this.join_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.join_date.Location = new System.Drawing.Point(117, 322);
            this.join_date.Name = "join_date";
            this.join_date.Size = new System.Drawing.Size(260, 22);
            this.join_date.TabIndex = 10;
            // 
            // month
            // 
            this.month.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.month.Location = new System.Drawing.Point(117, 396);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(260, 22);
            this.month.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.done, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.quit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 447);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(735, 101);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // done
            // 
            this.done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.done.Image = ((System.Drawing.Image)(resources.GetObject("done.Image")));
            this.done.Location = new System.Drawing.Point(3, 3);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(361, 95);
            this.done.TabIndex = 0;
            this.done.Text = "DONE";
            this.done.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.done.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // quit
            // 
            this.quit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quit.Image = ((System.Drawing.Image)(resources.GetObject("quit.Image")));
            this.quit.Location = new System.Drawing.Point(370, 3);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(362, 95);
            this.quit.TabIndex = 1;
            this.quit.Text = "QUIT";
            this.quit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.quit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // CustomPrintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "CustomPrintDialog";
            this.Text = "Employee Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empno;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox nric;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.DateTimePicker join_date;
        private System.Windows.Forms.DateTimePicker month;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button quit;
    }
}