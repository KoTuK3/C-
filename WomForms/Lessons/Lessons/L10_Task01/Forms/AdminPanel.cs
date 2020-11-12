using L10_Task01.Model;
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

namespace L10_Task01.Forms
{
    public partial class AdminPanel : Form
    {
        private List<Run> runs = new List<Run>();
        public AdminPanel()
        {
            InitializeComponent();
            ArrivalTimePicker.Format = DateTimePickerFormat.Custom;
            ArrivalTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            DepartureTimePicker.Format = DateTimePickerFormat.Custom;
            DepartureTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            using (StreamReader streamReader = new StreamReader(@"D:\Step\CSharp\WinFormsLessons\Lessons\L10_Task01\Resource\runs.json"))
            {
                var json = streamReader.ReadToEnd();
                if (!string.IsNullOrEmpty(json))
                {
                    runs = JsonConvert.DeserializeObject<List<Run>>(json);
                }
            }
            foreach (var item in runs)
            {
                ScheduleTable.Rows.Add(item.Name, item.ArrivalTime.ToString(), item.DepartureTime.ToString(), "X");
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var run = new Run();
            run.Name = NameTextBox.Text;
            run.ArrivalTime = ArrivalTimePicker.Value;
            run.DepartureTime = DepartureTimePicker.Value;

            if (string.IsNullOrEmpty(run.Name))
            {
                MessageBox.Show("Empty name field.");
                return;
            }

            if (run.ArrivalTime >= run.DepartureTime)
            {
                MessageBox.Show("Incorrect date.");
                return;
            }


            ScheduleTable.Rows.Add(run.Name, run.ArrivalTime.ToString(), run.DepartureTime.ToString(), "X");

            runs.Add(run);

            using (StreamWriter streamWriter = new StreamWriter(@"D:\Step\CSharp\WinFormsLessons\Lessons\L10_Task01\Resource\runs.json"))
            {
                var json = JsonConvert.SerializeObject(runs);
                streamWriter.WriteLine(json);
            }
        }

        private void ScheduleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (runs == null || runs.Count == 0)
                return;

            runs.RemoveAt(e.RowIndex);
            ScheduleTable.Rows.RemoveAt(e.RowIndex);

            using (StreamWriter streamWriter = new StreamWriter(@"D:\Step\CSharp\WinFormsLessons\Lessons\L10_Task01\Resource\runs.json"))
            {
                var json = JsonConvert.SerializeObject(runs);
                streamWriter.WriteLine(json);
            }
        }
    }
}
