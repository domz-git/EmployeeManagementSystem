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

        public Register()
        {
            InitializeComponent();
            buttonRegister.Enabled = false;
            con = new SqlConnection(path);
        }

        string agreedToS = "";
        private void buttonRegister_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBoxToSAgreed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxToSAgreed.Checked)
            {
                buttonRegister.Enabled = true;
                agreedToS = "Agreed";
            }
            else
            {
                buttonRegister.Enabled = false;
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
