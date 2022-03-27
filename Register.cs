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
        string gender_Fetch = "";
        string agreedToS = "";
        string agreedToS_Fetch = "";
        string startDate = "";
        int id;
        

        public Register()
        {
            InitializeComponent();
            buttonRegister.Enabled = false;
            con = new SqlConnection(path);
            display();

            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

       

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            if (textBoxFirstname.Text == "" || textBoxLastName.Text == "" || textBoxSector.Text == "" || textBoxEmail.Text == "" || textBoxAddress.Text == "" || textBoxNote.Text == "" || (radioButtonMale.Checked == false && radioButtonFemale.Checked == false && radioButtonOther.Checked == false))
            {
                MessageBox.Show("Field cannot be empty!");
            }
            else
            {
                try
                {

                    startDate = monthCalendarRegister.SelectionRange.Start.ToShortDateString();
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
                    cmd = new SqlCommand("insert into Employee (employee_first_name, employee_last_name, employee_sector, employee_email, employee_address, employee_gender, employee_ToS, employee_note, start_date) values ('" + textBoxFirstname.Text + "', '" + textBoxLastName.Text + "', '" + textBoxSector.Text + "', '" + textBoxEmail.Text + "', '" + textBoxAddress.Text + "', '" + gender + "', '" + agreedToS + "', '" + textBoxNote.Text + "', '" + startDate + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successful data entry!");
                    clear();
                    display();
                }
                catch (Exception e_database)
                {
                    MessageBox.Show(e_database.Message);
                }
            }
           
        }

        public void clear()
        {
            textBoxFirstname.Text = "";
            textBoxLastName.Text = "";
            textBoxSector.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonOther.Checked = false;
            textBoxID.Text = "";
            checkBoxToSAgreed.Checked = false;
            textBoxNote.Text = "";
        }

        public void display()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from Employee", con);
                adpt.Fill(dt);
                dataGridViewRegister.DataSource = dt;
                con.Close();
            }
            catch (Exception e_Display)
            {
                MessageBox.Show(e_Display.Message);
            }
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

        private void Register_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void dataGridViewRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridViewRegister.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxID.Text = id.ToString();
            textBoxFirstname.Text = dataGridViewRegister.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewRegister.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSector.Text = dataGridViewRegister.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewRegister.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewRegister.Rows[e.RowIndex].Cells[5].Value.ToString();
            gender_Fetch = dataGridViewRegister.Rows[e.RowIndex].Cells[6].Value.ToString();

            if (gender_Fetch == "Male")
            {
                radioButtonMale.Checked = true;
            } else if (gender_Fetch == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonOther.Checked = true;
            }

            agreedToS_Fetch = dataGridViewRegister.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (agreedToS_Fetch == "Agreed")
            {
                checkBoxToSAgreed.Checked = true;
            }
            textBoxNote.Text = dataGridViewRegister.Rows[e.RowIndex].Cells[8].Value.ToString();
            startDate = dataGridViewRegister.Rows[e.RowIndex].Cells[9].Value.ToString();
            labelDataStartDate.Text = startDate;

            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                startDate = monthCalendarRegister.SelectionRange.Start.ToShortDateString();
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
                cmd = new SqlCommand("update Employee set employee_first_name = '"+textBoxFirstname.Text+ "', employee_last_name = '" + textBoxLastName.Text + "', employee_sector = '" + textBoxSector.Text + "', employee_email = '" + textBoxEmail.Text + "', employee_address = '" + textBoxAddress.Text + "', employee_gender = '" + gender + "', employee_ToS = '" + agreedToS + "', employee_note = '" + textBoxNote.Text + "', start_date = '" + startDate + "' where employee_id = '"+id+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Data successfuly updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("delete from Employee where employee_id = '" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Data was successfuly deleted!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }
    }
}
