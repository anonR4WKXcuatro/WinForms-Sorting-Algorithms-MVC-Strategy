using WindowsFormsApp1.SortService.QuickSort;

namespace WindowsFormsApp1.Model
{
    public class QuickSortModel
    {

        private IQuickSort _quickSort;

        public QuickSortModel(IQuickSort quickSort)
        {
            _quickSort = quickSort;
        }


        public void QuickSortStrings(char[] data, int left, int right)
        {
            _quickSort.QuickSortIt(data, left, right);
        }
    }
}
