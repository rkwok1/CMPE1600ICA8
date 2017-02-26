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
        bool runSet = false;
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
    }
}
