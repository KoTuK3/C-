using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT01_Task04
{
    public partial class Form1 : Form
    {
        int current = 0;
        Color[] rainbow = new Color[]
        {
            Color.FromArgb(255, 0, 0),
            Color.FromArgb(255, 255, 0),
            Color.FromArgb(0, 255, 0),
            Color.FromArgb(0, 255, 255),
            Color.FromArgb(0, 0, 255),
            Color.FromArgb(255, 0, 255)
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            current += 1;
            if (current >= rainbow.Length)
                current = 0;
            Form1.ActiveForm.BackColor = rainbow[current];

        }
    }
}
