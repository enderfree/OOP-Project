using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LasS2project
{
    public partial class Form4 : Form
    {
        const string saveFileName = "MoneyConversions.txt";

        /// <summary>
        /// This is the default constructor, it initialize the components
        /// </summary>
        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When this button is clicked, it verifies that the entered number fit the prerequisite or shows an error in a MessageBox
        /// If the value format is accepted, it convert this amount in CAD before converting it in another if needed/requested
        /// And finally it saves this conveersion in a txt file
        /// </summary>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string textInput = txtInputAmmount.Text;
            Regex twoDecimals = new Regex(@"^[0-9]+\.?[0-9]{0,2}$");

            if (twoDecimals.IsMatch(textInput) && textInput[textInput.Length - 1] != '.')
            {
                string txtline = textInput;
                Double.TryParse(textInput, out double value);
                //turns the value in CAD
                if (rbFromUSD.Checked)
                {
                    value *= 1.26; //all those change rates are from google 04/03/2021
                    txtline += " USD = ";
                }
                else if (rbFromEUR.Checked)
                {
                    value *= 1.48;
                    txtline += " EUR = ";
                }
                else if(rbFromGBP.Checked)
                {
                    value *= 1.74;
                    txtline += " GBP = ";
                }
                else if(rbFromRUB.Checked)
                {
                    value *= 0.016;
                    txtline += " RUB = ";
                }
                else
                {
                    txtline += " CAD = ";
                }

                //Convert CAD in something else
                string toType;
                if(rbToUSD.Checked)
                {
                    value /= 1.26;
                    toType = " USD, ";
                }
                else if(rbToEUR.Checked)
                {
                    value /= 1.48;
                    toType = " EUR, ";
                }
                else if(rbToGBP.Checked)
                {
                    value /= 1.74;
                    toType = " GBP, ";
                }
                else if(rbToRUB.Checked)
                {
                    value /= 0.016;
                    toType = " RUB, ";
                }
                else
                {
                    toType = " CAD, ";
                }

                txtOutputAmmount.Text = Math.Round(value, 2).ToString(); 
                txtline += txtOutputAmmount.Text + toType + DateTime.Now;

                Common.Append(saveFileName, txtline);

                txtInputAmmount.Focus();
            }
            else
            {
                MessageBox.Show("The inputed value is not in an accepted format!\n(the value have a max of two decimal and no symbol, e.g. 32.43)", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Shows the conversion log
        /// </summary>
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            Common.ShowLog(saveFileName, "Stored Conversions");
        }

        /// <summary>
        /// Asks if the user want to quit before quitting
        /// if yes, show the main form and close this one
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Doyou want\nto quit the application\nMoney Exchange?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Common.ShowForm0();
                Close();
            }
        }
    }
}
