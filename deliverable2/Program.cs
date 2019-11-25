using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)

        {
            {
                Console.WriteLine("What is your message?");
                string input = Console.ReadLine();

                input = input.ToUpperInvariant();

                int checksum = 0;
                string message = null;
                foreach (char c in input)
                {
                    if (message != null)
                        message += "-";
                    else
                        message = "";

                    message += c - 64;
                    checksum += c;
                }
                Console.Write("Your encoded message is:");
                Console.WriteLine(message);
                Console.WriteLine($"Your Checksum total is: {checksum}");
                Console.ReadLine();
            }
        }
    }
}

