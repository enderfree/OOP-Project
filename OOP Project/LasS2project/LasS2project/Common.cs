using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace LasS2project
{
    class Common
    {
        /// <summary>
        /// Show the main form
        /// </summary>
        public static void ShowForm0()
        {
            Form0 form0 = Application.OpenForms.Cast<Form0>().First();
            form0.Show();
        }

        /// <summary>
        /// I used to have an overcomplicated way to save the files so I made a metod but now it is way simpler, I kept the old way as a comment as a momento
        /// </summary>
        /// <param name="saveFilePath">the path of the file to create or open</param>
        /// <param name="lineToWrite">the line to add to the save file</param>
        public static void Append(string saveFilePath, string lineToWrite)
        {
            //bool fileDoesExist = false;
            //if (File.Exists(saveFileName))
            //    fileDoesExist = true;

            //FileStream fs = new FileStream(saveFileName, FileMode.OpenOrCreate, FileAccess.Write);
            //if (fileDoesExist)
            //{
            //    fs.Close();
            FileStream fs = new FileStream(saveFilePath, FileMode.Append, FileAccess.Write);
            //}
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(lineToWrite);
            sw.Close();
        }

        /// <summary>
        /// Show all lines of a save file, one by one, in a MessageBox with a cancel button in case this is getting to long
        /// If the file doesn't exist, it warns the user instead
        /// </summary>
        /// <param name="saveFilePath">the save file to open path</param>
        /// <param name="messageBoxTitle">the title of the MessageBox in which all the lines will be displayed</param>
        public static void ShowLog(string saveFilePath, string messageBoxTitle)
        {
            if (File.Exists(saveFilePath))
            {
                FileStream fs = new FileStream(saveFilePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string fullSaveFile = sr.ReadToEnd();
                sr.Close();
                //string[] lines = fullSaveFile.Split('\n');

                //foreach (string line in lines)
                //{
                    if (MessageBox.Show(/*line*/fullSaveFile, messageBoxTitle, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        //break;
                //}
            }
            else
            {
                MessageBox.Show("The file does not exist yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
