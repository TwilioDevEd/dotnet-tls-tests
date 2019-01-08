using System;
using TestFrameworkTools;

namespace TestCore10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Core 1.0...");

            // Basic Twilio helper library connectivity test
            TwilioConnectivityTest451AndAbove.RunTest();
        }
    }
}
