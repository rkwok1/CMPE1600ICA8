using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1600ICA8_rkwok1
{
    public partial class NumberOfRuns : Form
    {
        public int pRunLength
        {
            get
            {
                return (runLength);
            }
        }

        //Global variables
       public int runLength = 1;
        public NumberOfRuns()
        {
            InitializeComponent();
        }
        //If the numeric up down value is changed, set runLength to that value
        private void UI_NumUD_Dialog_OnesRunLength_ValueChanged(object sender, EventArgs e)
        {
            runLength = (int)UI_NumUD_Dialog_OnesRunLength.Value;
        }
        //If user clicks OK button, return runLength to main code
        private void UI_Button_Dialog_OK1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        //If user clicks cancel button, return nothing
        private void UI_Button_Dialog_Cancel1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
