using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbProblemResolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] example1 = new int[] { 2, 4, 6, 2, 5 };
            int[] example2 = new int[] { 5, 1, 1, 5 };

            Console.WriteLine(LargestSumOfNonAdjacentNumbers(example1));
            Console.ReadKey();
        }

        static int LargestSumOfNonAdjacentNumbers(int[] array)
        {
            int largestSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                List<int> numberToSumArrayIndex = new List<int>();
                numberToSumArrayIndex.Add(i);
                for (int j = i + 2; j < array.Length; j++)
                {
                    if(numberToSumArrayIndex.Count != 0)
                    {
                        if(numberToSumArrayIndex[numberToSumArrayIndex.Count - 1] == j - 1)
                        {
                            if(array[numberToSumArrayIndex.Count] < array[j])
                            {
                                numberToSumArrayIndex.RemoveAt(numberToSumArrayIndex.Count - 1);
                                numberToSumArrayIndex.Add(j);
                            }
                        }
                        else
                        {
                            numberToSumArrayIndex.Add(j);
                        }
                    }
                    else
                    {
                        numberToSumArrayIndex.Add(j);
                    }
                }
                int currentSum = SumArrayItemsByIndex(array, numberToSumArrayIndex);
                if (largestSum < currentSum)
                    largestSum = currentSum;
            }

            return largestSum;
        }

        static int SumArrayItemsByIndex(int[] array, List<int> indexesToSum)
        {
            int sum = 0;

            for (int i = 0; i < indexesToSum.Count; i++)
            {
                sum += array[indexesToSum[i]];
            }

            return sum;
        }
    }
}
