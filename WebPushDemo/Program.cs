using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebPush;

namespace WebPushDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //VapidDetails vapidKeys = VapidHelper.GenerateVapidKeys();

            //// Prints 2 URL Safe Base64 Encoded Strings
            //Console.WriteLine("Public {0}", vapidKeys.PublicKey);
            //Console.WriteLine("Private {0}", vapidKeys.PrivateKey);

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
