using System;
using System.Net;
using TestFrameworkTools;

namespace TestFramework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Framework 4...");

            // Necessary code to enforce TLS 1.2 on .NET 4
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            // Basic Twilio helper library connectivity test
            TwilioConnectivityTest45AndBelow.RunTest();
        }
    }
}
