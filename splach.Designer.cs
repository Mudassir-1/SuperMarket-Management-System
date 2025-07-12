namespace SuperMarket_Management_System
{
    partial class splach
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shopping_cart;
            pictureBox1.Location = new Point(168, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Gray;
            progressBar1.Location = new Point(-11, 208);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(528, 14);
            progressBar1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(194, 39);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 9;
            label2.Text = "Version 1.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 0);
            label1.Name = "label1";
            label1.Size = new Size(397, 41);
            label1.TabIndex = 8;
            label1.Text = "SuperMarket Management";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // splach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(506, 222);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "splach";
            Load += splach_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}