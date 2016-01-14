using System;
using Microsoft.Owin.Hosting;

namespace TaskAsync.Service
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string url = "http://localhost:8080";
            using (WebApp.Start<StartUp>(url))
            {
                Console.WriteLine("Web server is running at "+url);
                Console.ReadLine();
            }
        }
    }
}
