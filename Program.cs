using System;
using Microsoft.Data.SqlClient;  // ✅ Use the correct package

class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=EmployeeDB;Trusted_Connection=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("✅ Connected successfully to SQL Server.");

                string sql = "SELECT COUNT(*) FROM Employees";  // ✅ Use your actual table name
                SqlCommand command = new SqlCommand(sql, connection);
                int count = (int)command.ExecuteScalar();

                Console.WriteLine($"📊 Total Employees: {count}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }
}
