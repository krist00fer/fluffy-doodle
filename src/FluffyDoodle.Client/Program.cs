using System.Security.Principal;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
// using FluffyDoodle;

namespace FluffyDoodle.Client
{
    class Program
    {
        /// <summary>
        /// FluffyDoodle Client
        /// </summary>
        /// <param name="noTls">Suppressed the use of TLS. Useful on platforms that currently don't support HTTP/2 over TLS (i.e. macOS)</param>
        /// <param name="args"></param>
        static void Main(bool noTls = false, string[] args = null)
        {
            Console.WriteLine("Hello Client!");

            GrpcChannel channel;

            if (noTls)
            {
                AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                channel = GrpcChannel.ForAddress("http://localhost:5000");
            }
            else
            {
                channel = GrpcChannel.ForAddress("https://localhost:5001");
            }

            var client = new Greeter.GreeterClient(channel);

            var reply = client.SayHello(new HelloRequest{ Name = "Kristofer"});

            Console.WriteLine(reply.Message);
        }
    }
}
