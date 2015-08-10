namespace NQueensGenetic
{
    partial class MainForm
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
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.fitnessLabel = new System.Windows.Forms.Label();
            this.fitnessTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.BoardPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartStopBtn.Location = new System.Drawing.Point(12, 630);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(75, 23);
            this.StartStopBtn.TabIndex = 0;
            this.StartStopBtn.Text = "Start";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            this.StartStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // fitnessLabel
            // 
            this.fitnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fitnessLabel.AutoSize = true;
            this.fitnessLabel.Location = new System.Drawing.Point(308, 636);
            this.fitnessLabel.Name = "fitnessLabel";
            this.fitnessLabel.Size = new System.Drawing.Size(43, 13);
            this.fitnessLabel.TabIndex = 2;
            this.fitnessLabel.Text = "Fitness:";
            // 
            // fitnessTextBox
            // 
            this.fitnessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fitnessTextBox.Location = new System.Drawing.Point(357, 633);
            this.fitnessTextBox.Name = "fitnessTextBox";
            this.fitnessTextBox.ReadOnly = true;
            this.fitnessTextBox.Size = new System.Drawing.Size(52, 20);
            this.fitnessTextBox.TabIndex = 3;
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(137, 636);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "Size:";
            // 
            // sizeNumUpDown
            // 
            this.sizeNumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sizeNumUpDown.Location = new System.Drawing.Point(173, 633);
            this.sizeNumUpDown.Name = "sizeNumUpDown";
            this.sizeNumUpDown.Size = new System.Drawing.Size(58, 20);
            this.sizeNumUpDown.TabIndex = 7;
            this.sizeNumUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // BoardPicBox
            // 
            this.BoardPicBox.ErrorImage = null;
            this.BoardPicBox.Location = new System.Drawing.Point(10, 10);
            this.BoardPicBox.Name = "BoardPicBox";
            this.BoardPicBox.Size = new System.Drawing.Size(600, 600);
            this.BoardPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoardPicBox.TabIndex = 0;
            this.BoardPicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time (s):";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeTextBox.Location = new System.Drawing.Point(506, 633);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(52, 20);
            this.timeTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 661);
            this.Controls.Add(this.sizeNumUpDown);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.fitnessTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fitnessLabel);
            this.Controls.Add(this.StartStopBtn);
            this.Controls.Add(this.BoardPicBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoardPicBox;
        private System.Windows.Forms.Button StartStopBtn;
        private System.Windows.Forms.Label fitnessLabel;
        private System.Windows.Forms.TextBox fitnessTextBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown sizeNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeTextBox;
    }
}

