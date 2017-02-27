namespace CMPE1600ICA8_rkwok1
{
    partial class NumberOfRuns
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
            this.UI_Label_Dialog_OnesRunLength = new System.Windows.Forms.Label();
            this.UI_NumUD_Dialog_OnesRunLength = new System.Windows.Forms.NumericUpDown();
            this.UI_Button_Dialog_OK1 = new System.Windows.Forms.Button();
            this.UI_Button_Dialog_Cancel1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumUD_Dialog_OnesRunLength)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Label_Dialog_OnesRunLength
            // 
            this.UI_Label_Dialog_OnesRunLength.AutoSize = true;
            this.UI_Label_Dialog_OnesRunLength.Location = new System.Drawing.Point(13, 38);
            this.UI_Label_Dialog_OnesRunLength.Name = "UI_Label_Dialog_OnesRunLength";
            this.UI_Label_Dialog_OnesRunLength.Size = new System.Drawing.Size(94, 13);
            this.UI_Label_Dialog_OnesRunLength.TabIndex = 0;
            this.UI_Label_Dialog_OnesRunLength.Text = "Ones Run Length:";
            // 
            // UI_NumUD_Dialog_OnesRunLength
            // 
            this.UI_NumUD_Dialog_OnesRunLength.Location = new System.Drawing.Point(114, 38);
            this.UI_NumUD_Dialog_OnesRunLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_NumUD_Dialog_OnesRunLength.Name = "UI_NumUD_Dialog_OnesRunLength";
            this.UI_NumUD_Dialog_OnesRunLength.Size = new System.Drawing.Size(120, 20);
            this.UI_NumUD_Dialog_OnesRunLength.TabIndex = 1;
            this.UI_NumUD_Dialog_OnesRunLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_NumUD_Dialog_OnesRunLength.ValueChanged += new System.EventHandler(this.UI_NumUD_Dialog_OnesRunLength_ValueChanged);
            // 
            // UI_Button_Dialog_OK1
            // 
            this.UI_Button_Dialog_OK1.Location = new System.Drawing.Point(16, 84);
            this.UI_Button_Dialog_OK1.Name = "UI_Button_Dialog_OK1";
            this.UI_Button_Dialog_OK1.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Dialog_OK1.TabIndex = 2;
            this.UI_Button_Dialog_OK1.Text = "OK";
            this.UI_Button_Dialog_OK1.UseVisualStyleBackColor = true;
            this.UI_Button_Dialog_OK1.Click += new System.EventHandler(this.UI_Button_Dialog_OK1_Click);
            // 
            // UI_Button_Dialog_Cancel1
            // 
            this.UI_Button_Dialog_Cancel1.Location = new System.Drawing.Point(213, 84);
            this.UI_Button_Dialog_Cancel1.Name = "UI_Button_Dialog_Cancel1";
            this.UI_Button_Dialog_Cancel1.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Dialog_Cancel1.TabIndex = 3;
            this.UI_Button_Dialog_Cancel1.Text = "Cancel";
            this.UI_Button_Dialog_Cancel1.UseVisualStyleBackColor = true;
            this.UI_Button_Dialog_Cancel1.Click += new System.EventHandler(this.UI_Button_Dialog_Cancel1_Click);
            // 
            // NumberOfRuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 119);
            this.Controls.Add(this.UI_Button_Dialog_Cancel1);
            this.Controls.Add(this.UI_Button_Dialog_OK1);
            this.Controls.Add(this.UI_NumUD_Dialog_OnesRunLength);
            this.Controls.Add(this.UI_Label_Dialog_OnesRunLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NumberOfRuns";
            this.Text = "NumberOfRuns";
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumUD_Dialog_OnesRunLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Label_Dialog_OnesRunLength;
        private System.Windows.Forms.NumericUpDown UI_NumUD_Dialog_OnesRunLength;
        private System.Windows.Forms.Button UI_Button_Dialog_OK1;
        private System.Windows.Forms.Button UI_Button_Dialog_Cancel1;
    }
}