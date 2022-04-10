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

namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        string path = "Data Source =DESKTOP-OR9TV6T;Initial Catalog=employeeManagementSystem;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void clear()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
                {
                    MessageBox.Show("Please enter your username and password.");
                }
                else
                {
                    cmd = new SqlCommand("select * from Employee where employee_username = '" + textBoxUsername.Text + "' and employee_password = '" + textBoxPassword.Text + "'", con);
                   
                    adpt = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Successful log in.");
                        this.Hide();
                        controlPanel ob = new controlPanel();
                        ob.Show();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password. If you have forgotton your credentials, contact your administrator.");
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
