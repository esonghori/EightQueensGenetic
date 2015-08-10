namespace EightQueensGenetic
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
            this.BoardPicBox = new System.Windows.Forms.PictureBox();
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.fitnessLabel = new System.Windows.Forms.Label();
            this.fitnessTextBox = new System.Windows.Forms.TextBox();
            this.stepBtn = new System.Windows.Forms.Button();
            this.fitnessCurvePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoardPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessCurvePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BoardPicBox
            // 
            this.BoardPicBox.ErrorImage = null;
            this.BoardPicBox.Image = global::EightQueensGenetic.Properties.Resources.chessboard;
            this.BoardPicBox.Location = new System.Drawing.Point(12, 12);
            this.BoardPicBox.Name = "BoardPicBox";
            this.BoardPicBox.Size = new System.Drawing.Size(400, 400);
            this.BoardPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoardPicBox.TabIndex = 0;
            this.BoardPicBox.TabStop = false;
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Location = new System.Drawing.Point(62, 419);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(75, 23);
            this.StartStopBtn.TabIndex = 1;
            this.StartStopBtn.Text = "Start";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            this.StartStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // fitnessLabel
            // 
            this.fitnessLabel.AutoSize = true;
            this.fitnessLabel.Location = new System.Drawing.Point(418, 12);
            this.fitnessLabel.Name = "fitnessLabel";
            this.fitnessLabel.Size = new System.Drawing.Size(43, 13);
            this.fitnessLabel.TabIndex = 2;
            this.fitnessLabel.Text = "Fitness:";
            // 
            // fitnessTextBox
            // 
            this.fitnessTextBox.Location = new System.Drawing.Point(467, 10);
            this.fitnessTextBox.Name = "fitnessTextBox";
            this.fitnessTextBox.ReadOnly = true;
            this.fitnessTextBox.Size = new System.Drawing.Size(41, 20);
            this.fitnessTextBox.TabIndex = 3;
            // 
            // stepBtn
            // 
            this.stepBtn.Location = new System.Drawing.Point(143, 419);
            this.stepBtn.Name = "stepBtn";
            this.stepBtn.Size = new System.Drawing.Size(75, 23);
            this.stepBtn.TabIndex = 4;
            this.stepBtn.Text = "Step";
            this.stepBtn.UseVisualStyleBackColor = true;
            this.stepBtn.Click += new System.EventHandler(this.stepBtn_Click);
            // 
            // fitnessCurvePicBox
            // 
            this.fitnessCurvePicBox.Location = new System.Drawing.Point(421, 36);
            this.fitnessCurvePicBox.Name = "fitnessCurvePicBox";
            this.fitnessCurvePicBox.Size = new System.Drawing.Size(200, 200);
            this.fitnessCurvePicBox.TabIndex = 5;
            this.fitnessCurvePicBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 449);
            this.Controls.Add(this.fitnessCurvePicBox);
            this.Controls.Add(this.stepBtn);
            this.Controls.Add(this.fitnessTextBox);
            this.Controls.Add(this.fitnessLabel);
            this.Controls.Add(this.StartStopBtn);
            this.Controls.Add(this.BoardPicBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BoardPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessCurvePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoardPicBox;
        private System.Windows.Forms.Button StartStopBtn;
        private System.Windows.Forms.Label fitnessLabel;
        private System.Windows.Forms.TextBox fitnessTextBox;
        private System.Windows.Forms.Button stepBtn;
        private System.Windows.Forms.PictureBox fitnessCurvePicBox;
    }
}

