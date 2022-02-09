using System;
namespace BlogLucasEntityFramework
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=BlogLucas;User ID=sa;Password=Rkpzlx56!!;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

    }
}