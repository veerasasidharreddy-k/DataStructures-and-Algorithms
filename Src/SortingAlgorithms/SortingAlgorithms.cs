using System;
namespace SortingAlgorithms
{
    public class SortingAlgorithms
    {
        public void BubbleSort(int[] inputArray)
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
                    {//Swapping without extra variable
                        sortedArray[i] = sortedArray[i] + sortedArray[i + 1];
                        sortedArray[i + 1] = sortedArray[i] - sortedArray[i + 1];
                        sortedArray[i] = sortedArray[i] - sortedArray[i + 1];
                        isSwapped = true;
                        steps++;
                    }
                }
                arrayLength--;
            } while (isSwapped);

            PrintOutput("Bubble Sort", sortedArray, steps);
        }

        public void SelectionSort(int[] inputArray)
        {
            int[] sortedArray = inputArray;
            int currStartIndex;
            int lowestNumberIndex = 0;
            int steps = 0;

            for(int i = 0; i <= sortedArray.Length-1; i++)
            {
                currStartIndex = i;
                lowestNumberIndex = currStartIndex;
                for (int j = currStartIndex; j <= sortedArray.Length-1; j++)
                {
                    steps++; 
                    if (sortedArray[j] < sortedArray[lowestNumberIndex])
                        lowestNumberIndex = j;
                }

                if(lowestNumberIndex != currStartIndex)
                {
                    steps++;
                    sortedArray[currStartIndex] = sortedArray[currStartIndex] + sortedArray[lowestNumberIndex];
                    sortedArray[lowestNumberIndex] = sortedArray[currStartIndex] - sortedArray[lowestNumberIndex];
                    sortedArray[currStartIndex] = sortedArray[currStartIndex] - sortedArray[lowestNumberIndex];
                }
                
            }

            PrintOutput("Selection Sort", sortedArray, steps);
        }

        public void InsertionSort(int[] inputArray)
        {
            int[] sortedArray = inputArray;
            int steps = 0;
            int extractedValue;
            int position;
            for(int i = 1; i< sortedArray.Length; i++)
            {
                steps++;
                extractedValue = sortedArray[i];
                position = i - 1;

                do
                {
                    steps++;
                    if (extractedValue < sortedArray[position])
                    {
                        steps++;
                        sortedArray[position + 1] = sortedArray[position];
                        position--;
                    }
                    else
                        break;
                } while (position >= 0);

                steps++;
                sortedArray[position + 1] = extractedValue;

            }
            PrintOutput("Insertion Sort", sortedArray, steps);
        }

        public void PrintOutput(string algorithmName,int[] sortedArray, int steps = 0)
        {
            Console.WriteLine(algorithmName);
            Console.WriteLine("Number of significant steps executed in this algorithm is {0}", steps);

            Console.WriteLine("Sorted Array : {0}", string.Join(", ", sortedArray));

            Console.WriteLine("-----------------************------------------");
        }
    }
}
