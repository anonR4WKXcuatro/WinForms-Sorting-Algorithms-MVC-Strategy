using WindowsFormsApp1.SortService.QuickSort;
namespace WindowsFormsApp1.Model
{
    public class QuickSortModel
    {

        private IQuickSort _quickSort;
        /* -- PROPS SECTION = use this if you want to access this from other parts of your code -- */
        private char[] Data { get; set; } 
        private int Left { get; set; }
        private int Right { get; set; }

        public QuickSortModel(IQuickSort quickSort)
        {
            _quickSort = quickSort;
        }


        public void QuickSortStrings(char[] data, int left, int right)
        {
            Data = data; Left = left; Right = right;
            _quickSort.QuickSortIt(Data, Left, Right);
        }

    }
}
