using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CMPE1600ICA8_rkwok1
{

    public partial class UI_MainForm : Form
    {
        //Global Variables
        List<byte> byteList = new List<byte>();
        bool checkOnes = false;
        int numRunsLength = 1;
        public UI_MainForm()
        {
            InitializeComponent();
        }
        //If user presses Load File Button, load file dialog
        private void UI_Button_LoadFile_Click(object sender, EventArgs e)
        {
            int length = 0;
            int numOnes = 0;
            OpenFile();
            length = CountLength(); //Gets length of file
            UI_Label_FileLength0.Text = length.ToString();
            numOnes = CountOnes(); //Gets number of ones in file
            UI_Label_NumberOfOnes0.Text = numOnes.ToString();
        }
        //If user clicks on LongestRun Button, opens dialog
        private void UI_Button_LongestRun_Click(object sender, EventArgs e)
        {
            //Shows user dialog for longest run
            LongestRun lrDialog = new LongestRun();
            if (DialogResult.OK == lrDialog.ShowDialog())
            {
                checkOnes = lrDialog.useOnes;
                if (checkOnes == true)
                {
                    UI_Label_LongestRunZeros.Text = "Longest Run of Ones: ";
                    //Method to check longest run of ones
                }
                else if (checkOnes == false)
                {
                    UI_Label_LongestRunZeros.Text = "Longest Run of Zeros: ";
                    //Method to check longest run of zeros
                }
            }
        }
        //If user clicks number of ones button, opens dialog and asks for length of ones
        private void UI_Button_NumberOfOnes_Click(object sender, EventArgs e)
        {
            NumberOfRuns nrDialog = new NumberOfRuns();
            if (DialogResult.OK == nrDialog.ShowDialog())
            {
                numRunsLength = nrDialog.pRunLength;
                UI_Label_RunsOfLength.Text = ("Runs of Length" + " " + numRunsLength + ": ");
                //Method to check the number of runs equivalent in length to above value;
            }
            else
            {
                //Do nothing
            }
        }
        ////////////////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        //Attempts to open pre-existing binary file of type dat/bin
        public void OpenFile()
        {
            string sFileName = null; //Holds safe file name
            string pFileName = null; //Holds path name

            if (UI_openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFileName = UI_openFileDialog1.SafeFileName;
                pFileName = UI_openFileDialog1.FileName;
                UI_Label_FileName0.Text = sFileName;

                try
                {

                    FileStream fs = new FileStream(sFileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    byteList = (List<byte>)bf.Deserialize(fs);
                    fs.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Counts Length of File in bytes
        public int CountLength()
        {
            int counter = 0;
            foreach (byte b in byteList)
            {
                counter++;
            }
            return counter;
        }
        //Counts how many ones are set in the binary file in bits
        public int CountOnes()
        {
            int counter = 0;
            try
            {
                for (int i = 0; i < byteList.Count; i++)
                {
                    if ((byteList[i] & 1 << i) > 0)
                    {
                        counter++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Counting Ones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return counter;
        }

        //Method to determine Longest Run based on state of checkOnes
        public void CheckRun()
        {
            //If user has selected zeros, and state of checkOnes is false
            if(checkOnes == false)
            {
                //Determine longest run of zeros
            }
            //else if user has selected ones, and stat of checkOnes is true
            else if( checkOnes == true)
            {
                //Determine longest run of ones
            }
        }

        //Method to determine number of runs of length equal to numRunsLength
        public void RunLengthCheck()
        {

        }
    }

}
