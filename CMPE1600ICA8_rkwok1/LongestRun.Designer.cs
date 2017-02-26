namespace CMPE1600ICA8_rkwok1
{
    partial class LongestRun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_Label_Dialog_LongestRun = new System.Windows.Forms.Label();
            this.UI_RadioButton_Dialog_Zeros = new System.Windows.Forms.RadioButton();
            this.UI_RadioButton_Dialog_Ones = new System.Windows.Forms.RadioButton();
            this.UI_Button_Dialog_OK = new System.Windows.Forms.Button();
            this.UI_Button_Dialog_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Label_Dialog_LongestRun
            // 
            this.UI_Label_Dialog_LongestRun.AutoSize = true;
            this.UI_Label_Dialog_LongestRun.Location = new System.Drawing.Point(12, 9);
            this.UI_Label_Dialog_LongestRun.Name = "UI_Label_Dialog_LongestRun";
            this.UI_Label_Dialog_LongestRun.Size = new System.Drawing.Size(44, 13);
            this.UI_Label_Dialog_LongestRun.TabIndex = 0;
            this.UI_Label_Dialog_LongestRun.Text = "Run Of:";
            // 
            // UI_RadioButton_Dialog_Zeros
            // 
            this.UI_RadioButton_Dialog_Zeros.AutoSize = true;
            this.UI_RadioButton_Dialog_Zeros.Location = new System.Drawing.Point(13, 36);
            this.UI_RadioButton_Dialog_Zeros.Name = "UI_RadioButton_Dialog_Zeros";
            this.UI_RadioButton_Dialog_Zeros.Size = new System.Drawing.Size(52, 17);
            this.UI_RadioButton_Dialog_Zeros.TabIndex = 1;
            this.UI_RadioButton_Dialog_Zeros.TabStop = true;
            this.UI_RadioButton_Dialog_Zeros.Text = "Zeros";
            this.UI_RadioButton_Dialog_Zeros.UseVisualStyleBackColor = true;
            // 
            // UI_RadioButton_Dialog_Ones
            // 
            this.UI_RadioButton_Dialog_Ones.AutoSize = true;
            this.UI_RadioButton_Dialog_Ones.Location = new System.Drawing.Point(13, 59);
            this.UI_RadioButton_Dialog_Ones.Name = "UI_RadioButton_Dialog_Ones";
            this.UI_RadioButton_Dialog_Ones.Size = new System.Drawing.Size(50, 17);
            this.UI_RadioButton_Dialog_Ones.TabIndex = 2;
            this.UI_RadioButton_Dialog_Ones.TabStop = true;
            this.UI_RadioButton_Dialog_Ones.Text = "Ones";
            this.UI_RadioButton_Dialog_Ones.UseVisualStyleBackColor = true;
            // 
            // UI_Button_Dialog_OK
            // 
            this.UI_Button_Dialog_OK.Location = new System.Drawing.Point(12, 111);
            this.UI_Button_Dialog_OK.Name = "UI_Button_Dialog_OK";
            this.UI_Button_Dialog_OK.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Dialog_OK.TabIndex = 3;
            this.UI_Button_Dialog_OK.Text = "OK";
            this.UI_Button_Dialog_OK.UseVisualStyleBackColor = true;
            // 
            // UI_Button_Dialog_Cancel
            // 
            this.UI_Button_Dialog_Cancel.Location = new System.Drawing.Point(206, 111);
            this.UI_Button_Dialog_Cancel.Name = "UI_Button_Dialog_Cancel";
            this.UI_Button_Dialog_Cancel.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Dialog_Cancel.TabIndex = 4;
            this.UI_Button_Dialog_Cancel.Text = "Cancel";
            this.UI_Button_Dialog_Cancel.UseVisualStyleBackColor = true;
            // 
            // LongestRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 146);
            this.ControlBox = false;
            this.Controls.Add(this.UI_Button_Dialog_Cancel);
            this.Controls.Add(this.UI_Button_Dialog_OK);
            this.Controls.Add(this.UI_RadioButton_Dialog_Ones);
            this.Controls.Add(this.UI_RadioButton_Dialog_Zeros);
            this.Controls.Add(this.UI_Label_Dialog_LongestRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LongestRun";
            this.Text = "LongestRun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Label_Dialog_LongestRun;
        private System.Windows.Forms.RadioButton UI_RadioButton_Dialog_Zeros;
        private System.Windows.Forms.RadioButton UI_RadioButton_Dialog_Ones;
        private System.Windows.Forms.Button UI_Button_Dialog_OK;
        private System.Windows.Forms.Button UI_Button_Dialog_Cancel;
    }
}