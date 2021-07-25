using System;
namespace SearchAlgorithms
{
    public class SearchAlgorithms
    {
        public int[] inputArray;
        public int searchItemValue;
        public SearchAlgorithms(int[] _inputArray, int _searchItemValue)
        {
            inputArray = _inputArray;
            searchItemValue = _searchItemValue;
        }

        public void LinearSearch()
        {
            int searchItemIndex = -1;
            int steps = 0;
            for(int i = 0; i < inputArray.Length; i++)
            {
                steps++;
                if (inputArray[i] == searchItemValue)
                {
                    searchItemIndex = i;
                    break;
                }
            }

            PrintOutput(searchItemIndex, "Linear Search", steps);
        }

        public void BinarySearch()
        {
            int[] SortedArray = inputArray;
            //Binary Seach needs array to be sorted
            Array.Sort(SortedArray);
            int searchItemIndex = -1;
            int startIndex = 0;
            int endIndex = SortedArray.Length - 1;
            int steps = 0;

            Console.WriteLine("Sorted Array : {0}", string.Join(", ", SortedArray));

            do
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (SortedArray[midIndex] > searchItemValue)
                {
                    endIndex = midIndex - 1;
                }
                else if (SortedArray[midIndex] < searchItemValue)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    searchItemIndex = midIndex;
                    break;
                }
                steps = steps + 1;
            } while (endIndex >= startIndex);

            PrintOutput(searchItemIndex, "Binary Search", steps);
        }

        public void PrintOutput(int searchItemIndex, string algorithmName, int steps = 0)
        {
            Console.WriteLine(algorithmName);
            Console.WriteLine("Number of loops executed in this algorithm is {0}", steps);
            if (searchItemIndex != -1)
                Console.WriteLine("Searched Item Found at index {0} of the array", searchItemIndex);
            else
                Console.WriteLine("Number you are searching for is not found");

            Console.WriteLine("-----------------************------------------");
        }
    }

}
