using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Coding_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 11, 15, 3, 7 };
            int k = 17;
            Console.WriteLine(CheckIf2NumbersAddUpToK(array, k));
            Console.ReadKey();
        }

        static bool CheckIf2NumbersAddUpToK(int[] numbersArray, int K)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                for (int j = (i + 1); j < numbersArray.Length; j++)
                {
                    if (numbersArray[i] + numbersArray[j] == K)
                        return true;
                }
            }
            return false;
        }

    }
}
