using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L01_Task01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _updateTime = 5;
        private Action _act;
        private ObservableCollection<Process> _processes = new ObservableCollection<Process>(Process.GetProcesses());
        public MainWindow()
        {
            InitializeComponent();

            _act = Update;
            SetInterval(_act, _updateTime);
            ProcessList.ItemsSource = _processes;
        }       

        public void Update()
        {
            _processes.Clear();
            foreach (var item in Process.GetProcesses())
            {
                _processes.Add(item);
            }
        }

        public static System.Timers.Timer SetInterval(Action Act, int interval)
        {
            System.Timers.Timer tmr = new System.Timers.Timer();
            tmr.Elapsed += (sender, args) => Act();
            tmr.AutoReset = true;
            tmr.Interval = interval;
            tmr.Start();

            return tmr;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            SetUpdateTime(1);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            SetUpdateTime(3);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            SetUpdateTime(5);
        }

        private void SetUpdateTime(int time)
        {
            _act = Update;
            _updateTime = time;
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            _act = null;
        }
    }
}
