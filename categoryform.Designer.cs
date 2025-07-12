namespace SuperMarket_Management_System
{
    partial class categoryform
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ctgidtxt = new TextBox();
            ctgdestxt = new TextBox();
            CtgdataGrid = new DataGridView();
            ctgdeletebtn = new Button();
            ctgeditbtn = new Button();
            ctgaddbtn = new Button();
            ctgnametxt = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            closebtn = new Button();
            catgbtn = new Button();
            sellerbtn = new Button();
            logoutlb = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CtgdataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(ctgidtxt);
            panel1.Controls.Add(ctgdestxt);
            panel1.Controls.Add(CtgdataGrid);
            panel1.Controls.Add(ctgdeletebtn);
            panel1.Controls.Add(ctgeditbtn);
            panel1.Controls.Add(ctgaddbtn);
            panel1.Controls.Add(ctgnametxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(152, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 542);
            panel1.TabIndex = 2;
            // 
            // ctgidtxt
            // 
            ctgidtxt.Location = new Point(190, 87);
            ctgidtxt.Name = "ctgidtxt";
            ctgidtxt.Size = new Size(152, 27);
            ctgidtxt.TabIndex = 17;
            ctgidtxt.TextChanged += ctgidtxt_TextChanged;
            // 
            // ctgdestxt
            // 
            ctgdestxt.Location = new Point(190, 193);
            ctgdestxt.Name = "ctgdestxt";
            ctgdestxt.Size = new Size(152, 27);
            ctgdestxt.TabIndex = 16;
            // 
            // CtgdataGrid
            // 
            CtgdataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CtgdataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CtgdataGrid.BackgroundColor = Color.White;
            CtgdataGrid.BorderStyle = BorderStyle.None;
            CtgdataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CtgdataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkOrange;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CtgdataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CtgdataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CtgdataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            CtgdataGrid.EnableHeadersVisualStyles = false;
            CtgdataGrid.GridColor = Color.Gainsboro;
            CtgdataGrid.Location = new Point(358, 87);
            CtgdataGrid.MultiSelect = false;
            CtgdataGrid.Name = "CtgdataGrid";
            CtgdataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.DarkOrange;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CtgdataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CtgdataGrid.RowHeadersVisible = false;
            CtgdataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            CtgdataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            CtgdataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CtgdataGrid.Size = new Size(444, 441);
            CtgdataGrid.TabIndex = 15;
            CtgdataGrid.CellContentClick += CtgdataGrid_CellContentClick;
            // 
            // ctgdeletebtn
            // 
            ctgdeletebtn.BackColor = Color.White;
            ctgdeletebtn.FlatAppearance.BorderSize = 0;
            ctgdeletebtn.FlatStyle = FlatStyle.Flat;
            ctgdeletebtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ctgdeletebtn.ForeColor = Color.DarkOrange;
            ctgdeletebtn.Location = new Point(247, 247);
            ctgdeletebtn.Name = "ctgdeletebtn";
            ctgdeletebtn.Size = new Size(95, 45);
            ctgdeletebtn.TabIndex = 14;
            ctgdeletebtn.Text = "DELETE";
            ctgdeletebtn.UseVisualStyleBackColor = false;
            ctgdeletebtn.Click += ctgdeletebtn_Click;
            // 
            // ctgeditbtn
            // 
            ctgeditbtn.BackColor = Color.White;
            ctgeditbtn.FlatAppearance.BorderSize = 0;
            ctgeditbtn.FlatStyle = FlatStyle.Flat;
            ctgeditbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ctgeditbtn.ForeColor = Color.DarkOrange;
            ctgeditbtn.Location = new Point(134, 247);
            ctgeditbtn.Name = "ctgeditbtn";
            ctgeditbtn.Size = new Size(95, 45);
            ctgeditbtn.TabIndex = 13;
            ctgeditbtn.Text = "EDIT";
            ctgeditbtn.UseVisualStyleBackColor = false;
            ctgeditbtn.Click += ctgeditbtn_Click;
            // 
            // ctgaddbtn
            // 
            ctgaddbtn.BackColor = Color.White;
            ctgaddbtn.FlatAppearance.BorderSize = 0;
            ctgaddbtn.FlatStyle = FlatStyle.Flat;
            ctgaddbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ctgaddbtn.ForeColor = Color.DarkOrange;
            ctgaddbtn.Location = new Point(20, 247);
            ctgaddbtn.Name = "ctgaddbtn";
            ctgaddbtn.Size = new Size(95, 45);
            ctgaddbtn.TabIndex = 5;
            ctgaddbtn.Text = "ADD";
            ctgaddbtn.UseVisualStyleBackColor = false;
            ctgaddbtn.Click += ctgaddbtn_Click;
            // 
            // ctgnametxt
            // 
            ctgnametxt.Location = new Point(190, 138);
            ctgnametxt.Name = "ctgnametxt";
            ctgnametxt.Size = new Size(152, 27);
            ctgnametxt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 187);
            label6.Name = "label6";
            label6.Size = new Size(171, 32);
            label6.TabIndex = 5;
            label6.Text = "DESCRIPTION";
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
            label1.Size = new Size(269, 32);
            label1.TabIndex = 0;
            label1.Text = "MANAGE CATEGORIES";
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
            closebtn.TabIndex = 6;
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
            catgbtn.TabIndex = 9;
            catgbtn.Text = "Products";
            catgbtn.UseVisualStyleBackColor = true;
            catgbtn.Click += catgbtn_Click;
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
            sellerbtn.TabIndex = 7;
            sellerbtn.Text = "Sellers";
            sellerbtn.UseVisualStyleBackColor = true;
            sellerbtn.Click += sellerbtn_Click;
            // 
            // logoutlb
            // 
            logoutlb.AutoSize = true;
            logoutlb.BackColor = Color.Transparent;
            logoutlb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logoutlb.ForeColor = Color.DarkOrange;
            logoutlb.Location = new Point(41, 569);
            logoutlb.Name = "logoutlb";
            logoutlb.Size = new Size(78, 28);
            logoutlb.TabIndex = 34;
            logoutlb.Text = "Logout";
            logoutlb.Click += logoutlb_Click;
            // 
            // categoryform
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
            Name = "categoryform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "categoryform";
            Load += categoryform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CtgdataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView CtgdataGrid;
        private Button ctgdeletebtn;
        private Button ctgeditbtn;
        private Button ctgaddbtn;
        private TextBox ctgnametxt;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button closebtn;
        private TextBox ctgdestxt;
        private Button catgbtn;
        private Button sellerbtn;
        private TextBox ctgidtxt;
        private Label logoutlb;
    }
}