using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace L03_Task02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\Step\CSharp\SystemProg\Examples\Lesson03\Test";
            dialog.Multiselect = true;
            dialog.ShowDialog();

            var threads = new List<Thread>();
            for (int i = 0; i < dialog.FileNames.Length; i++)
            {
                var t = new Thread(() => Analyzer.StartAnalyze(dialog.FileNames[i]));
   
                threads.Add(t);
                t.Start();
            }

            for (int i = 0; i < threads.Count; i++)
            {
                threads[i].Join();
            }

            this.Words.Content = Analyzer.Words;
            this.Lines.Content = Analyzer.Lines;
            this.Punctuation.Content = Analyzer.Punctuation;
        }
    }
}
