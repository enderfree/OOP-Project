using System;
using System.Windows.Forms;
using System.IO;

namespace LasS2project
{
    public partial class Form1_2 : Form
    {
        const string saveFileName = "LottoNbrs.txt"; //all my save file are beside the .exe 
        bool generate8no = false; //this is the main difference between LottoMax and Lotto649 so I decided to rename it like that since it was why I created this variable but in the end I used it as a isLottoX

        /// <summary>
        /// this is the default constructor, I used it to test a few things but should not be called by the application once finished, it only initialyses the components
        /// </summary>
        public Form1_2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the constructor over loaded with a boolean value, it initializes the component, changes the title of the form and tell if we generat8no or not
        /// </summary>
        /// <param name="is649">defines if this form is generated for 649 or not</param>
        public Form1_2(bool is649)
        {
            InitializeComponent();

            if(is649)
            {
                Text = "Lotto 649 - Samuel";
            }
            else
            {
                Text = "Lotto Max - Samuel";
                generate8no = true;
            }
        }

        /// <summary>
        /// generates the random lotto numbers and the extra
        /// </summary>
        /// <param name="lottoNbs">the generated lotto numbers</param>
        /// <param name="extra">the generated extra</param>
        void GenerateLottoNb(out string lottoNbs, out byte extra)
        {
            Random r = new Random();
            byte nbOfNbToGenerate = 7;
            byte noMaxValue = 49;

            if (generate8no)
            {
                nbOfNbToGenerate = 8;
                noMaxValue = 50;
            }

            lottoNbs = "";
            for (int i = 0; i < nbOfNbToGenerate - 1; ++i)
            {
                lottoNbs += r.Next(1, noMaxValue).ToString();
                if (i < nbOfNbToGenerate - 2)
                    lottoNbs += ",";
            }
            extra = Convert.ToByte(r.Next(1, noMaxValue));
        }

        /// <summary>
        /// Replace a specified line in the save file by an other one generated in this function based on the lotto info
        /// </summary>
        /// <param name="lineToModify">the line to replace</param>
        /// <param name="lottoNbs">the lotto numbers</param>
        /// <param name="extra">the lotto extra</param>
        /// <param name="save">the entire content of the save file as a string</param>
        void ReplaceLineInSaveFile(string lineToModify, string lottoNbs, byte extra, string save)
        {
            string modifiedLine = "";
            try
            {
                modifiedLine = lineToModify.Split(' ')[0].Split(',')[0] + "," + DateTime.Now + ",  " + lottoNbs + " Extra " + extra;
            }
            catch (IOException)
            {
                MessageBox.Show("The file " + saveFileName + " exist but is invalid, deleting it will fix this problem.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The file " + saveFileName + " exist but is invalid, deleting it will fix this problem.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            save = save.Replace(lineToModify, modifiedLine);
            FileStream fs = new FileStream(saveFileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(save);
            sw.Close();
        }

        /// <summary>
        /// save the lotto informations in a txt file
        /// </summary>
        /// <param name="lottoNbs">the lotto numbers</param>
        /// <param name="extra">the lotto extra</param>
        void Save(string lottoNbs, byte extra)
        {
            bool fileDoesExist = true;
            if (!File.Exists(saveFileName))
                fileDoesExist = false;

            FileStream fs = new FileStream(saveFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //Creates the file with some basic informations if it doesn't already exist
            if (!fileDoesExist)
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Max," + DateTime.Now + ",  NAN Extra NAN");
                sw.WriteLine("649," + DateTime.Now + ",  NAN Extra NAN");
                sw.Close();
            }

            fs.Close(); //if The file had to be created, it will already be closed
            fs = new FileStream(saveFileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string save = sr.ReadToEnd();
            sr.BaseStream.Position = 0; //it should be it's default value
            string lineToModify = sr.ReadLine();

            //Current goal: replace the first line of the if and else with well understood sr elements, I already moved the sr close //SUCCESS!
            if (generate8no)
            {
                sr.Close();
                ReplaceLineInSaveFile(lineToModify, lottoNbs, extra, save);
            }
            else
            {
                lineToModify = sr.ReadLine();
                sr.Close();
                ReplaceLineInSaveFile(lineToModify, lottoNbs, extra, save);
            }
        }

        /// <summary>
        /// Generate the lotto numbers and the extra, save them in a txt file and display them
        /// </summary>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateLottoNb(out string lottoNbs, out byte extra);
            Save(lottoNbs, extra);
            txtLottoNb.Text = lottoNbs.Replace(",", Environment.NewLine) + Environment.NewLine + extra;
        }

        /// <summary>
        /// Display the content of the lotto save file (the latest LottoMax and latest 649) in a MessageBox
        /// </summary>
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(saveFileName))
            {
                FileStream fs = new FileStream(saveFileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                MessageBox.Show(sr.ReadToEnd());
            }
            else
            {
                MessageBox.Show("This file doesn't exist yet!");
            }
        }

        /// <summary>
        /// Asks if the user really wants to quit and if so, show the main form before closing this one
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit this application?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Common.ShowForm0();
                Close();
            }
        }
    }
}
