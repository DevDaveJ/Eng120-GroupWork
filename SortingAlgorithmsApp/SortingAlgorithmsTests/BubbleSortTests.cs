using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SortingAlgorithmsApp;
namespace SortingAlgorithmsTests;

public class BubbleSortTests
{
    [TestCaseSource(nameof(SortCases))]
    public void GivenUnsortedNumbers_BubbleSort_ReturnsSortedNumbers(int[] inputUnsorted, int[] expectedSorted)
    {
        Assert.That(BubbleSort.Sort(inputUnsorted), Is.EquivalentTo(expectedSorted));
    }

    static object[] SortCases =
    {
        new object[] { new int[] { 3,2,1 }, new int[] { 1,2,3 } },
        new object[] { new int[] { 7,-7,100,4,1 }, new int[] { -7,1,4,7,100 } },
        new object[] { new int[] { }, new int[] { } },
        new object[] { new int[] { -8,-23,-15 }, new int[] { -23,-15,-8 } },
        new object[] { new int[] { 80,25,16 }, new int[] { 16,25,80 } }
    };
}
