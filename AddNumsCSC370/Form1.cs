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
            this.Text = "Shim calculator";
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
                avgWeight.Text = allEntered.Average().ToString();
                minShimWeight.Text = allEntered.Min().ToString();
                maxShimWeight.Text = allEntered.Max().ToString();
                double average = allEntered.Average();
                double sumOfSquaresOfDifferences = allEntered.Select(val => (val - average) * (val - average)).Sum();
                double sd = Math.Sqrt(sumOfSquaresOfDifferences / allEntered.Count);
                stDev.Text = sd.ToString();
                try { goalWeightLabel.Text = (Convert.ToDouble(goalWeightInput.Text) - allEntered.Sum()).ToString(); } catch { goalWeightLabel.Text = "Error goal"; }

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
            avgWeight.Text = "0";
            minShimWeight.Text = "0";
            maxShimWeight.Text = "0";
            stDev.Text = "0";
            try { goalWeightLabel.Text = (Convert.ToDouble(goalWeightInput.Text) - allEntered.Sum()).ToString(); } catch { goalWeightLabel.Text = "Error goal"; }
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
                    avgWeight.Text = allEntered.Average().ToString();
                    minShimWeight.Text = allEntered.Min().ToString();
                    maxShimWeight.Text = allEntered.Max().ToString();
                    double average = allEntered.Average();
                    double sumOfSquaresOfDifferences = allEntered.Select(val => (val - average) * (val - average)).Sum();
                    double sd = Math.Sqrt(sumOfSquaresOfDifferences / allEntered.Count);
                    stDev.Text = sd.ToString();
                    //goalWeightLabel.Text = 
                    try { goalWeightLabel.Text= (Convert.ToDouble(goalWeightInput.Text) - allEntered.Sum()).ToString(); } catch { goalWeightLabel.Text = "Error goal"; }

                }
                else
                {
                    PrevBox.Text = "0";
                    avgWeight.Text = "0";
                    minShimWeight.Text = "0";
                    maxShimWeight.Text = "0";
                    stDev.Text = "0";
                    try { goalWeightLabel.Text = (Convert.ToDouble(goalWeightInput.Text) - allEntered.Sum()).ToString(); } catch { goalWeightLabel.Text = "Error goal"; }
                }
            }
            
        }

        private void enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter input in text box. Click button to add nums. Undo removes previous input and clear removes all. Save saves to file, and print displays current weight and count and clears current total. Enter a goal to aim for for the day. also, the add variable weight adds what the user sets on button click. ");
                  
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
            avgWeight.Text = "0";
            minShimWeight.Text = "0";
            maxShimWeight.Text = "0";
            stDev.Text = "0";
            try { goalWeightLabel.Text = (Convert.ToDouble(goalWeightInput.Text) - allEntered.Sum()).ToString(); } catch { goalWeightLabel.Text = "Error goal"; }

        }
        //This prints the current info to C:\Users\Public/WriteText.txt and overwrites every time 
        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string text = "Date: "  + now + "\n" + "Total weight: " + runningTotal +"\n"+ "Count of shims: " + countNum + "\n" + "Avg weight of shim: " + runningTotal/countNum
                +"\nAmount left for goal: " +goalWeightLabel.Text;
            System.IO.File.WriteAllText(@"C:\Users\Public/AddNums.txt", text);
            MessageBox.Show("File written to "+@"C:/Users/Public/AddNums.txt");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is made for steel workers as a way to easily add shims to their weight totals. For any help please contact Collin.Krueger@cuw.edu.");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void goalWeightInput_TextChanged(object sender, EventArgs e)
        {
            try { goalWeightLabel.Text = (Convert.ToDouble(goalWeightInput.Text) - allEntered.Sum()).ToString(); } catch { goalWeightLabel.Text = "Error goal"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                input = Convert.ToDouble(varWeight.Text);
                this.InputBox.Text = "";
                double output = input;
                runningTotal += input;
                PrevBox.Text = Convert.ToString(output);
                TotalBox.Text = Convert.ToString(runningTotal);
                allEntered.Add(input);
                countNum += 1;
                count.Text = countNum.ToString();
                ErrorBox.Text = "";
                avgWeight.Text = allEntered.Average().ToString();
                minShimWeight.Text = allEntered.Min().ToString();
                maxShimWeight.Text = allEntered.Max().ToString();
                double average = allEntered.Average();
                double sumOfSquaresOfDifferences = allEntered.Select(val => (val - average) * (val - average)).Sum();
                double sd = Math.Sqrt(sumOfSquaresOfDifferences / allEntered.Count);
                stDev.Text = sd.ToString();
                try { goalWeightLabel.Text = (Convert.ToDouble(goalWeightInput.Text) - allEntered.Sum()).ToString(); } catch { goalWeightLabel.Text = "Error goal"; }

            }
            catch
            {

                ErrorBox.Text = "Incorrect input";

            }
        }
    }
}
