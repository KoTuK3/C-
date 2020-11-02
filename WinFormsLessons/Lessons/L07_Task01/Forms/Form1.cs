using L07_Task01.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L07_Task01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ProductList.Items.Add(new Product { Name = "Name1", Price = 5.6662 });
            ProductList.Items.Add(new Product { Name = "Name2", Price = 5.6422 });
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            if (createProductForm.ShowDialog() == DialogResult.OK)
            {
                ProductList.Items.Add(createProductForm.Product);
            }
        }

        private void ShowProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductList.SelectedItem is Product)
            {
                Product prod = ProductList.SelectedItem as Product;
                ProductForm productForm = new ProductForm(prod);
                if (productForm.ShowDialog() == DialogResult.OK) ;
            }
        }
    }
}
