namespace SortingAlgorithmsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputLs = new int[]{ 4, 2, 8, 1, 9, 6};

            var sortedList = BubbleSort.Sort(inputLs);

            var str = String.Join(",", sortedList);
            Console.WriteLine(str);
        }
    }

}