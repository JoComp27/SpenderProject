namespace SpenderProject
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.holdButton = new System.Windows.Forms.Button();
            this.requirementImage3 = new System.Windows.Forms.PictureBox();
            this.requirementImage2 = new System.Windows.Forms.PictureBox();
            this.requirementImage4 = new System.Windows.Forms.PictureBox();
            this.ColorImage = new System.Windows.Forms.PictureBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Score = new System.Windows.Forms.Label();
            this.requirementImage1 = new System.Windows.Forms.PictureBox();
            this.ReqNum4 = new System.Windows.Forms.Label();
            this.ReqNum3 = new System.Windows.Forms.Label();
            this.ReqNum2 = new System.Windows.Forms.Label();
            this.ReqNum1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // holdButton
            // 
            this.holdButton.Location = new System.Drawing.Point(55, 123);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(50, 30);
            this.holdButton.TabIndex = 1;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = true;
            this.holdButton.Click += new System.EventHandler(this.holdButton_Click);
            // 
            // requirementImage3
            // 
            this.requirementImage3.Location = new System.Drawing.Point(5, 67);
            this.requirementImage3.Name = "requirementImage3";
            this.requirementImage3.Size = new System.Drawing.Size(25, 25);
            this.requirementImage3.TabIndex = 3;
            this.requirementImage3.TabStop = false;
            // 
            // requirementImage2
            // 
            this.requirementImage2.Location = new System.Drawing.Point(5, 98);
            this.requirementImage2.Name = "requirementImage2";
            this.requirementImage2.Size = new System.Drawing.Size(25, 25);
            this.requirementImage2.TabIndex = 4;
            this.requirementImage2.TabStop = false;
            // 
            // requirementImage4
            // 
            this.requirementImage4.Location = new System.Drawing.Point(5, 36);
            this.requirementImage4.Name = "requirementImage4";
            this.requirementImage4.Size = new System.Drawing.Size(25, 25);
            this.requirementImage4.TabIndex = 5;
            this.requirementImage4.TabStop = false;
            // 
            // ColorImage
            // 
            this.ColorImage.Location = new System.Drawing.Point(58, 8);
            this.ColorImage.Name = "ColorImage";
            this.ColorImage.Size = new System.Drawing.Size(47, 37);
            this.ColorImage.TabIndex = 7;
            this.ColorImage.TabStop = false;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(55, 92);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(50, 30);
            this.buyButton.TabIndex = 9;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(7, 8);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(64, 25);
            this.Score.TabIndex = 10;
            this.Score.Text = "label1";
            // 
            // requirementImage1
            // 
            this.requirementImage1.Location = new System.Drawing.Point(5, 128);
            this.requirementImage1.Name = "requirementImage1";
            this.requirementImage1.Size = new System.Drawing.Size(25, 25);
            this.requirementImage1.TabIndex = 11;
            this.requirementImage1.TabStop = false;
            // 
            // ReqNum4
            // 
            this.ReqNum4.AutoSize = true;
            this.ReqNum4.Location = new System.Drawing.Point(10, 42);
            this.ReqNum4.Name = "ReqNum4";
            this.ReqNum4.Size = new System.Drawing.Size(35, 13);
            this.ReqNum4.TabIndex = 12;
            this.ReqNum4.Text = "label1";
            // 
            // ReqNum3
            // 
            this.ReqNum3.AutoSize = true;
            this.ReqNum3.Location = new System.Drawing.Point(10, 73);
            this.ReqNum3.Name = "ReqNum3";
            this.ReqNum3.Size = new System.Drawing.Size(35, 13);
            this.ReqNum3.TabIndex = 13;
            this.ReqNum3.Text = "label2";
            // 
            // ReqNum2
            // 
            this.ReqNum2.AutoSize = true;
            this.ReqNum2.Location = new System.Drawing.Point(10, 104);
            this.ReqNum2.Name = "ReqNum2";
            this.ReqNum2.Size = new System.Drawing.Size(35, 13);
            this.ReqNum2.TabIndex = 14;
            this.ReqNum2.Text = "label3";
            // 
            // ReqNum1
            // 
            this.ReqNum1.AutoSize = true;
            this.ReqNum1.Location = new System.Drawing.Point(10, 134);
            this.ReqNum1.Name = "ReqNum1";
            this.ReqNum1.Size = new System.Drawing.Size(35, 13);
            this.ReqNum1.TabIndex = 15;
            this.ReqNum1.Text = "label4";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ReqNum1);
            this.Controls.Add(this.ReqNum2);
            this.Controls.Add(this.ReqNum3);
            this.Controls.Add(this.ReqNum4);
            this.Controls.Add(this.requirementImage1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.ColorImage);
            this.Controls.Add(this.requirementImage4);
            this.Controls.Add(this.requirementImage2);
            this.Controls.Add(this.requirementImage3);
            this.Controls.Add(this.holdButton);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(115, 160);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backgroundPicture_mouseEntered);
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.PictureBox requirementImage3;
        private System.Windows.Forms.PictureBox requirementImage2;
        private System.Windows.Forms.PictureBox requirementImage4;
        private System.Windows.Forms.PictureBox ColorImage;
        private System.Windows.Forms.Button buyButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox requirementImage1;
        private System.Windows.Forms.Label ReqNum4;
        private System.Windows.Forms.Label ReqNum3;
        private System.Windows.Forms.Label ReqNum2;
        private System.Windows.Forms.Label ReqNum1;
    }
}
