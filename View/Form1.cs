using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.SortService;
using WindowsFormsApp1.SortService.QuickSort;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SortController _controller;
        private BubbleSortModel _bubbleModel;
        private QuickSortModel _quickSortModel;

        public Form1()
        {
            InitializeComponent();
            _bubbleModel = new BubbleSortModel(new BubbleSort());
            _quickSortModel = new QuickSortModel(new QuickSort());
            _controller = new SortController(this, _bubbleModel,_quickSortModel);
        }

        

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Already handled in SortController :)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
