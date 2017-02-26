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

    public partial class Form1 : Form
    {
        //Global Variables
        List<byte> byteList = new List<byte>();
        public Form1()
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
        ////////////////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
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
                    List<byte>byteList = (List<byte>)bf.Deserialize(fs);
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
                    if((byteList[i] & 1 << i) > 0)
                    {
                        counter++;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Counting Ones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return counter;
        }
    }

}
