namespace SuperMarket_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            clearbtn = new Label();
            loginbtn = new Button();
            passwordtxt = new TextBox();
            usernametxt = new TextBox();
            closeapp = new Label();
            userrole = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 413);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 207);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 11;
            label7.Text = "APPLICATION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1, 173);
            label6.Name = "label6";
            label6.Size = new Size(155, 28);
            label6.TabIndex = 10;
            label6.Text = "SUPERMARKET";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 138);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 9;
            label5.Text = "WELCOME TO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(178, 206);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 23;
            label4.Text = "USERNAME";
            // 
            // clearbtn
            // 
            clearbtn.AutoSize = true;
            clearbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearbtn.ForeColor = Color.DarkOrange;
            clearbtn.Location = new Point(346, 364);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(56, 28);
            clearbtn.TabIndex = 22;
            clearbtn.Text = "Clear";
            clearbtn.Click += clearbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.DarkOrange;
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(282, 323);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(196, 38);
            loginbtn.TabIndex = 21;
            loginbtn.Text = "LOGIN";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.ForeColor = Color.DarkOrange;
            passwordtxt.Location = new Point(306, 261);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(213, 27);
            passwordtxt.TabIndex = 20;
            // 
            // usernametxt
            // 
            usernametxt.ForeColor = Color.DarkOrange;
            usernametxt.Location = new Point(306, 206);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(213, 27);
            usernametxt.TabIndex = 19;
            // 
            // closeapp
            // 
            closeapp.AutoSize = true;
            closeapp.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeapp.ForeColor = Color.DarkOrange;
            closeapp.Location = new Point(487, 19);
            closeapp.Name = "closeapp";
            closeapp.Size = new Size(32, 38);
            closeapp.TabIndex = 18;
            closeapp.Text = "x";
            closeapp.Click += closeapp_Click;
            // 
            // userrole
            // 
            userrole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userrole.ForeColor = Color.DarkOrange;
            userrole.FormattingEnabled = true;
            userrole.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            userrole.Location = new Point(305, 150);
            userrole.Name = "userrole";
            userrole.Size = new Size(214, 36);
            userrole.TabIndex = 17;
            userrole.Text = "Select Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(179, 261);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 16;
            label3.Text = "PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(329, 78);
            label1.Name = "label1";
            label1.Size = new Size(102, 38);
            label1.TabIndex = 15;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 411);
            Controls.Add(label4);
            Controls.Add(clearbtn);
            Controls.Add(loginbtn);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(closeapp);
            Controls.Add(userrole);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label clearbtn;
        private Button loginbtn;
        private TextBox passwordtxt;
        private TextBox usernametxt;
        private Label closeapp;
        private ComboBox userrole;
        private Label label3;
        private Label label1;
    }
}
