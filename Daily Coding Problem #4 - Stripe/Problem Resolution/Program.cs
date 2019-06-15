using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayExample = new int[] { 3, 4, -1, 1 };
            int[] arrayExample2 = new int[] { 1, 2, 0 };
            int[] arrayExample3 = new int[] { -1, -2, -44 };
            Console.WriteLine(FindLowestPositiveIntegerThatDoesNotExistInTheArray(arrayExample3));
            Console.ReadKey();
        }

        static int FindLowestPositiveIntegerThatDoesNotExistInTheArray(int[] array)
        {
            int LowestPositive = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 2)
                {
                    if(!CheckIfNumberExistsInArray(array[i] - 1, array))
                    {
                        if (LowestPositive > array[i] - 1)
                            LowestPositive = array[i] - 1;

                        if (LowestPositive == -1) LowestPositive = array[i] - 1;
                    }
                    else if(!CheckIfNumberExistsInArray(array[i] + 1, array))
                    {
                        if (LowestPositive > array[i] + 1)
                            LowestPositive = array[i] + 1;

                        if (LowestPositive == -1) LowestPositive = array[i] + 1;
                    }
                }
            }
            if (LowestPositive <= 0) LowestPositive = 1;

            return LowestPositive;
        }

        static bool CheckIfNumberExistsInArray(int number, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }
            return false;
        }
    }
}
