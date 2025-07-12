namespace SuperMarket_Management_System
{
    partial class sellerform
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            sellerphone = new TextBox();
            sellerage = new NumericUpDown();
            sellerid = new NumericUpDown();
            sellerpassword = new TextBox();
            sellergridview = new DataGridView();
            deletebtn = new Button();
            editbtn = new Button();
            addbtn = new Button();
            sellername = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            closebtn = new Button();
            catgbtn = new Button();
            sellerbtn = new Button();
            logoutlb = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sellerage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellerid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellergridview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(sellerphone);
            panel1.Controls.Add(sellerage);
            panel1.Controls.Add(sellerid);
            panel1.Controls.Add(sellerpassword);
            panel1.Controls.Add(sellergridview);
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(editbtn);
            panel1.Controls.Add(addbtn);
            panel1.Controls.Add(sellername);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(152, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 542);
            panel1.TabIndex = 1;
            // 
            // sellerphone
            // 
            sellerphone.Location = new Point(164, 245);
            sellerphone.Name = "sellerphone";
            sellerphone.Size = new Size(152, 27);
            sellerphone.TabIndex = 18;
            // 
            // sellerage
            // 
            sellerage.Location = new Point(164, 192);
            sellerage.Name = "sellerage";
            sellerage.Size = new Size(152, 27);
            sellerage.TabIndex = 17;
            // 
            // sellerid
            // 
            sellerid.Location = new Point(164, 87);
            sellerid.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            sellerid.Name = "sellerid";
            sellerid.Size = new Size(152, 27);
            sellerid.TabIndex = 9;
            // 
            // sellerpassword
            // 
            sellerpassword.Location = new Point(164, 299);
            sellerpassword.Name = "sellerpassword";
            sellerpassword.Size = new Size(152, 27);
            sellerpassword.TabIndex = 16;
            // 
            // sellergridview
            // 
            sellergridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            sellergridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            sellergridview.BackgroundColor = Color.White;
            sellergridview.BorderStyle = BorderStyle.None;
            sellergridview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sellergridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOrange;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            sellergridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            sellergridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            sellergridview.DefaultCellStyle = dataGridViewCellStyle2;
            sellergridview.EnableHeadersVisualStyles = false;
            sellergridview.GridColor = Color.Gainsboro;
            sellergridview.Location = new Point(358, 87);
            sellergridview.Name = "sellergridview";
            sellergridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            sellergridview.RowHeadersVisible = false;
            sellergridview.RowHeadersWidth = 51;
            sellergridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sellergridview.Size = new Size(444, 441);
            sellergridview.TabIndex = 15;
            sellergridview.CellContentClick += dataGridView1_CellContentClick;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.White;
            deletebtn.FlatAppearance.BorderSize = 0;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            deletebtn.ForeColor = Color.DarkOrange;
            deletebtn.Location = new Point(221, 368);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(95, 45);
            deletebtn.TabIndex = 14;
            deletebtn.Text = "DELETE";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.White;
            editbtn.FlatAppearance.BorderSize = 0;
            editbtn.FlatStyle = FlatStyle.Flat;
            editbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            editbtn.ForeColor = Color.DarkOrange;
            editbtn.Location = new Point(118, 368);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(95, 45);
            editbtn.TabIndex = 13;
            editbtn.Text = "EDIT";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.White;
            addbtn.FlatAppearance.BorderSize = 0;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            addbtn.ForeColor = Color.DarkOrange;
            addbtn.Location = new Point(14, 368);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(95, 45);
            addbtn.TabIndex = 5;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // sellername
            // 
            sellername.Location = new Point(164, 138);
            sellername.Name = "sellername";
            sellername.Size = new Size(152, 27);
            sellername.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 293);
            label8.Name = "label8";
            label8.Size = new Size(147, 32);
            label8.TabIndex = 7;
            label8.Text = "PASSWORD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 239);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 6;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 187);
            label6.Name = "label6";
            label6.Size = new Size(59, 32);
            label6.TabIndex = 5;
            label6.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 138);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 3;
            label4.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 32);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(301, 23);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "MANAGE SELLERS";
            // 
            // closebtn
            // 
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            closebtn.ForeColor = Color.DarkOrange;
            closebtn.Location = new Point(945, 1);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(34, 42);
            closebtn.TabIndex = 5;
            closebtn.Text = "x";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // catgbtn
            // 
            catgbtn.FlatAppearance.BorderSize = 0;
            catgbtn.FlatStyle = FlatStyle.Flat;
            catgbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            catgbtn.ForeColor = Color.DarkOrange;
            catgbtn.Location = new Point(2, 156);
            catgbtn.Name = "catgbtn";
            catgbtn.Size = new Size(148, 45);
            catgbtn.TabIndex = 8;
            catgbtn.Text = "Categories";
            catgbtn.UseVisualStyleBackColor = true;
            catgbtn.Click += catgbtn_Click;
            // 
            // sellerbtn
            // 
            sellerbtn.FlatAppearance.BorderSize = 0;
            sellerbtn.FlatStyle = FlatStyle.Flat;
            sellerbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            sellerbtn.ForeColor = Color.DarkOrange;
            sellerbtn.Location = new Point(15, 105);
            sellerbtn.Name = "sellerbtn";
            sellerbtn.Size = new Size(128, 45);
            sellerbtn.TabIndex = 6;
            sellerbtn.Text = "Products";
            sellerbtn.UseVisualStyleBackColor = true;
            sellerbtn.Click += sellerbtn_Click;
            // 
            // logoutlb
            // 
            logoutlb.AutoSize = true;
            logoutlb.BackColor = Color.Transparent;
            logoutlb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logoutlb.ForeColor = Color.DarkOrange;
            logoutlb.Location = new Point(35, 569);
            logoutlb.Name = "logoutlb";
            logoutlb.Size = new Size(78, 28);
            logoutlb.TabIndex = 34;
            logoutlb.Text = "Logout";
            logoutlb.Click += logoutlb_Click;
            // 
            // sellerform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(logoutlb);
            Controls.Add(catgbtn);
            Controls.Add(sellerbtn);
            Controls.Add(closebtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sellerform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "seller";
            Load += sellerform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sellerage).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellerid).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellergridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView sellergridview;
        private Button deletebtn;
        private Button editbtn;
        private Button addbtn;
        private TextBox sellername;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button closebtn;
        private Button catgbtn;
        private Button sellerbtn;
        private Label label8;
        private TextBox sellerpassword;
        private NumericUpDown sellerid;
        private NumericUpDown sellerage;
        private TextBox sellerphone;
        private Label logoutlb;
    }
}