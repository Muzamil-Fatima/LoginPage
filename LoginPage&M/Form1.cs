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

namespace LoginPage_M
{
    public partial class Form1 : Form
    {
        SqlConnection  conn = new SqlConnection("Data Source=system Name; Initial Catalog=University; Integrated Security=true ");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name, password;
            name = txtUserName.Text;
            password = txtUserPassword.Text;
            try
            {
                String query = "select * from tblLoginPage where UserName= '" + txtUserName.Text + "' and UserPassword='" + txtUserPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);
                if (dTable.Rows.Count>0)
                {
                    name= txtUserName.Text; 
                    password= txtUserPassword.Text;
                    MessageBox.Show("Login Successfully");
                }
                else
                {
                    MessageBox.Show("Please enter the correct password or username ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
              conn.Close(); 
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            this.Hide();
        }
    }
}
