using System.Data;
using System.Data.SqlClient;

namespace SuperMarket_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sellername = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void closeapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Text = "";
            passwordtxt.Text = "";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(usernametxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                if (userrole.SelectedIndex >= 0)
                {
                    if (userrole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (usernametxt.Text == "Admin" && passwordtxt.Text == "Admin")
                        {
                            productform prod = new productform();
                            prod.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Enter your correct credientials");
                        }
                    }
                    else
                    {
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTable where SellerName='"+usernametxt.Text+"' and SellerPassword='"+passwordtxt.Text+"'",Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            sellername = usernametxt.Text;
                            sellingform selform  = new sellingform();
                            selform.Show();
                            this.Hide();
                            Con.Close();

                        }
                        else
                        {
                            MessageBox.Show("Wron username or password");
                        }

                        Con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Select Role");
                }
            }
        }
    }
}
