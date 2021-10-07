using System;
using System.Windows.Forms;

namespace LasS2project
{
    public partial class Form5 : Form
    {
        const string saveFileName = "TempConversions.txt";

        /// <summary>
        /// This is the default constructor, it initialize the components
        /// </summary>
        public Form5()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exchage the content of the to and from label when the conversion is switched to this mode
        /// </summary>
        private void rbCToF_CheckedChanged(object sender, EventArgs e)
        {
            lbFrom.Text = "C";
            lbTo.Text = "F";
        }

        /// <summary>
        /// Exchage the content of the to and from label when the conversion is switched to this mode
        /// </summary>
        private void rbFToC_CheckedChanged(object sender, EventArgs e)
        {
            lbFrom.Text = "F";
            lbTo.Text = "C";
        }

        /// <summary>
        /// assign a message in the message textbox is the temperature as a precise value
        /// </summary>
        /// <param name="tempC">the temperature</param>
        void AssingMessage(double tempC)
        {
            if (tempC == 100)
            {
                txtMessage.Text = "Water boils";
            }
            else if (tempC == 40)
            {
                txtMessage.Text = "Hot Bath";
            }
            else if (tempC == 37)
            {
                txtMessage.Text = "Body temperature";
            }
            else if (tempC == 30)
            {
                txtMessage.Text = "Beach weather";
            }
            else if (tempC == 21)
            {
                txtMessage.Text = "Room temperature";
            }
            else if (tempC == 10)
            {
                txtMessage.Text = "Cool Day";
            }
            else if (tempC == 0)
            {
                txtMessage.Text = "Freezing point of water";
            }
            else if (tempC == -18)
            {
                txtMessage.Text = "Very Cold Day";
            }
            else if (tempC == -40)
            {
                txtMessage.Text = "Extremely Cold Day" + Environment.NewLine + "(and the same number!)";
            }
            else
            {
                txtMessage.Text = "";
            }
        }

        /// <summary>
        /// makes the conversions, saves them and display the result if the format is correct, else warn the user with a MessageBox
        /// </summary>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtFrom.Text, out double value))
            {
                string line = txtFrom.Text;
                if(rbCToF.Checked)
                {
                    AssingMessage(value);
                    line += " C = ";
                    value = value * 9 / 5 + 32;
                    line += value + " F, " + DateTime.Now;
                }
                else
                {
                    line += " F = ";
                    value = (value - 32) * 5 / 9;
                    line += value + " C, " + DateTime.Now;
                    AssingMessage(value);
                }

                Common.Append(saveFileName, line);
                txtTo.Text = value.ToString();
            }
            else
            {
                MessageBox.Show("Format unrecognised!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Show the temperature conversion log in a MessageBox
        /// </summary>
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            Common.ShowLog(saveFileName, "Temperature conversions");
        }

        /// <summary>
        /// Show the main for and close this on
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Common.ShowForm0();
            Close();
        }
    }
}
