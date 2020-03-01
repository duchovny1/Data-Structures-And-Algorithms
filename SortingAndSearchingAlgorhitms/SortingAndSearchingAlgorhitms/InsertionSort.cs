namespace SortingAndSearchingAlgorhitms
{
    public class InsertionSort
    {
        public int[] Sort(int[] numbers)
        {
            int[] sortedArray = new int[numbers.Length];

            sortedArray[0] = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int elementToPut = numbers[i];
                sortedArray[i] = elementToPut;

                for (int j = i; j >= 0; j--)
                {
                    if(j - 1 < 0)
                    {
                        break;
                    }

                    int elementToSwap = sortedArray[j - 1];

                    if(elementToPut >= elementToSwap)
                    {
                        break;
                    }
                    else
                    {
                        sortedArray[j - 1] = elementToPut;
                        sortedArray[j] = elementToSwap;
                    }

                }
            }


           

            return sortedArray;
        }
    }
}
