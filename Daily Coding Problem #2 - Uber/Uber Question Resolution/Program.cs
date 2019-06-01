using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uber_Question_Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArrayA = new int[] { 1, 2, 3, 4, 5 };
            int[] intArrayB = new int[] { 3, 2, 1 };
            int[] resolutionArray = ResolutionMethod(intArrayB);

            for (int i = 0; i < resolutionArray.Length; i++)
            {
                Console.WriteLine(resolutionArray[i]);
            }
            Console.ReadKey();
        }

        static int[] ResolutionMethod(int[] intArray)
        {
            int[] intArrayToReturn = new int[intArray.Length];
            for (int i = 0; i < intArrayToReturn.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (j == i)
                        continue;

                    if (intArrayToReturn[i] == 0)
                        intArrayToReturn[i] = intArray[j];
                    else
                        intArrayToReturn[i] = intArray[j] * intArrayToReturn[i];
                }
            }
            return intArrayToReturn;
        }
    }
}
