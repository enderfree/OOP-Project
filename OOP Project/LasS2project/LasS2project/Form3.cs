using System;
using System.Linq;
using System.Windows.Forms;

namespace LasS2project
{
    public partial class Form3 : Form
    {
        const string saveFileName = "Calculator.txt";

        string firstOperand = ""; //the first number of the calculation and often, the result of the last one //note: things are cleared after the =
        string secondOperand = ""; //the latest number the user enterd in the calculator
        char currentOperation = ' '; //the opération to perform between the fisrt operand and the second one
        string theOperationSoFar = ""; //the operation done before pressing =

        /// <summary>
        /// This is the default constructor, it initialize the components
        /// </summary>
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// check if the operand starts with a zero and if so, if it is required
        /// </summary>
        /// <returns>true if it start with an unnecesary 0</returns>
        bool CheckIfOperendStartWithUnnessesary0()
        {
            if (txtCalcScreen.Text[0] != '0')
                return false;

            try
            {
                if (txtCalcScreen.Text[1] == '.')
                    return false;
            }
            catch(IndexOutOfRangeException)
            {
                //the string is not 2char long
            }

            return true;
        }

        /// <summary>
        /// writes 1 in the calculator screen when the button 1 is pressed
        /// </summary>
        private void btn1_Click(object sender, EventArgs e)
        {
            if(CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "1";
            }
            else
            {
                txtCalcScreen.Text += "1";
            }
        }

        /// <summary>
        /// writes 2 in the calculator screen when the button 2 is pressed
        /// </summary>
        private void btn2_Click(object sender, EventArgs e)
        {
            if (CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "2";
            }
            else
            {
                txtCalcScreen.Text += "2";
            }
        }

        /// <summary>
        /// writes 3 in the calculator screen when the button 3 is pressed
        /// </summary>
        private void btn3_Click(object sender, EventArgs e)
        {
            if (CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "3";
            }
            else
            {
                txtCalcScreen.Text += "3";
            }
        }

        /// <summary>
        /// writes 4 in the calculator screen when the button 4 is pressed
        /// </summary>
        private void btn4_Click(object sender, EventArgs e)
        {
            if (CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "4";
            }
            else
            {
                txtCalcScreen.Text += "4";
            }
        }

        /// <summary>
        /// writes 5 in the calculator screen when the button 5 is pressed
        /// </summary>
        private void btn5_Click(object sender, EventArgs e)
        {
            if (CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "5";
            }
            else
            {
                txtCalcScreen.Text += "5";
            }
        }

        /// <summary>
        /// writes 6 in the calculator screen when the button 6 is pressed
        /// </summary>
        private void btn6_Click(object sender, EventArgs e)
        {
            if (CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "6";
            }
            else
            {
                txtCalcScreen.Text += "6";
            }
        }

        /// <summary>
        /// writes 7 in the calculator screen when the button 7 is pressed
        /// </summary>
        private void btn7_Click(object sender, EventArgs e)
        {
            if (CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "7";
            }
            else
            {
                txtCalcScreen.Text += "7";
            }
        }

        /// <summary>
        /// writes 8 in the calculator screen when the button 8 is pressed
        /// </summary>
        private void btn8_Click(object sender, EventArgs e)
        {
            if (CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "8";
            }
            else
            {
                txtCalcScreen.Text += "8";
            }
        }

        /// <summary>
        /// writes 9 in the calculator screen when the button 9 is pressed
        /// </summary>
        private void btn9_Click(object sender, EventArgs e)
        {
            if (CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text = "9";
            }
            else
            {
                txtCalcScreen.Text += "9";
            }
        }

        /// <summary>
        /// writes 0 in the calculator screen when the button 0 is pressed
        /// </summary>
        private void btn0_Click(object sender, EventArgs e)
        {
            if (!CheckIfOperendStartWithUnnessesary0())
            {
                txtCalcScreen.Text += "0";
            }
        }

        /// <summary>
        /// add a dot to mark the decimal numbers if there is not already one, else warn the user
        /// </summary>
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtCalcScreen.Text.Contains('.'))
            {
                MessageBox.Show("A number cannot have 2 dots", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtCalcScreen.Text += ".";
            }
        }

        /// <summary>
        /// remove the dot at the end of a string
        /// </summary>
        /// <param name="text">the string to remove a dot from</param>
        /// <returns>the same string without a dot at the end</returns>
        string RemoveTrailingDot(string text)
        {
            int textLastIndex = text.Length - 1;
            if (text[textLastIndex] == '.')
                text = text.Remove(textLastIndex);
            return text;
        }

        /// <summary>
        /// assing the text on the calculator screen in the right operend in order to calculate things
        /// </summary>
        void AssingTxtboxValueInRightOperand()
        {
            if (firstOperand == "")
            {
                firstOperand = txtCalcScreen.Text;
                firstOperand = RemoveTrailingDot(firstOperand);
                theOperationSoFar = firstOperand;
            }
            else
            {
                secondOperand = txtCalcScreen.Text;
                secondOperand = RemoveTrailingDot(secondOperand);
            }
        }

        /// <summary>
        /// check which operation the user tries to perform and perform it
        /// </summary>
        void ApplyDesiredOperation()
        {
            Double.TryParse(firstOperand, out double x);
            Double.TryParse(secondOperand, out double y);

            switch(currentOperation)
            {
                case '+': theOperationSoFar += "+"; Add(x, y); break;
                case '-': theOperationSoFar += "-"; Substract(x, y); break;
                case '*': theOperationSoFar += "*"; Multiply(x, y); break;
                case '/': theOperationSoFar += "/"; Divide(x, y); break;
                default: MessageBox.Show("This operation wasn't recognised.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }

            theOperationSoFar += secondOperand;
        }

        /// <summary>
        /// add x and y together
        /// </summary>
        /// <param name="x">first operand as a double</param>
        /// <param name="y">second operand as a double</param>
        void Add(double x, double y)
        {
            Calculator calc = new Calculator(x, y);
            firstOperand = calc.Add().ToString();
        }

        /// <summary>
        /// substract x from y
        /// </summary>
        /// <param name="x">first operand as a double</param>
        /// <param name="y">second operand as a double</param>
        void Substract(double x, double y)
        {
            Calculator calc = new Calculator(x, y);
            firstOperand = calc.Substract().ToString();
        }

        /// <summary>
        /// multiply x and y together
        /// </summary>
        /// <param name="x">first operand as a double</param>
        /// <param name="y">second operand as a double</param>
        void Multiply(double x, double y)
        {
            Calculator calc = new Calculator(x, y);
            firstOperand = calc.Multiply().ToString();
        }

        /// <summary>
        /// divide x by y and yeild an error if there was one
        /// </summary>
        /// <param name="x">first operand as a double</param>
        /// <param name="y">second operand as a double</param>
        void Divide(double x, double y)
        {
            Calculator calc = new Calculator(x, y);
            string result = calc.Divide();
            if (result == "Error2")
            {
                MessageBox.Show("You divided by 0\nThe result of this operation was not saved.", result, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                firstOperand = result;
            }
        }

        /// <summary>
        /// Apply the current operation and set the next one to be +
        /// </summary>
        private void btnAddition_Click(object sender, EventArgs e)
        {
            AssingTxtboxValueInRightOperand();

            if (secondOperand != "")
            {
                ApplyDesiredOperation();
            }

            currentOperation = '+';
            txtCalcScreen.Text = "0";
        }

        /// <summary>
        /// Apply the current operation and set the next one to be -
        /// </summary>
        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            AssingTxtboxValueInRightOperand();
            
            if (secondOperand != "")
            {
                ApplyDesiredOperation();
            }

            currentOperation = '-';
            txtCalcScreen.Text = "0";
        }

        /// <summary>
        /// Apply the current operation and set the next one to be *
        /// </summary>
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            AssingTxtboxValueInRightOperand();
            
            if (secondOperand != "")
            {
                ApplyDesiredOperation();
            }

            currentOperation = '*';
            txtCalcScreen.Text = "0";
        }

        /// <summary>
        /// Apply the current operation and set the next one to be /
        /// </summary>
        private void btnDivision_Click(object sender, EventArgs e)
        {
            AssingTxtboxValueInRightOperand();
            
            if (secondOperand != "")
            {
                ApplyDesiredOperation();
            }

            currentOperation = '/';
            txtCalcScreen.Text = "0";
        }

        /// <summary>
        /// set all the class variable and the screen of the calculator to their default value
        /// </summary>
        void ResetValues()
        {
            firstOperand = "";
            secondOperand = "";
            currentOperation = ' ';
            theOperationSoFar = "";

            txtCalcScreen.Text = "0";
        }

        /// <summary>
        /// finalize the operation, save it and display it in the calculator screen
        /// </summary>
        private void btnEqual_Click(object sender, EventArgs e) //you cannot apply an operation on the result, othewise, everything is fine
        {
            AssingTxtboxValueInRightOperand(); //I don't think performing operations on the result was asked anyways so instead of putting flags I will move on
            if (firstOperand == "")
            {
                firstOperand = "0";
                theOperationSoFar = "0";
            }

            if (secondOperand != "")
            {
                ApplyDesiredOperation();
            }

            theOperationSoFar += "=" + firstOperand;

            Common.Append(saveFileName, theOperationSoFar);

            string temp = firstOperand;
            ResetValues();
            txtCalcScreen.Text = temp;
            firstOperand = temp;
        }

        /// <summary>
        /// reset values
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        /// <summary>
        /// show the main form and close this one
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Common.ShowForm0();
            Close();
        }
    }
}
