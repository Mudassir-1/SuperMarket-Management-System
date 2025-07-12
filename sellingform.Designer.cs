namespace SuperMarket_Management_System
{
    partial class sellingform
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sellingform));
            closebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            productname = new TextBox();
            productcategory = new ComboBox();
            addbtn = new Button();
            editbtn = new Button();
            button1 = new Button();
            productpice = new NumericUpDown();
            productqty = new NumericUpDown();
            productid = new TextBox();
            sellinggridview1 = new DataGridView();
            datelbl = new Label();
            button2 = new Button();
            billsdataGridView = new DataGridView();
            orderdataGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label9 = new Label();
            amtlbl = new Label();
            label11 = new Label();
            panel1 = new Panel();
            sellernamelbl = new Label();
            PrintPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            logoutlb = new Label();
            ((System.ComponentModel.ISupportInitialize)productpice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productqty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellinggridview1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billsdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderdataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(358, 13);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 0;
            label1.Text = "SELLING";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 1;
            label2.Text = "BILLID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 107);
            label4.Name = "label4";
            label4.Size = new Size(179, 32);
            label4.TabIndex = 3;
            label4.Text = "Product Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 156);
            label6.Name = "label6";
            label6.Size = new Size(113, 32);
            label6.TabIndex = 5;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 208);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 6;
            label7.Text = "Price";
            // 
            // productname
            // 
            productname.Enabled = false;
            productname.Location = new Point(179, 107);
            productname.Name = "productname";
            productname.Size = new Size(152, 27);
            productname.TabIndex = 9;
            // 
            // productcategory
            // 
            productcategory.Font = new Font("Segoe UI", 11F);
            productcategory.ForeColor = Color.DarkOrange;
            productcategory.FormattingEnabled = true;
            productcategory.Location = new Point(12, 253);
            productcategory.Name = "productcategory";
            productcategory.Size = new Size(179, 33);
            productcategory.TabIndex = 12;
            productcategory.Text = "Select Category";
            productcategory.SelectedIndexChanged += productcategory_SelectedIndexChanged;
            productcategory.SelectionChangeCommitted += productcategory_SelectionChangeCommitted;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.White;
            addbtn.FlatAppearance.BorderSize = 0;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            addbtn.ForeColor = Color.DarkOrange;
            addbtn.Location = new Point(512, 483);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(95, 45);
            addbtn.TabIndex = 5;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.White;
            editbtn.FlatAppearance.BorderSize = 0;
            editbtn.FlatStyle = FlatStyle.Flat;
            editbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            editbtn.ForeColor = Color.DarkOrange;
            editbtn.Location = new Point(638, 483);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(95, 45);
            editbtn.TabIndex = 13;
            editbtn.Text = "PRINT";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(197, 253);
            button1.Name = "button1";
            button1.Size = new Size(134, 33);
            button1.TabIndex = 17;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // productpice
            // 
            productpice.Enabled = false;
            productpice.Location = new Point(179, 215);
            productpice.Name = "productpice";
            productpice.Size = new Size(152, 27);
            productpice.TabIndex = 18;
            // 
            // productqty
            // 
            productqty.Location = new Point(179, 161);
            productqty.Name = "productqty";
            productqty.Size = new Size(152, 27);
            productqty.TabIndex = 19;
            // 
            // productid
            // 
            productid.Location = new Point(179, 61);
            productid.Name = "productid";
            productid.Size = new Size(152, 27);
            productid.TabIndex = 20;
            // 
            // sellinggridview1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sellinggridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            sellinggridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sellinggridview1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            sellinggridview1.BackgroundColor = Color.White;
            sellinggridview1.BorderStyle = BorderStyle.None;
            sellinggridview1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sellinggridview1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Brown;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            sellinggridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            sellinggridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            sellinggridview1.DefaultCellStyle = dataGridViewCellStyle3;
            sellinggridview1.EnableHeadersVisualStyles = false;
            sellinggridview1.GridColor = Color.Gainsboro;
            sellinggridview1.Location = new Point(12, 333);
            sellinggridview1.MultiSelect = false;
            sellinggridview1.Name = "sellinggridview1";
            sellinggridview1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            sellinggridview1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            sellinggridview1.RowHeadersVisible = false;
            sellinggridview1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sellinggridview1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            sellinggridview1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sellinggridview1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sellinggridview1.Size = new Size(319, 195);
            sellinggridview1.TabIndex = 21;
            sellinggridview1.CellContentClick += sellinggridview1_CellContentClick;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            datelbl.ForeColor = Color.White;
            datelbl.Location = new Point(674, 13);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(67, 32);
            datelbl.TabIndex = 22;
            datelbl.Text = "Date";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(12, 292);
            button2.Name = "button2";
            button2.Size = new Size(319, 35);
            button2.TabIndex = 24;
            button2.Text = "Add Product";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // billsdataGridView
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            billsdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            billsdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            billsdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            billsdataGridView.BackgroundColor = Color.White;
            billsdataGridView.BorderStyle = BorderStyle.None;
            billsdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            billsdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Brown;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            billsdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            billsdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            billsdataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            billsdataGridView.EnableHeadersVisualStyles = false;
            billsdataGridView.GridColor = Color.Gainsboro;
            billsdataGridView.Location = new Point(337, 292);
            billsdataGridView.MultiSelect = false;
            billsdataGridView.Name = "billsdataGridView";
            billsdataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            billsdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            billsdataGridView.RowHeadersVisible = false;
            billsdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            billsdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            billsdataGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            billsdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billsdataGridView.Size = new Size(478, 169);
            billsdataGridView.TabIndex = 25;
            billsdataGridView.CellContentClick += billsdataGridView_CellContentClick;
            // 
            // orderdataGridView
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            orderdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            orderdataGridView.BackgroundColor = Color.White;
            orderdataGridView.BorderStyle = BorderStyle.None;
            orderdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            orderdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.Brown;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            orderdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            orderdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderdataGridView.Columns.AddRange(new DataGridViewColumn[] { id, name, price, qty, total });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            orderdataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            orderdataGridView.EnableHeadersVisualStyles = false;
            orderdataGridView.GridColor = Color.Gainsboro;
            orderdataGridView.Location = new Point(337, 61);
            orderdataGridView.MultiSelect = false;
            orderdataGridView.Name = "orderdataGridView";
            orderdataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            orderdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            orderdataGridView.RowHeadersVisible = false;
            orderdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            orderdataGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderdataGridView.Size = new Size(478, 157);
            orderdataGridView.TabIndex = 28;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // qty
            // 
            qty.HeaderText = "Quantity";
            qty.MinimumWidth = 6;
            qty.Name = "qty";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(439, 221);
            label9.Name = "label9";
            label9.Size = new Size(163, 32);
            label9.TabIndex = 29;
            label9.Text = "Ammount Rs";
            // 
            // amtlbl
            // 
            amtlbl.AutoSize = true;
            amtlbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            amtlbl.ForeColor = Color.White;
            amtlbl.Location = new Point(599, 221);
            amtlbl.Name = "amtlbl";
            amtlbl.Size = new Size(28, 32);
            amtlbl.TabIndex = 30;
            amtlbl.Text = "0";
            amtlbl.Click += amtlbl_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(505, 253);
            label11.Name = "label11";
            label11.Size = new Size(117, 32);
            label11.TabIndex = 31;
            label11.Text = "Sales List";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(sellernamelbl);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(amtlbl);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(orderdataGridView);
            panel1.Controls.Add(billsdataGridView);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(datelbl);
            panel1.Controls.Add(sellinggridview1);
            panel1.Controls.Add(productid);
            panel1.Controls.Add(productqty);
            panel1.Controls.Add(productpice);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(editbtn);
            panel1.Controls.Add(addbtn);
            panel1.Controls.Add(productcategory);
            panel1.Controls.Add(productname);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(152, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 542);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // sellernamelbl
            // 
            sellernamelbl.AutoSize = true;
            sellernamelbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            sellernamelbl.ForeColor = Color.White;
            sellernamelbl.Location = new Point(22, 13);
            sellernamelbl.Name = "sellernamelbl";
            sellernamelbl.Size = new Size(108, 32);
            sellernamelbl.TabIndex = 32;
            sellernamelbl.Text = "SELLING";
            sellernamelbl.Click += sellernamelbl_Click;
            // 
            // PrintPreviewDialog1
            // 
            PrintPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            PrintPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            PrintPreviewDialog1.ClientSize = new Size(400, 300);
            PrintPreviewDialog1.Document = printDocument1;
            PrintPreviewDialog1.Enabled = true;
            PrintPreviewDialog1.Icon = (Icon)resources.GetObject("PrintPreviewDialog1.Icon");
            PrintPreviewDialog1.Name = "printPreviewDialog1";
            PrintPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // logoutlb
            // 
            logoutlb.AutoSize = true;
            logoutlb.BackColor = Color.Transparent;
            logoutlb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logoutlb.ForeColor = Color.DarkOrange;
            logoutlb.Location = new Point(38, 547);
            logoutlb.Name = "logoutlb";
            logoutlb.Size = new Size(78, 28);
            logoutlb.TabIndex = 32;
            logoutlb.Text = "Logout";
            logoutlb.Click += logoutlb_Click;
            // 
            // sellingform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(logoutlb);
            Controls.Add(closebtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sellingform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sellingform";
            Load += sellingform_Load;
            ((System.ComponentModel.ISupportInitialize)productpice).EndInit();
            ((System.ComponentModel.ISupportInitialize)productqty).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellinggridview1).EndInit();
            ((System.ComponentModel.ISupportInitialize)billsdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderdataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closebtn;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox productname;
        private ComboBox productcategory;
        private Button addbtn;
        private Button editbtn;
        private Button button1;
        private NumericUpDown productpice;
        private NumericUpDown productqty;
        private TextBox productid;
        private DataGridView sellinggridview1;
        private Label datelbl;
        private Button button2;
        private DataGridView billsdataGridView;
        private DataGridView orderdataGridView;
        private Label label9;
        private Label amtlbl;
        private Label label11;
        private Panel panel1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn total;
        private PrintPreviewDialog PrintPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label logoutlb;
        private Label sellernamelbl;
    }
}