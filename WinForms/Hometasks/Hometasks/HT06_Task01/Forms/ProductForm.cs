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
    public partial class ProductForm : Form
    {
        public Product product { get; set; }
        public ProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            if (!String.IsNullOrEmpty(product.Image))
                ProductImage.Image = Image.FromFile(product.Image);
            NameLabel.Text = product.Name;
            PriceLabel.Text = product.Price.ToString("#.##");
        }


    }
}
