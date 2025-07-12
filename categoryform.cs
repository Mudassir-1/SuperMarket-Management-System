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
using System.Collections;

namespace SuperMarket_Management_System
{
    public partial class categoryform : Form
    {
        public categoryform()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void categoryform_Load(object sender, EventArgs e)
        {
            loadsqlData();

        }

        private void ctgaddbtn_Click(object sender, EventArgs e)
        {
            if (ctgnametxt.Text == "" && ctgdestxt.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {

                try
                {
                    Con.Open();

                    String query = "insert into CategoryTable values(" + ctgidtxt.Text + " , '" + ctgnametxt.Text + "','" + ctgdestxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                    Con.Close();
                    loadsqlData();
                    ctgidtxt.Text = "";
                    ctgnametxt.Text = "";
                    ctgdestxt.Text = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }

            }

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadsqlData()
        {
            Con.Open();

            String query = "select * from CategoryTable";
            SqlDataAdapter ctgsda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder ctgcmdbld = new SqlCommandBuilder(ctgsda);
            var ctgds = new DataSet();
            ctgsda.Fill(ctgds);
            CtgdataGrid.DataSource = ctgds.Tables[0];

            Con.Close();
        }

        private void CtgdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ctgidtxt.Text = CtgdataGrid.SelectedRows[0].Cells[0].Value.ToString();
            ctgnametxt.Text = CtgdataGrid.SelectedRows[0].Cells[1].Value.ToString();
            ctgdestxt.Text = CtgdataGrid.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void ctgidtxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ctgdeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctgidtxt.Text == "")
                {
                    MessageBox.Show("Please select Category Id to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from CategoryTable where CategoryId=" + ctgidtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Id " + ctgidtxt.Text + " is deleted successfully");
                    Con.Close();
                    loadsqlData();
                    ctgidtxt.Text = "";
                    ctgnametxt.Text = "";
                    ctgdestxt.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void ctgidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctgeditbtn_Click(object sender, EventArgs e)
        {
            if (ctgidtxt.Text == "" && ctgnametxt.Text == "" && ctgdestxt.Text == "")
            {
                MessageBox.Show("Please fil all fields");
            }
            else
            {
                try
                {

                    Con.Open();
                    String query = "update CategoryTable set CategoryName='" + ctgnametxt.Text + "', Categorydesc='" + ctgdestxt.Text + "' where CategoryId=" + ctgidtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Id " + ctgidtxt.Text + " is Edited successfully");
                    Con.Close();
                    loadsqlData();
                    ctgidtxt.Text = "";
                    ctgnametxt.Text = "";
                    ctgdestxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void catgbtn_Click(object sender, EventArgs e)
        {
            productform pro = new productform();
            pro.Show();
            this.Hide();
        }

        private void sellerbtn_Click(object sender, EventArgs e)
        {
            sellerform selform = new sellerform();
            selform.Show();
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
