using System;
using Twilio;

namespace Twilio.NetCore.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Twilio");

			Console.Write("Enter Account SID: ");
			var sid = Console.ReadLine();

			Console.Write("Enter Auth Token: ");
			var token = Console.ReadLine();

			while (true)
			{
				Console.Write("Enter From Number: ");
				var from = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(from)) break;

				Console.Write("Enter To Number: ");
				var to = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(to)) break;

				Console.Write("Enter Message: ");
				var body = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(body)) break;

				try
				{
					Console.Write("Sending... ");
					var client = new TwilioRestClient(sid, token);
					client.SendMessage(from, to, body);
					Console.WriteLine("Success!");
				}
				catch (Exception ex)
				{
					Console.WriteLine("Failed!");
					Console.WriteLine(ex.StackTrace);
				}
			}
        }
    }
}
