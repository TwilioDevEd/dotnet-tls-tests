using System;
using System.Net;
using Twilio.Http;
using Twilio.Http.Net35;

namespace TestFrameworkTools
{
    public class TwilioConnectivityTest45AndBelow
    {
        public static void RunTest()
        {
            var client = new WebRequestClient();
            var request = new Request(HttpMethod.Get, "https://api.twilio.com:8443");

            Response response = null;
            try
            {
                response = client.MakeRequest(request);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR:");
                Console.WriteLine(e);
            }

            Console.WriteLine();
            if (response?.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Result: SUCCESS!");
            }
            else
            {
                Console.WriteLine("Result: FAILURE");
            }

            Console.WriteLine();
            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
