using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows;

namespace L03_Task01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        private DbProviderFactory fact = null;
        private DbConnection conn = null;
        private DbDataAdapter da = null;
        private DataSet set = null;

        public MainWindow()
        {
            InitializeComponent();

            string cs = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            fact = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["ConnString"].ProviderName);
            conn = fact.CreateConnection();
            conn.ConnectionString = cs;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new RegistrationWindow(conn);
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
