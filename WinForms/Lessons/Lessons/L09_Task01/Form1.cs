using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L09_Task01
{
    public partial class Form1 : Form
    {
        List<User> listUsers;
        public Form1()
        {
            InitializeComponent();
            listUsers = new List<User>();
            listUsers.Add(new User()
            {
                Name = "Andrii",
                Phone = "0976744955"
            });

            listUsers.Add(new User()
            {
                Name = "Vlad",
                Phone = "0934343435"
            });

            listUsers.Add(new User()
            {
                Name = "Oksana",
                Phone = "0343434355"
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tableUsers.Rows.Clear();
            foreach (User item in listUsers)
            {
                object[] obj = { item.Name, item.Phone };
                this.tableUsers.Rows.Add(obj);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            var res = listUsers.Where(user => user.Name.Equals(FindTextBox.Text) || user.Phone.Equals(FindTextBox.Text));
            this.tableUsers.Rows.Clear();
            foreach (User item in res)
            {
                object[] obj = { item.Name, item.Phone };
                this.tableUsers.Rows.Add(obj);
            }
        }
    }
}
