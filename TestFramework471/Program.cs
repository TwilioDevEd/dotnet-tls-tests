using System;
using TestFrameworkTools;

namespace TestFramework471
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Framework 4.7.1...");

            // Basic Twilio helper library connectivity test
            TwilioConnectivityTest451AndAbove.RunTest();
        }
    }
}
