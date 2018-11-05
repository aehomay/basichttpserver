using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicHTTPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://+:8080";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($"Nancy is Running on {url}");
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
        }
    }
}
