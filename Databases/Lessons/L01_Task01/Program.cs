using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace L01_Task01
{
    class Program
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        static void ShowReaderData(SqlDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i) + "\t");
            }

            Console.WriteLine("\n" + new string('_', reader.FieldCount * 12));

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void ShowClients()
        {
            connection.Open();
            string cmd = "SELECT * FROM Clients";
            var command = new SqlCommand(cmd, connection);

            var reader = command.ExecuteReader();

            ShowReaderData(reader);

            reader.Close();
            connection.Close();
        }

        static void ShowSallers()
        {
            connection.Open();
            string cmd = "SELECT * FROM Sellers";
            var command = new SqlCommand(cmd, connection);

            var reader = command.ExecuteReader();

            ShowReaderData(reader);

            reader.Close();
            connection.Close();
        }

        static void ShowDealsBySallers(string name, string surname)
        {
            connection.Open();

            string cmd = "SELECT * FROM Sales as s " +
                "JOIN Sellers as sa on s.SellerId = sa.Id " +
                "WHERE sa.Name = @name and sa.Surname = @surname ";
            var command = new SqlCommand(cmd, connection);

            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@surname", System.Data.SqlDbType.NVarChar).Value = surname;


            var reader = command.ExecuteReader();

            ShowReaderData(reader);

            reader.Close();
            connection.Close();
        }

        static void ShowSalesByPrice(float price)
        {
            connection.Open();

            string cmd = "SELECT * FROM Sales " +
                "WHERE Price >= @price";
            var command = new SqlCommand(cmd, connection);

            command.Parameters.Add("@price", System.Data.SqlDbType.Money).Value = price;

            var reader = command.ExecuteReader();

            ShowReaderData(reader);

            reader.Close();
            connection.Close();
        }

        static void ShowSalesOfClient(string name, string surname)
        {
            connection.Open();

            string cmd = "SELECT * FROM Sales as s " +
                "JOIN Clients as c on c.Id = s.ClientId " +
                "WHERE c.Name = @name and c.Surname = @surname and " +
                "s.Price = (SELECT top 1 Price from Sales order by Price) or " +
                "s.Price = (SELECT top 1 Price from Sales order by Price DESC)";
            var command = new SqlCommand(cmd, connection);

            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@surname", System.Data.SqlDbType.NVarChar).Value = surname;

            var reader = command.ExecuteReader();

            ShowReaderData(reader);

            reader.Close();
            connection.Close();
        }

        static void ShowFirstSale(string name, string surname)
        {
            connection.Open();

            string cmd = "SELECT top 1 * FROM Sales as s " +
                "JOIN Sellers as sa on sa.Id = s.SellerId " +
                "WHERE sa.Name = @name and sa.Surname = @surname ORDER BY s.Date";
            var command = new SqlCommand(cmd, connection);

            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@surname", System.Data.SqlDbType.NVarChar).Value = surname;

            var reader = command.ExecuteReader();

            ShowReaderData(reader);

            reader.Close();
            connection.Close();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //ShowClients();
            //ShowSallers();
            //ShowDealsBySallers("Gordon", "Pople");
            //ShowSalesByPrice(10);
            //ShowSalesOfClient("Xena", "Dobing");
            ShowFirstSale("Derby", "Cuzen");
        }
    }
}
