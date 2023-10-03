using System;
using System.Collections.Generic;
namespace WindowsFormsApp1.SortService.QuickSort
{
    public class QuickSort : IQuickSort
    {
        public void QuickSortIt(char[] data, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(data, left, right);

                
                QuickSortIt(data, left, pivotIndex - 1);
                QuickSortIt(data, pivotIndex + 1, right);
            }
        }
        private int Partition(char[] data, int left, int right)
        {
            char pivot = data[right]; 
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (data[j] < pivot) 
                {
                    i++;
                    
                    char temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
            char tempPivot = data[i + 1];
            data[i + 1] = data[right];
            data[right] = tempPivot;

            return i + 1;
        }
    }
}
