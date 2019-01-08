using System;
using System.Net;
using TestFrameworkTools;

namespace TestFramework35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Framework 3.5...");

            // Operating system (registry) changes and hot patch needed
            // for TLS 1.2 to work in .NET Framework 3.5
            // See: https://bit.ly/2H3q8ZD
            ServicePointManager.SecurityProtocol = SecurityProtocolTypeExtensions.Tls12;

            // Basic Twilio helper library connectivity test
            TwilioConnectivityTest45AndBelow.RunTest();
        }
    }
}
