using L11_Task01_DAL.Services;
using System.Windows;

namespace L11_Task01_UI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly ClientService _clientService;
        public string UserLogin { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
            _clientService = new ClientService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = _clientService.LoginUser(Login.Text, Password.Text);
            if (DialogResult.Value)
                UserLogin = Login.Text;
        }
    }
}
