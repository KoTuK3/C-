using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L03_Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTimePicker.MinDate = DateTime.Now;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            ToDo todo = new ToDo();
            if (NameTextBox.Text == null || NameTextBox.Text == "")
            {
                MessageBox.Show("Name field is empty");
                return;
            }
            else
            {
                todo.Name = NameTextBox.Text;
            }

            todo.Place = PlaceTextBox.Text;
            todo.Priority = PriorityTextBox.Text;

            todo.Date = DateTimePicker.Value;

            ToDosListBox.Items.Add(todo);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ToDosListBox.Items.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var name = DateTime.Now.ToString("ddMMyyyy'_'HHmmss'_'FFF");
            using (StreamWriter file = File.CreateText($"{name}.json"))
            {
                var json = JsonConvert.SerializeObject(ToDosListBox.Items);
                file.WriteLine(json);
            }
        }
    }
}
