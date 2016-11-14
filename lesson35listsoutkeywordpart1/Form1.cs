using System;
using System.Linq;//this is needed to make use of Lists
using System.Windows.Forms;

namespace lesson35listsoutkeywordpart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            //make an array to hold the values from the boxes
            //arrays allow us to operate on the data in bulk
            decimal[] values = { nmrFirstNumber.Value, nmrSecondNumber.Value, nmrThirdNumber.Value };
            decimal max, min, average, sum;//these variable are set inside Summarize, so they do not have to be set here
            MathMethods.Summarize(values, out max, out min, out average, out sum);//call method to set the variable values
            lblSummary.Text = $"Max: {max}\n";//show maximum value to user
            lblSummary.Text += $"Min: {min}\n";//show minimum value to user
            lblSummary.Text += $"Average: {Math.Round(average,2)}\n";//show rounded average value to user
            lblSummary.Text += $"Sum: {sum}";//show sum value to user
        }
    }
}
