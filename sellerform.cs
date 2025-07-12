using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket_Management_System
{
    public partial class sellerform : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        public sellerform()
        {
            InitializeComponent();
        }

        private void loadsqlData()
        {
            Con.Open();

            String query = "select * from SellerTable";
            SqlDataAdapter ctgsda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder ctgcmdbld = new SqlCommandBuilder(ctgsda);
            var ctgds = new DataSet();
            ctgsda.Fill(ctgds);
            sellergridview.DataSource = ctgds.Tables[0];

            Con.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sellerform_Load(object sender, EventArgs e)
        {
            loadsqlData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            sellerid.Text = sellergridview.SelectedRows[0].Cells[0].Value.ToString();
            sellername.Text = sellergridview.SelectedRows[0].Cells[1].Value.ToString();
            sellerage.Text = sellergridview.SelectedRows[0].Cells[2].Value.ToString();
            sellerphone.Text = sellergridview.SelectedRows[0].Cells[3].Value.ToString();
            sellerpassword.Text = sellergridview.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            if (sellerid.Text == "" || sellername.Text == "" || sellerphone.Text == "" || sellerpassword.Text == "")
            {
                MessageBox.Show("Insert all fields");
            }
            else
            {
                try
                {
                    Con.Open();

                    String query = "insert into SellerTable values(" + sellerid.Text + " , '" + sellername.Text + "','" + sellerage.Text + "','" + sellerphone.Text + "','" + sellerpassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                    Con.Close();
                    loadsqlData();
                    sellerid.Text = "";
                    sellerage.Text = "";
                    sellername.Text = "";
                    sellerphone.Text = "";
                    sellerpassword.Text = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }

            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {


            if (sellerid.Text == "" || sellername.Text == "" || sellerage.Text == "" || sellerphone.Text == "" || sellerpassword.Text == "")
            {
                MessageBox.Show("Please fil all fields");
            }
            else
            {
                try
                {

                    Con.Open();
                    String query = "UPDATE SellerTable SET SellerName = '" + sellerid.Text + "', SellerAge = '" + sellerage.Text + "', SellerPhone = '" + sellerphone.Text + "', SellerPassword = '" + sellerpassword.Text + "' WHERE SellerId = " + sellerid.Text + ";"
; SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Id " + sellerid.Text + " is Edited successfully");
                    Con.Close();
                    loadsqlData();
                    sellerid.Text = "";
                    sellerage.Text = "";
                    sellername.Text = "";
                    sellerphone.Text = "";
                    sellerpassword.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }



            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerid.Text == "")
                {
                    MessageBox.Show("Please select Category Id to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from SellerTable where SellerId=" + sellerid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Id " + sellerid.Text + " is deleted successfully");
                    Con.Close();
                    loadsqlData();
                    sellerid.Text = "";
                    sellerage.Text = "";
                    sellername.Text = "";
                    sellerphone.Text = "";
                    sellerpassword.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void sellerbtn_Click(object sender, EventArgs e)
        {
            productform proform = new productform();
            proform.Show();
            this.Hide();
        }

        private void catgbtn_Click(object sender, EventArgs e)
        {
            categoryform ctgform = new categoryform();
            ctgform.Show();
            this.Hide();
        }

        private void logoutlb_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
