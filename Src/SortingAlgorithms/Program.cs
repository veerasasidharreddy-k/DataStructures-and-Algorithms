using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[10] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
            Console.WriteLine("Input Array : {0}", string.Join(", ", inputArray));

            SortingAlgorithms algorithms = new SortingAlgorithms();

            algorithms.BubbleSort(new int[10] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });
            algorithms.SelectionSort(new int[10] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });
            algorithms.InsertionSort(new int[10] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 });
            //Best Case
            algorithms.InsertionSort(new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 });
        }
    }
}
