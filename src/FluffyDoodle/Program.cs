using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace FluffyDoodle
{
    /// <summary>
    /// Main class for application
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Fluffy Doodle - An application ...
        /// </summary>
        /// <param name="server">Start in server mode</param>
        /// <param name="noTls">Useful if running on plafforms where HTTP/2 over TLS isn't yet supported (macOS)</param>
        /// <param name="args">Additional arguments</param>
        public static void Main(bool server = false, bool noTls = false, string[] args = null)
        {
            if (server)
                RunAsServer(noTls, args);
            else
                RunAsClient(noTls);
        }

        private static void RunAsClient(bool noTls)
        {
        }

        private static void RunAsServer(bool noTls, string[] args)
        {
            var hostBuilder = CreateHostBuilder(noTls, args);
            var host = hostBuilder.Build();
            host.Run();

        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
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