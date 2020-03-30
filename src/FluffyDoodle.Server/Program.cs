using System.Security.Principal;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
// using Grpc.Core;
// using Grpc;
// using grpc = global::Grpc.Core;
using Grpc.Core;
using Grpc.Net.Client;

namespace FluffyDoodle.Server
{
    class Program
    {
        /// <summary>
        /// FluffyDoodle Server
        /// </summary>
        /// <param name="noTls">Suppressed the use of TLS. Useful on platforms that currently don't support HTTP/2 over TLS (i.e. macOS)</param>
        /// <param name="args"></param>
        static void Main(bool noTls = false, string[] args = null)
        {
            Console.WriteLine("FluffyDoodle - Server");

            var hostBuilder = CreateHostBuilder(noTls, args);
            var host = hostBuilder.Build();
            host.Run();
        }

        private static IHostBuilder CreateHostBuilder(bool noTls, string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    if (noTls) // Setup a HTTP/2 endpoint without TLS.
                        webBuilder.ConfigureKestrel(options => options.ListenLocalhost(5000, o => o.Protocols = HttpProtocols.Http2));

                    webBuilder.UseStartup<Startup>();
                });
    }
}
