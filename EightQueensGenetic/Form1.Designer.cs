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
            this.StartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoardPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BoardPicBox
            // 
            this.BoardPicBox.Image = global::EightQueensGenetic.Properties.Resources.board;
            this.BoardPicBox.Location = new System.Drawing.Point(12, 12);
            this.BoardPicBox.Name = "BoardPicBox";
            this.BoardPicBox.Size = new System.Drawing.Size(400, 400);
            this.BoardPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoardPicBox.TabIndex = 0;
            this.BoardPicBox.TabStop = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(178, 418);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 449);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.BoardPicBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BoardPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BoardPicBox;
        private System.Windows.Forms.Button StartBtn;
    }
}

