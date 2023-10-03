using WindowsFormsApp1.SortService;
namespace WindowsFormsApp1.Model
{
    public class BubbleSortModel
    {
        private IBubbleSort _bubbleSort;

        public BubbleSortModel(IBubbleSort bubbleSort)
        {

            _bubbleSort = bubbleSort;
        }

       

        public void BubbleSortStrings(char[] data)
        {
            _bubbleSort.BubbleSortIt(data);
        }
    }
}
