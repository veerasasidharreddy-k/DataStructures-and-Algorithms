using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[10] { 2, 10, 4, 43, 23, 76, 54, 35, 66, 98 };
            Console.WriteLine("Input Array : {0}", string.Join(", ", inputArray));

            SortingAlgorithms algorithms = new SortingAlgorithms(inputArray);

            algorithms.BubbleSort();
        }
    }
}
