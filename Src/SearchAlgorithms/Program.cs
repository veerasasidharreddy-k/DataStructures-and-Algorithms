using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[10] { 2, 10, 4, 43, 23, 76, 54, 35, 66, 98 };
            Console.WriteLine("Input Array : {0}", string.Join(", ", inputArray));
            Console.WriteLine("Enter the number to be searched for: ");
            int searchItemValue = Convert.ToInt32(Console.ReadLine());

            SearchAlgorithms algorithms = new SearchAlgorithms(inputArray, searchItemValue);

            algorithms.LinearSearch();
            algorithms.BinarySearch();
        }

    }
}
