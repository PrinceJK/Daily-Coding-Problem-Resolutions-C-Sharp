using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemResolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWays = Decoder("111", 0);
            Console.WriteLine(numberOfWays);
            Console.ReadKey();
        }

        static int Decoder(string message, int index)
        {
            if (index == message.Length)
                return 1;

            int numWays = 0;

            int currentNumber = int.Parse(message[index].ToString());

            if (currentNumber > 0)
            {
                numWays += Decoder(message, index + 1);
            }

            if (index < message.Length - 1)
            {
                currentNumber += int.Parse(message[index + 1].ToString());

                if (currentNumber < 27)
                {
                    numWays += Decoder(message, index + 2);
                }
            }

            return numWays;
        }
    }
}
