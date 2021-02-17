using L11_Task01_DAL.Models;
using L11_Task01_DAL.Services;
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

namespace L11_Task01_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string userLogin;
        private BookService _bookService;
        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();
        private IEnumerable<Book> _books;
        public MainWindow()
        {
            InitializeComponent();
            _bookService = new BookService();
            BookTable.ItemsSource = Books;

            _books = _bookService.GetBooks();
            UpdateBooks();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            userLogin = loginWindow.UserLogin;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var registerWindow = new RegisterWindow();
            userLogin = registerWindow.UserLogin;
        }

        private void UpdateBooks()
        {
            Books.Clear();
            foreach (var item in _books)
            {
                Books.Add(item);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _books = _bookService.GetBooks();
            UpdateBooks();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {            
            _books = _bookService.GetNewBooks(10, new DateTime(1990, 1, 1), DateTime.Now);
            UpdateBooks();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            _books = _bookService.GetBestSellers(10, new DateTime(1990, 1, 1), DateTime.Now);
            UpdateBooks();
        }
    }
}
