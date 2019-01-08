using System;
using System.Net;
using TestFrameworkTools;

namespace TestFramework451
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Framework 4.5.1...");

            // Necessary code to enforce TLS 1.2 on .NET 4.5.1
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // Basic Twilio helper library connectivity test
            TwilioConnectivityTest451AndAbove.RunTest();
        }
    }
}
