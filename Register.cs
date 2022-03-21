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
    public partial class Register : Form
    {
        string path = "Data Source =DESKTOP-OR9TV6T;Initial Catalog=employeeManagementSystem;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        string gender = "";
        string agreedToS = "";

        public Register()
        {
            InitializeComponent();
            buttonRegister.Enabled = false;
            con = new SqlConnection(path);
        }

       

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            if (textBoxFirstname.Text == "" || textBoxLastName.Text == "" || textBoxSector.Text == "" || textBoxEmail.Text == "" || textBoxAddress.Text == "" || textBoxNote.Text == "")
            {

            }
            else
            {
                try
                {

                    if (radioButtonMale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (radioButtonFemale.Checked)
                    {
                        gender = "Female";
                    }
                    else if (radioButtonOther.Checked)
                    {
                        gender = "Other";
                    }

                    con.Open();
                    cmd = new SqlCommand("insert into Employee (employee_first_name, employee_last_name, employee_sector, employee_email, employee_address, employee_gender, employee_ToS, employee_note) values ('" + textBoxFirstname.Text + "', '" + textBoxLastName.Text + "', '" + textBoxSector.Text + "', '" + textBoxEmail.Text + "', '" + textBoxAddress.Text + "', '" + gender + "', '" + agreedToS + "', '" + textBoxNote.Text + "')", con);

                }
                catch (Exception e_database)
                {
                    MessageBox.Show(e_database.Message);
                }
            }
           
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if (checkBoxToSAgreed.Checked && (radioButtonMale.Checked == true || radioButtonFemale.Checked == true || radioButtonOther.Checked == true))
            {
                buttonRegister.Enabled = true;
                agreedToS = "Agreed";
            }
            else
            {
                buttonRegister.Enabled = false;
            }
        }
    }
}
