using System;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1.Controller
{
    public class SortController
    {

        private readonly Form _view;
        private readonly BubbleSortModel _bubbleModel;
        private readonly QuickSortModel _quickModel;


        public SortController(Form view, BubbleSortModel bubbleModel, QuickSortModel quickModel)
        {
            _view = view;
            _bubbleModel = bubbleModel;
            _quickModel = quickModel;

            _view.Load += (sender, e) =>  // Attach event handlers to make Control in Form1.cs to be work.
            {
                _view.Controls["btnSort"].Click += SortButtonClick; // "btnSort is the name of Button Control in Form1.cs
            };
        }

        private void SortButtonClick(object sender, EventArgs e)
        {
            ComboBox comboBox = _view.Controls["comboBox1"] as ComboBox; // "comboBox1 is the name of Combobox Control in Form1.cs
            TextBox textBoxInput = _view.Controls["textBox1"] as TextBox; // "textBox1 is the name of TextBox Control in Form1.cs
            Label labelSorted = _view.Controls["txtLabel"] as Label; // "txtLabel is the name of TextLabelControl in Form1.cs

            string a = textBoxInput.Text; // Get the textbox value as a string

            char[] inputStrings = a.ToCharArray(); // now i want to convert it in array, Ex. "BECDA" to {'B','E','C','D','A'};

            if (string.IsNullOrEmpty(textBoxInput.Text)) // if textbox is empty, show error message.
            {
                MessageBox.Show("Please enter a valid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (comboBox.SelectedIndex)
                {
                    case 1:
                        _bubbleModel.BubbleSortStrings(inputStrings);
                        labelSorted.Text = "SORTED AS BUBBLE SORT: " + string.Join("", inputStrings);
                        break;
                    case 2:
                        _quickModel.QuickSortStrings(inputStrings, 0, inputStrings.Length - 1);
                        labelSorted.Text = "SORTED AS QUICK SORT: " + string.Join("", inputStrings);
                        break;
                    default:
                        MessageBox.Show("Choose a sorting Algorithm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
    }
}
