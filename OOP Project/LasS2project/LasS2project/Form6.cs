using System;
using System.Windows.Forms;

namespace LasS2project
{
    public partial class Form6 : Form
    {
        /// <summary>
        /// this is the default constructor, it initializes the components and put today date in the corresponding label
        /// </summary>
        public Form6()
        {
            InitializeComponent();
            lbToday.Text += DateTime.Now.ToString("MM/dd/yy"); //This is what was requested?
        }

        /// <summary>
        /// checks if the provided IPv4 is valid and tells it to the user with a MessageBox
        /// </summary>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            bool isValidIP = true;
            string[] ipParts = txtIP.Text.Split('.');

            if (ipParts.Length == 4)
            {
                foreach (string ipPart in ipParts)
                {
                    if (!Byte.TryParse(ipPart, out _))
                    {
                        isValidIP = false;
                        break;
                    }
                }
            }
            else
            {
                isValidIP = false;
            }

            if(isValidIP)
            {
                MessageBox.Show(txtIP.Text + "\nThis IP is correct. ", "Valid IP");
            }
            else
            {
                MessageBox.Show(txtIP.Text + "\nThe IP must have 4 bytes\nthose are integers between 0 and 255\nseparated by dots (255.255.255.255)", "Error");
            }
        }

        /// <summary>
        /// clear the text field
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIP.Text = "";
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
