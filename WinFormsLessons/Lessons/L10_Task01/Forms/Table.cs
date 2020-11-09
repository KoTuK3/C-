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
    public partial class Table : Form
    {
        private List<Run> runs;
        public Table()
        {
            InitializeComponent();
            using (StreamReader streamReader = new StreamReader(@"D:\Step\CSharp\WinFormsLessons\Lessons\L10_Task01\Resource\runs.json"))
            {
                var json = streamReader.ReadToEnd();
                if (!string.IsNullOrEmpty(json))
                {
                    runs = JsonConvert.DeserializeObject<List<Run>>(json);
                }
            }

            Timer timer = new Timer();
            timer.Interval = (60 * 1000);
            timer.Tick += new EventHandler(PrintTable);
            timer.Start();
        }

        public void PrintTable(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            var currentDate = DateTime.Now;
            int counter = 0;
            for (int i = 0; i < runs.Count; i++)
            {
                if (currentDate.AddMinutes(3) > runs[i].DepartureTime)
                {
                    counter += 1;
                    continue;
                }

                ScheduleTable.Rows.Add(runs[i].Name, runs[i].ArrivalTime.ToString(), runs[i].DepartureTime.ToString());
                if (runs[i].ArrivalTime > currentDate && runs[i].ArrivalTime < currentDate.AddMinutes(1))
                    ScheduleTable.Rows[i - counter].DefaultCellStyle.BackColor = Color.Green;

                if (runs[i].DepartureTime > currentDate.AddMinutes(-1) && runs[i].DepartureTime < currentDate)
                    ScheduleTable.Rows[i - counter].DefaultCellStyle.BackColor = Color.Red;

            }
        }
    }
}
