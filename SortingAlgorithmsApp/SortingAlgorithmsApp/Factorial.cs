using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsApp
{
    public class Factorial
    {
        public static int FactorialRecursive(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("Cannot calculate factorial of negative number");

            return (n <= 1) ? 1 : n * FactorialRecursive(n - 1);
        }
    }
}
