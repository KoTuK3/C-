using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L02_Task01
{
    public partial class Form1 : Form
    {
        Icon icon = null;
        int minSize = 0;
        int maxSize = 0;
        int sizeStep = 16;

        int currentSize;
        int currentStep;

        int minStep = 5;
        int maxStep = 20;

        int x = 0;
        int y = 0;

        string path = "bird.ico";

        public Form1()
        {
            minSize = this.Size.Width / 5;
            maxSize = minSize * 5;
            currentSize = minSize;
            currentStep = minStep;
            icon = new Icon(path, currentSize, currentSize);
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
                currentStep = maxStep;
            else
                currentStep = minStep;

            switch (e.KeyCode)
            {
                case Keys.D0: case Keys.NumPad0:
                    x = y = 0;
                    break;

                case Keys.D1: case Keys.NumPad1:
                    x = this.Size.Width - currentSize;
                    y = this.Size.Height - currentSize;
                    break;

                case Keys.W: case Keys.Up:
                    y -= currentStep;
                    break;

                case Keys.A: case Keys.Left:
                    x -= currentStep;
                    break;

                case Keys.S: case Keys.Down:
                     y += currentStep;
                   break;

                case Keys.D: case Keys.Right:
                    x += currentStep;
                    break;

                case Keys.Add:
                    if (currentSize + sizeStep <= maxSize)
                    currentSize += sizeStep;
                    break;

                case Keys.Subtract:
                    if (currentSize - sizeStep >= minSize)
                        currentSize -= sizeStep;
                    break;
            }

            if (x >= this.Size.Width)
                x = 0;
            if (x <= -currentSize)
                x = this.Size.Width - currentSize;

            if (y >= this.Size.Height)
                y = 0;
            if (y <= -currentSize)
                y = this.Size.Height - currentSize;

            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(icon, new Rectangle(x, y, currentSize, currentSize));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            minSize = this.Size.Width / 5;
            currentSize = minSize;
            this.Refresh();
        }
    }
}
