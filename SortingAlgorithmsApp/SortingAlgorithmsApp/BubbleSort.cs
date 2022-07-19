using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsApp
{
    public class BubbleSort
    {
        public static int[] Sort(int[] inputArr)
        {
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 0; i < inputArr.Length - 1; i++)
                {
                    if (inputArr[i] > inputArr[i + 1])
                    {
                        int _tmpInt = inputArr[i];
                        inputArr[i] = inputArr[i + 1];
                        inputArr[i + 1] = _tmpInt;

                        sorted = false;
                    }
                }
            }
            return inputArr;
        }
    }
}
