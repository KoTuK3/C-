using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L04_Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (StreamReader streamReader = new StreamReader("Properties.json"))
            {
                string json = streamReader.ReadToEnd();
                var obj = JsonConvert.DeserializeObject(json);
            }

            PositionCB.Items.AddRange(new[] { 
                "Manager",
                "Junior",
                "Middle",
                "Senior",
                "TeamLead"                
            });

            CityCB.Items.AddRange(new[] { 
                "Rivne",
                "Kyiv",
                "Kharkiv",
                "Lviv"
            });

            StreetCB.Items.AddRange(new[] {
                "Kreshhatik",
                "Soborna",
                "Prospekt-Svoboody",
            });

            List<Worker> db;
            using (StreamReader streamReader = new StreamReader("Workers.json"))
            {
                string json = streamReader.ReadToEnd();
                db = JsonConvert.DeserializeObject<List<Worker>>(json);
            }

            if (db != null)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    WorkersList.Items.Add(db[i]);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (NameTextBox.Text == null || NameTextBox.Text.Length == 0)
                ErrorMessage += "Empty name field.\n";

            if (SalaryTextBox.Text == null || SalaryTextBox.Text.Length == 0)
                ErrorMessage += "Empty salary field.\n";

            double salary;
            if (!double.TryParse(SalaryTextBox.Text, out salary) || salary < 0)
                ErrorMessage += "Incorrect salary.\n";

            if (PositionCB.Text == null || PositionCB.Text.Length == 0)
                ErrorMessage += "Empty position field.\n";

            if (CityCB.Text == null || CityCB.Text.Length == 0)
                ErrorMessage += "Empty city field.\n";

            if (StreetCB.Text == null || StreetCB.Text.Length == 0)
                ErrorMessage += "Empty street field.\n";

            if (ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage);
                return;
            }

            if (!PositionCB.Items.Contains(PositionCB.Text))
            {
                PositionCB.Items.Add(PositionCB.Text);
            }
            if (!CityCB.Items.Contains(CityCB.Text))
            {
                CityCB.Items.Add(CityCB.Text);
            }
            if (!StreetCB.Items.Contains(StreetCB.Text))
            {
                StreetCB.Items.Add(StreetCB.Text);
            }

            WorkersList.Items.Add(new Worker
            {
                Name = NameTextBox.Text,
                Salary = salary,
                Position = PositionCB.Text,
                City = CityCB.Text,
                Street = StreetCB.Text
            });

        }
       

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter("Workers.json"))
            {
                string json = JsonConvert.SerializeObject(WorkersList.Items);
                streamWriter.WriteLine(json);
            }

            using (StreamWriter streamWriter1 = new StreamWriter("Properties.json"))
            {
                string res = JsonConvert.SerializeObject(new
                {
                    Position = PositionCB.Items,
                    City = CityCB.Items,
                    Street = StreetCB.Items
                });

                streamWriter1.WriteLine(res);
            }
        }
    }
}
