namespace WindowsFormsApp1.SortService
{
    public class BubbleSort : IBubbleSort
    {
        public void BubbleSortIt(char[] data) 
        {
            int n = data.Length;
            bool swapped;
            int largestIndex = n - 1;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < largestIndex; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        
                        char temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
                largestIndex--;
            }
        }
    }
}
