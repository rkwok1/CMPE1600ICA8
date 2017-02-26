namespace CMPE1600ICA8_rkwok1
{
    partial class Form1
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
            this.UI_Button_LoadFile = new System.Windows.Forms.Button();
            this.UI_Button_LongestRun = new System.Windows.Forms.Button();
            this.UI_Button_NumberOfOnes = new System.Windows.Forms.Button();
            this.UI_Label_FileName = new System.Windows.Forms.Label();
            this.UI_Label_FileLength = new System.Windows.Forms.Label();
            this.UI_Label_NumberOfOnes = new System.Windows.Forms.Label();
            this.UI_Label_LongestRunZeros = new System.Windows.Forms.Label();
            this.UI_Label_RunsOfLength = new System.Windows.Forms.Label();
            this.UI_Label_FileName0 = new System.Windows.Forms.Label();
            this.UI_Label_FileLength0 = new System.Windows.Forms.Label();
            this.UI_Label_NumberOfOnes0 = new System.Windows.Forms.Label();
            this.UI_Label_LongestRunOfZeros0 = new System.Windows.Forms.Label();
            this.UI_Label_RunOfLength0 = new System.Windows.Forms.Label();
            this.UI_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_Button_LoadFile
            // 
            this.UI_Button_LoadFile.Location = new System.Drawing.Point(13, 13);
            this.UI_Button_LoadFile.Name = "UI_Button_LoadFile";
            this.UI_Button_LoadFile.Size = new System.Drawing.Size(108, 23);
            this.UI_Button_LoadFile.TabIndex = 0;
            this.UI_Button_LoadFile.Text = "Load File";
            this.UI_Button_LoadFile.UseVisualStyleBackColor = true;
            this.UI_Button_LoadFile.Click += new System.EventHandler(this.UI_Button_LoadFile_Click);
            // 
            // UI_Button_LongestRun
            // 
            this.UI_Button_LongestRun.Location = new System.Drawing.Point(13, 161);
            this.UI_Button_LongestRun.Name = "UI_Button_LongestRun";
            this.UI_Button_LongestRun.Size = new System.Drawing.Size(108, 23);
            this.UI_Button_LongestRun.TabIndex = 1;
            this.UI_Button_LongestRun.Text = "Longest Run";
            this.UI_Button_LongestRun.UseVisualStyleBackColor = true;
            this.UI_Button_LongestRun.Click += new System.EventHandler(this.UI_Button_LongestRun_Click);
            // 
            // UI_Button_NumberOfOnes
            // 
            this.UI_Button_NumberOfOnes.Location = new System.Drawing.Point(13, 203);
            this.UI_Button_NumberOfOnes.Name = "UI_Button_NumberOfOnes";
            this.UI_Button_NumberOfOnes.Size = new System.Drawing.Size(108, 23);
            this.UI_Button_NumberOfOnes.TabIndex = 2;
            this.UI_Button_NumberOfOnes.Text = "Number of Ones";
            this.UI_Button_NumberOfOnes.UseVisualStyleBackColor = true;
            // 
            // UI_Label_FileName
            // 
            this.UI_Label_FileName.AutoSize = true;
            this.UI_Label_FileName.Location = new System.Drawing.Point(13, 55);
            this.UI_Label_FileName.Name = "UI_Label_FileName";
            this.UI_Label_FileName.Size = new System.Drawing.Size(57, 13);
            this.UI_Label_FileName.TabIndex = 3;
            this.UI_Label_FileName.Text = "File Name:";
            // 
            // UI_Label_FileLength
            // 
            this.UI_Label_FileLength.AutoSize = true;
            this.UI_Label_FileLength.Location = new System.Drawing.Point(13, 81);
            this.UI_Label_FileLength.Name = "UI_Label_FileLength";
            this.UI_Label_FileLength.Size = new System.Drawing.Size(62, 13);
            this.UI_Label_FileLength.TabIndex = 4;
            this.UI_Label_FileLength.Text = "File Length:";
            // 
            // UI_Label_NumberOfOnes
            // 
            this.UI_Label_NumberOfOnes.AutoSize = true;
            this.UI_Label_NumberOfOnes.Location = new System.Drawing.Point(13, 109);
            this.UI_Label_NumberOfOnes.Name = "UI_Label_NumberOfOnes";
            this.UI_Label_NumberOfOnes.Size = new System.Drawing.Size(87, 13);
            this.UI_Label_NumberOfOnes.TabIndex = 5;
            this.UI_Label_NumberOfOnes.Text = "Number of Ones:";
            // 
            // UI_Label_LongestRunZeros
            // 
            this.UI_Label_LongestRunZeros.AutoSize = true;
            this.UI_Label_LongestRunZeros.Location = new System.Drawing.Point(140, 166);
            this.UI_Label_LongestRunZeros.Name = "UI_Label_LongestRunZeros";
            this.UI_Label_LongestRunZeros.Size = new System.Drawing.Size(113, 13);
            this.UI_Label_LongestRunZeros.TabIndex = 6;
            this.UI_Label_LongestRunZeros.Text = "Longest Run of Zeros:";
            // 
            // UI_Label_RunsOfLength
            // 
            this.UI_Label_RunsOfLength.AutoSize = true;
            this.UI_Label_RunsOfLength.Location = new System.Drawing.Point(140, 208);
            this.UI_Label_RunsOfLength.Name = "UI_Label_RunsOfLength";
            this.UI_Label_RunsOfLength.Size = new System.Drawing.Size(92, 13);
            this.UI_Label_RunsOfLength.TabIndex = 7;
            this.UI_Label_RunsOfLength.Text = "Runs of Length 8:";
            // 
            // UI_Label_FileName0
            // 
            this.UI_Label_FileName0.AutoSize = true;
            this.UI_Label_FileName0.Location = new System.Drawing.Point(86, 55);
            this.UI_Label_FileName0.Name = "UI_Label_FileName0";
            this.UI_Label_FileName0.Size = new System.Drawing.Size(27, 13);
            this.UI_Label_FileName0.TabIndex = 8;
            this.UI_Label_FileName0.Text = "N/A";
            // 
            // UI_Label_FileLength0
            // 
            this.UI_Label_FileLength0.AutoSize = true;
            this.UI_Label_FileLength0.Location = new System.Drawing.Point(86, 81);
            this.UI_Label_FileLength0.Name = "UI_Label_FileLength0";
            this.UI_Label_FileLength0.Size = new System.Drawing.Size(27, 13);
            this.UI_Label_FileLength0.TabIndex = 9;
            this.UI_Label_FileLength0.Text = "N/A";
            // 
            // UI_Label_NumberOfOnes0
            // 
            this.UI_Label_NumberOfOnes0.AutoSize = true;
            this.UI_Label_NumberOfOnes0.Location = new System.Drawing.Point(106, 109);
            this.UI_Label_NumberOfOnes0.Name = "UI_Label_NumberOfOnes0";
            this.UI_Label_NumberOfOnes0.Size = new System.Drawing.Size(27, 13);
            this.UI_Label_NumberOfOnes0.TabIndex = 10;
            this.UI_Label_NumberOfOnes0.Text = "N/A";
            // 
            // UI_Label_LongestRunOfZeros0
            // 
            this.UI_Label_LongestRunOfZeros0.AutoSize = true;
            this.UI_Label_LongestRunOfZeros0.Location = new System.Drawing.Point(260, 166);
            this.UI_Label_LongestRunOfZeros0.Name = "UI_Label_LongestRunOfZeros0";
            this.UI_Label_LongestRunOfZeros0.Size = new System.Drawing.Size(27, 13);
            this.UI_Label_LongestRunOfZeros0.TabIndex = 11;
            this.UI_Label_LongestRunOfZeros0.Text = "N/A";
            // 
            // UI_Label_RunOfLength0
            // 
            this.UI_Label_RunOfLength0.AutoSize = true;
            this.UI_Label_RunOfLength0.Location = new System.Drawing.Point(238, 208);
            this.UI_Label_RunOfLength0.Name = "UI_Label_RunOfLength0";
            this.UI_Label_RunOfLength0.Size = new System.Drawing.Size(27, 13);
            this.UI_Label_RunOfLength0.TabIndex = 12;
            this.UI_Label_RunOfLength0.Text = "N/A";
            // 
            // UI_openFileDialog1
            // 
            this.UI_openFileDialog1.FileName = "openFileDialog1";
            this.UI_openFileDialog1.Filter = "*.dat||*.bin||*.*|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 249);
            this.Controls.Add(this.UI_Label_RunOfLength0);
            this.Controls.Add(this.UI_Label_LongestRunOfZeros0);
            this.Controls.Add(this.UI_Label_NumberOfOnes0);
            this.Controls.Add(this.UI_Label_FileLength0);
            this.Controls.Add(this.UI_Label_FileName0);
            this.Controls.Add(this.UI_Label_RunsOfLength);
            this.Controls.Add(this.UI_Label_LongestRunZeros);
            this.Controls.Add(this.UI_Label_NumberOfOnes);
            this.Controls.Add(this.UI_Label_FileLength);
            this.Controls.Add(this.UI_Label_FileName);
            this.Controls.Add(this.UI_Button_NumberOfOnes);
            this.Controls.Add(this.UI_Button_LongestRun);
            this.Controls.Add(this.UI_Button_LoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Button_LoadFile;
        private System.Windows.Forms.Button UI_Button_LongestRun;
        private System.Windows.Forms.Button UI_Button_NumberOfOnes;
        private System.Windows.Forms.Label UI_Label_FileName;
        private System.Windows.Forms.Label UI_Label_FileLength;
        private System.Windows.Forms.Label UI_Label_NumberOfOnes;
        private System.Windows.Forms.Label UI_Label_LongestRunZeros;
        private System.Windows.Forms.Label UI_Label_RunsOfLength;
        private System.Windows.Forms.Label UI_Label_FileName0;
        private System.Windows.Forms.Label UI_Label_FileLength0;
        private System.Windows.Forms.Label UI_Label_NumberOfOnes0;
        private System.Windows.Forms.Label UI_Label_LongestRunOfZeros0;
        private System.Windows.Forms.Label UI_Label_RunOfLength0;
        private System.Windows.Forms.OpenFileDialog UI_openFileDialog1;
    }
}

