namespace SortingAndSearchingAlgorhitms
{
    public class InsertionSort
    {
        public int[] Sort(int[] numbers)
        {

            //----solution 1

            //----solved with a new array, not to mutate original data

            int[] sortedArray = new int[numbers.Length];

            ///              

            //sortedArray[0] = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    int elementToPut = numbers[i];
            //    sortedArray[i] = elementToPut;

            //    for (int j = i; j >= 0; j--)
            //    {
            //        if(j - 1 < 0)
            //        {
            //            break;
            //        }

            //        int elementToSwap = sortedArray[j - 1];

            //        if(elementToPut >= elementToSwap)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            sortedArray[j - 1] = elementToPut;
            //            sortedArray[j] = elementToSwap;
            //        }

            //    }
            //}

            ////solution 2
            //return sortedArray;



            //---solution 2

            for (int i = 1; i < numbers.Length; i++)
            {
                int current = numbers[i];
                //previous element
                int j = i - 1;

                while (j >= 0 && numbers[j] > current)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = current;

            }

            return numbers;


        }
    }
}
