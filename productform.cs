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
    public partial class productform : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        // to fill combo with data of database
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

        private void loadsqlData()
        {
            Con.Open();

            String query = "select * from ProductTable";
            SqlDataAdapter ctgsda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder ctgcmdbld = new SqlCommandBuilder(ctgsda);
            var ctgds = new DataSet();
            ctgsda.Fill(ctgds);
            productdataGridView.DataSource = ctgds.Tables[0];

            Con.Close();
        }

        public productform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sellerform selfomr = new sellerform();
            selfomr.Show();
            this.Hide();
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productid.Text == "")
                {
                    MessageBox.Show("Please select Category Id to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from ProductTable where ProductId=" + productid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Id " + productid.Text + " is deleted successfully");
                    Con.Close();
                    loadsqlData();
                    productid.Text = "";
                    productname.Text = "";
                    productqty.Text = "";
                    productpice.Text = "";
                    productcategory.SelectedValue = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (productid.Text == "" && productname.Text == "" && productcategory.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Insert all fields");
            }
            else
            {
                try
                {
                    Con.Open();

                    String query = "insert into ProductTable values(" + productid.Text + " , '" + productname.Text + "','" + productqty.Text + "','" + productpice.Text + "','" + productcategory.SelectedValue.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                    Con.Close();
                    loadsqlData();
                    productid.Text = "";
                    productname.Text = "";
                    productqty.Text = "";
                    productpice.Text = "";
                    productcategory.SelectedValue = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void productform_Load(object sender, EventArgs e)
        {
            combofill();
            loadsqlData();

        }

        private void catgbtn_Click(object sender, EventArgs e)
        {
            categoryform ctg = new categoryform();
            ctg.Show();
            this.Hide();
        }

        private void productdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productid.Text = productdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            productname.Text = productdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            productqty.Text = productdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            productpice.Text = productdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            productcategory.Text = productdataGridView.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (productid.Text == "" || productname.Text == "" || productcategory.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please fil all fields");
            }
            else
            {
                try
                {

                    Con.Open();
                    String query = "UPDATE ProductTable SET ProductName = '" + productname.Text + "', ProductQty = '" + productqty.Text + "', ProductPrice = '" + productpice.Text + "', ProductCtg = '" + productcategory.SelectedValue.ToString() + "' WHERE ProductId = " + productid.Text + ";"
; SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Id " + productid.Text + " is Edited successfully");
                    Con.Close();
                    loadsqlData();
                    productid.Text = "";
                    productname.Text = "";
                    productqty.Text = "";
                    productpice.Text = "";
                    productcategory.SelectedValue = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            loadsqlData();


        }

        private void logoutlb_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
