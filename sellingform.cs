using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Management_System
{
    public partial class sellingform : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        public sellingform()
        {
            InitializeComponent();
        }

        private void loadsqlData()
        {
            Con.Open();

            String query = "select ProductName,ProductQty from ProductTable";
            SqlDataAdapter ctgsda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder ctgcmdbld = new SqlCommandBuilder(ctgsda);
            var ctgds = new DataSet();
            ctgsda.Fill(ctgds);
            sellinggridview1.DataSource = ctgds.Tables[0];

            Con.Close();
        }
        private void loadbillData()
        {
            Con.Open();

            String query = "select * from BillTable";
            SqlDataAdapter ctgsda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder ctgcmdbld = new SqlCommandBuilder(ctgsda);
            var ctgds = new DataSet();
            ctgsda.Fill(ctgds);
            billsdataGridView.DataSource = ctgds.Tables[0];

            Con.Close();
        }

        private void sellingform_Load(object sender, EventArgs e)
        {
            loadsqlData();
            loadbillData();
            combofill();
            sellernamelbl.Text = Form1.sellername;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sellinggridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productname.Text = sellinggridview1.SelectedRows[0].Cells[0].Value.ToString();
            productpice.Text = sellinggridview1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void productdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int grdtotal = 0, n = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (productname.Text == "" && productqty.Text == "0")
            {

                MessageBox.Show("Quantity Should be greater then 0");

            }
            else
            {
                int total = Convert.ToInt32(productpice.Text) * Convert.ToInt32(productqty.Text);

                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(orderdataGridView);
                newrow.Cells[0].Value = n + 1;
                newrow.Cells[1].Value = productname.Text;
                newrow.Cells[2].Value = productpice.Text;
                newrow.Cells[3].Value = productqty.Text;
                newrow.Cells[4].Value = Convert.ToInt32(productpice.Text) * Convert.ToInt32(productqty.Text);
                orderdataGridView.Rows.Add(newrow);
                n++;
                grdtotal = grdtotal + total;
                amtlbl.Text = "" + grdtotal;

            }






        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (productid.Text == "")
            {
                MessageBox.Show("Enter Bill Id");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "INSERT INTO BillTable VALUES(" + productid.Text + ", '" + sellernamelbl.Text + "', '" + datelbl.Text + "', " + amtlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Con.Close();
                    loadbillData();
                    productid.Text = "";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void billsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void amtlbl_Click(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (PrintPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

                printDocument1.Print();

            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FAMILYSUPERMARKET", new Font("Century Gothi", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill Id: " + billsdataGridView.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothi", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + billsdataGridView.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothi", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Date: " + billsdataGridView.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothi", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Total Amount: " + billsdataGridView.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothi", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 190));
            e.Graphics.DrawString("Thank You!", new Font("Century Gothi", 20, FontStyle.Italic), Brushes.Red, new Point(270, 230));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadsqlData();
        }

        private void productcategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();

            String query = "select ProductName,ProductQty from ProductTable where Productctg='" + productcategory.SelectedValue.ToString() + "'";
            SqlDataAdapter ctgsda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder ctgcmdbld = new SqlCommandBuilder(ctgsda);
            var ctgds = new DataSet();
            ctgsda.Fill(ctgds);
            sellinggridview1.DataSource = ctgds.Tables[0];

            Con.Close();
        }

        private void combofill()
        {
            Con.Open();
            String query = "select CategoryName from CategoryTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(String));
            dt.Load(sdr);
            productcategory.ValueMember = "CategoryName";
            productcategory.DataSource = dt;
            Con.Close();

        }

        private void productcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logoutlb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void sellernamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
