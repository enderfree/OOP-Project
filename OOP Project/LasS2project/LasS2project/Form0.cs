//Samuel Fauteux
//03/08/2021
/* Lasalle Session 2 OOP Project 1: 
 * This project has a dashboard that let the user chose between many function.
 * The Form0 is this dashboard
 * Form1+2 let the users generate a random lotto max or 649 numbers
 * Form3 is a simple calculator
 * Form4 let you change from one currency to the other
 * Form5 tun C° to f° and the opposite 
 * Form6 display the IPv4 Validator
 */

using System;
using System.Windows.Forms;

namespace LasS2project
{
    public partial class Form0 : Form
    {
        /// <summary>
        /// This is the default constructor, it initialize the components
        /// </summary>
        public Form0()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the exit button, it asks you if you want to leave before closing the application if you say yes
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to leave?", "Close form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close(); //we are in the main form so it actually closes the whole application
            }
        }

        /// <summary>
        /// Open the lotto form for LottoMax and hide this window
        /// </summary>
        private void pbLottoMax_Click(object sender, EventArgs e)
        {
            Form1_2 lottoMax = new Form1_2(false);
            lottoMax.Show();
            Hide();
        }

        /// <summary>
        /// Open the lotto form for Lotto649 and hide this window
        /// </summary>
        private void pb649_Click(object sender, EventArgs e)
        {
            Form1_2 lotto649 = new Form1_2(true);
            lotto649.Show();
            Hide();
        }

        /// <summary>
        /// Open the calculator form and hide this window
        /// </summary>
        private void pbCalculator_Click(object sender, EventArgs e)
        {
            Form3 calculator = new Form3();
            calculator.Show();
            Hide();
        }

        /// <summary>
        /// Open the money exchange form and hide this window
        /// </summary>
        private void pbMoneyExchange_Click(object sender, EventArgs e)
        {
            Form4 exchangeApp = new Form4();
            exchangeApp.Show();
            Hide();
        }

        /// <summary>
        /// Open the temperature convertor form and hide this window
        /// </summary>
        private void pbTemperature_Click(object sender, EventArgs e)
        {
            Form5 temperatureConvertor = new Form5();
            temperatureConvertor.Show();
            Hide();
        }

        /// <summary>
        /// Open the IPv4 validator form and hide this window
        /// </summary>
        private void pbIP_Click(object sender, EventArgs e)
        {
            Form6 ipValidator = new Form6();
            ipValidator.Show();
            Hide();
        }
    }
}
