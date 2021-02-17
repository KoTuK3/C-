using L11_Task01_DAL.Services;
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
using System.Windows.Shapes;

namespace L11_Task01_UI
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private readonly ClientService _clientService;
        public string UserLogin { get; set; }
        public RegisterWindow()
        {
            InitializeComponent();
            _clientService = new ClientService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = _clientService.RegisterUser(Login.Text, Password.Text);
            if (DialogResult.Value)
                UserLogin = Login.Text;
        }
    }
}
