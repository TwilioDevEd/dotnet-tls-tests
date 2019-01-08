using System;
using TestFrameworkTools;

namespace TestCore22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Core 2.2...");

            // Basic Twilio helper library connectivity test
            TwilioConnectivityTest451AndAbove.RunTest();
        }
    }
}
