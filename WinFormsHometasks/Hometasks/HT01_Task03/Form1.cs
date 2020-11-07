using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT01_Task03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Opacity += 0.05;
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            if (ActiveForm.Opacity > 0.1)
                ActiveForm.Opacity -= 0.05;

        }
    }
}
