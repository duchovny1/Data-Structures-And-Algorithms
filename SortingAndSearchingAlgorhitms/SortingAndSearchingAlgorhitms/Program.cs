using System;

namespace SortingAndSearchingAlgorhitms
{
    public class Launcher
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };

            Sort(arr, 0, arr.Length - 1);
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
