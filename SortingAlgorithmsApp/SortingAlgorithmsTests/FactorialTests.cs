using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithmsApp;
namespace SortingAlgorithmsTests;

public class FactorialTests
{

    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 6)]
    [TestCase(4, 24)]

    public void GivenANumber_Factorial_ReturnsExpectedProduct(int input, int expectedProduct) 
    {
        Assert.That(Factorial.FactorialRecursive(input), Is.EqualTo(expectedProduct));
    }

    [TestCase(-1)]
    [TestCase(-10)]
    public void GivenANegativeNumber_Factorial_ThrowsArgumentOutOfRangeException(int input)
    {
        Assert.That(() => Factorial.FactorialRecursive(input), Throws.TypeOf<ArgumentOutOfRangeException>());
    }


}
