using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNumsCSC370
{
    public partial class OutputBox : Form
    {
        public double runningTotal = 0;
        public List<double> allEntered = new List<double>();
        public double input;
        int countNum;
        public OutputBox()
        {
            InitializeComponent();
            InputBox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //When you click, this adds to a previous num, as well as a current running total. This is done to keep track of what has just been done, and a sum of all of thats been done
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                input = Convert.ToDouble(this.InputBox.Text);
                this.InputBox.Text = "";
                double output = input;
                runningTotal += input;
                PrevBox.Text = Convert.ToString(output);
                TotalBox.Text = Convert.ToString(runningTotal);
                allEntered.Add(input);
                countNum += 1;
                count.Text = countNum.ToString();
                ErrorBox.Text = "";
                
            }
            catch
            {
               
                ErrorBox.Text = "Incorrect input"; 
  
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //This is clearing out the output boxes, and the variables that are being manipulated so that when you clear there are no lasting pieces.
        private void button2_Click(object sender, EventArgs e)
        {
            InputBox.Text = "";
            TotalBox.Text = "0";
            runningTotal = 0;
            PrevBox.Text = "0";
            allEntered.Clear();
            countNum = 0;
            count.Text = "0";
        }
        //This creates a list with all inputs, and can be clicked as many times as it has been entered.
        private void undoButton_Click(object sender, EventArgs e)
        {
            if (allEntered.Count() > 0)
            {
                runningTotal -= allEntered[allEntered.Count()-1]; //removes last entered from total
                allEntered.RemoveAt(allEntered.Count()-1); //removes last entered from list
                TotalBox.Text = runningTotal.ToString(); //sets new total
                countNum -= 1;
                count.Text = countNum.ToString();
                if (allEntered.Count() > 0)
                {
                    PrevBox.Text = allEntered[allEntered.Count() - 1].ToString(); //sets prev number
                }
                else
                {
                    PrevBox.Text = "0";
                }
            }
        }

        private void enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter input in text box. Click button to add nums. Undo removes previous input and clear removes all. Save saves to file, and print displays current weight and count and clears current total.  ");
                  
        }
        //This opens up a pop up box with current info
        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total weight: " + runningTotal +"\n"+ "Count of shims: " + countNum + "\n" + "Avg weight of shim: " + runningTotal/countNum);
            InputBox.Text = "";
            TotalBox.Text = "0";
            runningTotal = 0;
            PrevBox.Text = "0";
            allEntered.Clear();
            countNum = 0;
            count.Text = "0";
        }
        //This prints the current info to C:\Users\Public/WriteText.txt and overwrites every time 
        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string text = "Date: "  + now + "\n" + "Total weight: " + runningTotal +"\n"+ "Count of shims: " + countNum + "\n" + "Avg weight of shim: " + runningTotal/countNum;
            System.IO.File.WriteAllText(@"C:\Users\Public/WriteText.txt", text);
        }
    }
}
