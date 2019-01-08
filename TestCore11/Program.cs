using System;
using TestFrameworkTools;

namespace TestCore11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Core 1.1...");

            // Basic Twilio helper library connectivity test
            TwilioConnectivityTest451AndAbove.RunTest();
        }
    }
}
