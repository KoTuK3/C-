using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L05_Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AboutMeTextBox.Text = "Text\n\n\n\n\n text";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Contact info
            ContactEmailBox.Text = EmailBox.Text;
            ContactPhoneBox.Text = PhoneBox.Text;

            // Background color
            int red = SliderRed.Value;
            int green = SliderGreen.Value;
            int blue = SliderBlue.Value;
            
            for (int i = 0; i < Tabs.TabPages.Count; i++)
            {
                Tabs.TabPages[i].BackColor = Color.FromArgb(red, green, blue);
            }



        }
    }
}
