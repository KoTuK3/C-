using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace L01_Task02
{
    class Program
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        }
    }
}
