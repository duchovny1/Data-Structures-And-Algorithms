using System;

namespace SortingAndSearchingAlgorhitms
{
    public class Launcher
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };

            //Sort(arr, 0, arr.Length - 1);


            var sort = new InsertionSort();
            var sortedArray = sort.Sort(new int[] { 5, 2, 4, 6, 1, 3});
            var sortedArray1 = sort.Sort(new int[] { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 });
            var sortedArray2 = sort.Sort(new int[] { 17, 201, 38, 51, 47, 19, 24, 23, 27, 1, 0, 255, 1, 2, 1});

            Console.WriteLine(string.Join(" ", sortedArray));
            Console.WriteLine(string.Join(" ", sortedArray1));
            Console.WriteLine(string.Join(" ", sortedArray2));
            ;
        }

        static void Sort(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int middleIndex = (startIndex + endIndex) / 2;

            Sort(arr, startIndex, middleIndex);
            Sort(arr, middleIndex + 1, endIndex);
            Merge(arr, startIndex, middleIndex, endIndex);

        }

        static void Merge(int[] arr, int startIndex, int middleIndex, int endIndex)
        {
            if (middleIndex < 0
                || middleIndex + 1 >= arr.Length
                || arr[middleIndex] <= arr[middleIndex + 1])
            {
                return;
            }

            int[] helpArray = new int[arr.Length];

            for (int i = startIndex; i <= endIndex; i++)
            {
                helpArray[i] = arr[i];
            }

            int leftIndex = startIndex;
            int rightIndex = middleIndex + 1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (leftIndex > middleIndex)
                {
                    arr[i] = helpArray[rightIndex];
                    rightIndex++;
                }
                else if (rightIndex > endIndex)
                {
                    arr[i] = helpArray[leftIndex++];
                }
                else if (helpArray[leftIndex] <= helpArray[rightIndex])
                {
                    arr[i] = helpArray[leftIndex++];
                }
                else
                {
                    arr[i] = helpArray[rightIndex++];
                }

            }
        }
    }

    

}
