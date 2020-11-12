using L10_Task01.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L10_Task01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            var loginPanel = new Login();
            loginPanel.ShowDialog();
            if (loginPanel.DialogResult == DialogResult.OK)
            {
                loginPanel.Close();
                var adminPanel = new Forms.AdminPanel();
                adminPanel.ShowDialog();


            }
            else
            {
                MessageBox.Show("Incorrect password.");
            }
        }

        private void TableBtn_Click(object sender, EventArgs e)
        {
            var table = new Table();
            table.ShowDialog();            
        }
    }
}
