using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L07_Task01.Forms
{
    public partial class CreateProductForm : Form
    {
        public string ImagePath { get; set; }
        public Product Product { get; set; }
        public CreateProductForm()
        {
            InitializeComponent();
            Product = new Product();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"; 
            openFileDialog1.InitialDirectory = @"D:\Step\CSharp\WinFormsLessons\Lessons\L07_Task01\Images\";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            double price;
            if (string.IsNullOrEmpty(NameTextBox.Text) || 
                !double.TryParse(PriceTextBox.Text, out price) ||
                price < 0)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                Product.Name = NameTextBox.Text;
                Product.Price = price;
                DialogResult = DialogResult.OK;
            }
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            Product.Image = openFileDialog1.FileName;
        }
    }
}
