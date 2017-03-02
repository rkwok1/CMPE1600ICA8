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
                    UI_Label_LongestRunOfZeros0.Text = CheckRun().ToString();
                }
                else if (checkOnes == false)
                {
                    UI_Label_LongestRunZeros.Text = "Longest Run of Zeros: ";
                    UI_Label_LongestRunOfZeros0.Text = CheckRun().ToString();
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
                    BinaryReader bf = new BinaryReader(fs);
                    for (int i = 0; i < fs.Length; i++)
                    {
                        byteList.Add(bf.ReadByte());
                    }
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
                foreach (byte b in byteList)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if ((b & (1 << i)) >= 1)
                        {
                            counter++;
                        }
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
        public int CheckRun()
        {
            bool gapState = false;
            bool runState = false;
            int counter = 0;
            int longestRun = 0;
            //If user has selected zeros, and state of checkOnes is false
            if (checkOnes == false)
            {
                foreach (byte b in byteList)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (((b & (1 << i)) == 0) && gapState == false)
                        {
                            gapState = true;
                                counter++;

                            

                        }
                        else if (((b & (1 << i)) == 0))
                        {
                            counter++;
                        }
                        else if (!((b & (1 << i)) == 0))
                        {

                            gapState = false;
                            if (counter > longestRun)
                            {
                                longestRun = counter;
                            }
                            counter = 0;
                        }

                    }

                }
            }
            //else if user has selected ones, and stat of checkOnes is true
            else if (checkOnes == true)
            {
                foreach (byte b in byteList)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (((b & (1 << i)) > 0) && (runState == false))
                        {
                            runState = true;
       
                                counter++;

                        }
                        else if (((b & (1 << i)) > 0))
                        {
                            counter++;
                        }
                        else if (((b & (1 << i)) == 0))
                        {
                            runState = false;
                            if (counter > longestRun)
                            {
                                longestRun = counter;
                            }
                            counter = 0;
                        }

                    }
                }
            }
            return longestRun;
        }

        //Method to determine number of runs of length equal to numRunsLength
        public void RunLengthCheck()
        {
            int counter = 0;
            int runsOf = 0;
            foreach (byte b in byteList)
            {

            }

        }
    }

}
