using WindowsFormsApp1.SortService;
namespace WindowsFormsApp1.Model
{
    public class BubbleSortModel
    {

        private IBubbleSort _bubbleSort;
        /* -- PROPS SECTION = use this if you want to access this from other parts of your code -- */
        private char[] Data { get; set; } 
        public BubbleSortModel(IBubbleSort bubbleSort)
        {
            _bubbleSort = bubbleSort;
        }
       
        public void BubbleSortStrings(char[] data)
        {
             Data = data;
            _bubbleSort.BubbleSortIt(Data);
        }

    }
}
