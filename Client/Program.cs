using System;
using System.Linq;
using System.Text;
using Business;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-H1GPQOS\SQLEXPRESS01;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
          
            BusinessHandler business = new BusinessHandler(connectionString);
            StringBuilder sb = new StringBuilder();


            Console.WriteLine("Tulchinka products:");
            business.GetProductsByProvider("Tulchinka").Select(x => x.Name).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Healthcare providers:");
            business.GetProvidersByCategory("Health").Select(x => x.Name).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Backery products:");
            business.GetProductsByCategory("Backery").Select(x => x.Name).ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadLine();
        }

    }
}
