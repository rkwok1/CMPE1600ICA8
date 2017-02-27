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
    public partial class LongestRun : Form
    {
        //Global variables
       public bool useOnes = false;
        public bool pOnes
        {
            get
            {
                return (useOnes);
            }
        }
        public LongestRun()
        {
            InitializeComponent();
        }
        //If user clicks the cancel button, returns DialogResult.Cancel
        private void UI_Button_Dialog_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        //If user clicks the OK button, returns DialogResult.OK
        private void UI_Button_Dialog_OK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }
        //If user clicks zero radio button, then bool for checking ones is set to false
        private void UI_RadioButton_Dialog_Zeros_CheckedChanged(object sender, EventArgs e)
        {
            useOnes = false;
        }
        //If user clicks one radio button, then bool for checking ones is set to true
        private void UI_RadioButton_Dialog_Ones_CheckedChanged(object sender, EventArgs e)
        {
            useOnes = true;
        }
    }
}
