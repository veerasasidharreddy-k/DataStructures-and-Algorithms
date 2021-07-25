using System;
namespace SortingAlgorithms
{
    public class SortingAlgorithms
    {
        public int[] inputArray;
        public SortingAlgorithms(int[] _inputArray)
        {
            inputArray = _inputArray;
        }

        public void BubbleSort()
        {
            int[] sortedArray = inputArray;
            bool isSwapped;
            int arrayLength = sortedArray.Length;
            int steps = 0;

            do
            {
                isSwapped = false;
                for (int i = 0; i < arrayLength-1; i++)
                {
                    steps++;
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        int temp = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = temp;
                        isSwapped = true;
                    }
                }
                arrayLength--;
            } while (isSwapped);

            PrintOutput("Bubble Sort", sortedArray, steps);
        }

        public void PrintOutput(string algorithmName,int[] sortedArray, int steps = 0)
        {
            Console.WriteLine(algorithmName);
            Console.WriteLine("Number of loops executed in this algorithm is {0}", steps);

            Console.WriteLine("Sorted Array : {0}", string.Join(", ", sortedArray));

            Console.WriteLine("-----------------************------------------");
        }
    }
}
