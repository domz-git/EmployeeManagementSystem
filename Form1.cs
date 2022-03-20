using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class controlPanel : Form

    {
        Register rg = new Register();
        public controlPanel()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try{
                rg.Show();
            }
            catch(Exception ea)
            {
                MessageBox.Show("Error");
            }
            
        }
    }
}
