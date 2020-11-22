using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace L04_Task01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Person> People = null;
        ObservableCollection<string> Countries = null;
        public MainWindow()
        {
            InitializeComponent();
            People = new ObservableCollection<Person>();
            Countries = new ObservableCollection<string>();
            UserList.ItemsSource = People;
            CountryComboBox.ItemsSource = Countries;

            Countries.Add("Ukraine");
            Countries.Add("Canada");
            Countries.Add("USA");
            Countries.Add("Norway");
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var person = new Person()
            {
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Country = CountryComboBox.Text,
                Number = PhoneeTextBox.Text
            };
            People.Add(person);
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
