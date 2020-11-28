using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace HT02_Task01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] matrix;
        int size = 0;
        DispatcherTimer timer;
        TimeSpan time;
        int lastValue = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickBtn(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            var strs = b.Name.Split(new[] { '_' });
            int i = int.Parse(strs[1]);
            int j = int.Parse(strs[2]);

            if (lastValue + 1 == int.Parse(b.Content.ToString()))
            {
                lastValue += 1;
                b.IsEnabled = false;
                matrix[i, j] = -1;

                if (lastValue == Math.Pow(size, 2) - 1) 
                {
                    timer.Stop();
                    MessageBox.Show($"You win! Time: {new TimeSpan(0,0, (int)Math.Pow(size, 2) * 3) - time}");
                }
            }
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {

            GameGrid.Children.Clear();
            GameGrid.ColumnDefinitions.Clear();
            GameGrid.RowDefinitions.Clear();
            size = (int)(Difficulty.Value);
            lastValue = 0;
            timer?.Stop();
            LabelTime.Content = $"Time: 00:00:00";

            //ProgressBar
            int seconds = (int)Math.Pow(size, 2) * 3;
            ProgressBarTime.Maximum = seconds;
            ProgressBarTime.Value = seconds;

            //Label
            time = new TimeSpan(0, 0, seconds); 

            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                LabelTime.Content = $"Time: {time}";
                ProgressBarTime.Value = time.TotalSeconds;
                if (time == TimeSpan.Zero) 
                { 
                    timer.Stop();
                    MessageBox.Show("You lose.");
                }
                time = time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            timer.Start();

            var rand = new Random();

            matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                var colDef = new ColumnDefinition();
                var rowDef = new RowDefinition();

                GameGrid.ColumnDefinitions.Add(colDef);
                GameGrid.RowDefinitions.Add(rowDef);

            }

            for (int i = 0; i < size * size; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(0, size);
                    y = rand.Next(0, size);
                } while (matrix[y, x] != 0);
                matrix[y, x] = i + 1;
                if (i == size * size - 1)
                {
                    matrix[y, x] = matrix[size / 2, size / 2];
                    matrix[size / 2, size / 2] = 0;
                }

            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button btn = new Button();

                    btn.FontSize = 16;


                    btn.Content = matrix[i, j];
                    btn.Name = $"Button_{i}_{j}";
                    btn.Margin = new Thickness(10);

                    if (i == size / 2 && j == size / 2)
                    {
                        btn.Content = "-";
                        btn.IsEnabled = false;
                    }

                    btn.Click += ClickBtn;

                    Grid.SetColumn(btn, j);
                    Grid.SetRow(btn, i);

                    GameGrid.Children.Add(btn);
                }

                GameGrid.SetValue(Grid.ColumnProperty, i);
            }
        }
    }
}
