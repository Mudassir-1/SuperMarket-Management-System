namespace SuperMarket_Management_System
{
    partial class productform
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            productid = new TextBox();
            productqty = new NumericUpDown();
            productpice = new NumericUpDown();
            button1 = new Button();
            productdataGridView = new DataGridView();
            deletebtn = new Button();
            editbtn = new Button();
            addbtn = new Button();
            productcategory = new ComboBox();
            productname = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            sellerbtn = new Button();
            catgbtn = new Button();
            closebtn = new Button();
            logoutlb = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productqty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productpice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productdataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(productid);
            panel1.Controls.Add(productqty);
            panel1.Controls.Add(productpice);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(productdataGridView);
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(editbtn);
            panel1.Controls.Add(addbtn);
            panel1.Controls.Add(productcategory);
            panel1.Controls.Add(productname);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(152, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 542);
            panel1.TabIndex = 0;
            // 
            // productid
            // 
            productid.Location = new Point(164, 119);
            productid.Name = "productid";
            productid.Size = new Size(152, 27);
            productid.TabIndex = 20;
            // 
            // productqty
            // 
            productqty.Location = new Point(164, 219);
            productqty.Name = "productqty";
            productqty.Size = new Size(152, 27);
            productqty.TabIndex = 19;
            // 
            // productpice
            // 
            productpice.Location = new Point(164, 273);
            productpice.Name = "productpice";
            productpice.Size = new Size(152, 27);
            productpice.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(700, 57);
            button1.Name = "button1";
            button1.Size = new Size(102, 33);
            button1.TabIndex = 17;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // productdataGridView
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            productdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            productdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            productdataGridView.BackgroundColor = Color.White;
            productdataGridView.BorderStyle = BorderStyle.None;
            productdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.DarkOrange;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            productdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            productdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            productdataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            productdataGridView.EnableHeadersVisualStyles = false;
            productdataGridView.GridColor = Color.Gainsboro;
            productdataGridView.Location = new Point(322, 104);
            productdataGridView.MultiSelect = false;
            productdataGridView.Name = "productdataGridView";
            productdataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            productdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            productdataGridView.RowHeadersVisible = false;
            productdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            productdataGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productdataGridView.Size = new Size(480, 424);
            productdataGridView.TabIndex = 15;
            productdataGridView.CellContentClick += productdataGridView_CellContentClick;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.White;
            deletebtn.FlatAppearance.BorderSize = 0;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            deletebtn.ForeColor = Color.DarkOrange;
            deletebtn.Location = new Point(221, 395);
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
            editbtn.Location = new Point(118, 395);
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
            addbtn.Location = new Point(14, 395);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(95, 45);
            addbtn.TabIndex = 5;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // productcategory
            // 
            productcategory.Font = new Font("Segoe UI", 11F);
            productcategory.ForeColor = Color.DarkOrange;
            productcategory.FormattingEnabled = true;
            productcategory.Location = new Point(164, 320);
            productcategory.Name = "productcategory";
            productcategory.Size = new Size(152, 33);
            productcategory.TabIndex = 12;
            productcategory.Text = "Select Category";
            // 
            // productname
            // 
            productname.Location = new Point(164, 165);
            productname.Name = "productname";
            productname.Size = new Size(152, 27);
            productname.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 320);
            label8.Name = "label8";
            label8.Size = new Size(137, 32);
            label8.TabIndex = 7;
            label8.Text = "CATEGORY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 266);
            label7.Name = "label7";
            label7.Size = new Size(81, 32);
            label7.TabIndex = 6;
            label7.Text = "PRICE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 214);
            label6.Name = "label6";
            label6.Size = new Size(135, 32);
            label6.TabIndex = 5;
            label6.Text = "QUANTITY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 165);
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
            label2.Location = new Point(14, 114);
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
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "MANAGE PRODUCT";
            // 
            // sellerbtn
            // 
            sellerbtn.FlatAppearance.BorderSize = 0;
            sellerbtn.FlatStyle = FlatStyle.Flat;
            sellerbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            sellerbtn.ForeColor = Color.DarkOrange;
            sellerbtn.Location = new Point(22, 105);
            sellerbtn.Name = "sellerbtn";
            sellerbtn.Size = new Size(111, 45);
            sellerbtn.TabIndex = 1;
            sellerbtn.Text = "Sellers";
            sellerbtn.UseVisualStyleBackColor = true;
            sellerbtn.Click += button1_Click;
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
            catgbtn.TabIndex = 3;
            catgbtn.Text = "Categories";
            catgbtn.UseVisualStyleBackColor = true;
            catgbtn.Click += catgbtn_Click;
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
            closebtn.TabIndex = 4;
            closebtn.Text = "x";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // logoutlb
            // 
            logoutlb.AutoSize = true;
            logoutlb.BackColor = Color.Transparent;
            logoutlb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logoutlb.ForeColor = Color.DarkOrange;
            logoutlb.Location = new Point(37, 569);
            logoutlb.Name = "logoutlb";
            logoutlb.Size = new Size(78, 28);
            logoutlb.TabIndex = 33;
            logoutlb.Text = "Logout";
            logoutlb.Click += logoutlb_Click;
            // 
            // productform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(logoutlb);
            Controls.Add(closebtn);
            Controls.Add(catgbtn);
            Controls.Add(sellerbtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "productform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "productform";
            Load += productform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productqty).EndInit();
            ((System.ComponentModel.ISupportInitialize)productpice).EndInit();
            ((System.ComponentModel.ISupportInitialize)productdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button sellerbtn;
        private Button catgbtn;
        private Button closebtn;
        private Label label2;
        private Label label1;
        private TextBox productname;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Button addbtn;
        private Button deletebtn;
        private Button editbtn;
        private DataGridView productdataGridView;
        private Button button1;
        private ComboBox productcategory;
        private NumericUpDown productqty;
        private NumericUpDown productpice;
        private TextBox productid;
        private Label logoutlb;
    }
}