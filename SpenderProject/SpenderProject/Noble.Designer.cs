namespace SpenderProject
{
    partial class Noble
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
            this.Score = new System.Windows.Forms.Label();
            this.ReqNum1 = new System.Windows.Forms.Label();
            this.ReqNum2 = new System.Windows.Forms.Label();
            this.ReqNum3 = new System.Windows.Forms.Label();
            this.requirementImage1 = new System.Windows.Forms.PictureBox();
            this.requirementImage2 = new System.Windows.Forms.PictureBox();
            this.requirementImage3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(7, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(64, 25);
            this.Score.TabIndex = 11;
            this.Score.Text = "label1";
            // 
            // ReqNum1
            // 
            this.ReqNum1.AutoSize = true;
            this.ReqNum1.Location = new System.Drawing.Point(9, 110);
            this.ReqNum1.Name = "ReqNum1";
            this.ReqNum1.Size = new System.Drawing.Size(35, 13);
            this.ReqNum1.TabIndex = 22;
            this.ReqNum1.Text = "label4";
            // 
            // ReqNum2
            // 
            this.ReqNum2.AutoSize = true;
            this.ReqNum2.Location = new System.Drawing.Point(9, 80);
            this.ReqNum2.Name = "ReqNum2";
            this.ReqNum2.Size = new System.Drawing.Size(35, 13);
            this.ReqNum2.TabIndex = 21;
            this.ReqNum2.Text = "label3";
            // 
            // ReqNum3
            // 
            this.ReqNum3.AutoSize = true;
            this.ReqNum3.Location = new System.Drawing.Point(9, 49);
            this.ReqNum3.Name = "ReqNum3";
            this.ReqNum3.Size = new System.Drawing.Size(35, 13);
            this.ReqNum3.TabIndex = 20;
            this.ReqNum3.Text = "label2";
            // 
            // requirementImage1
            // 
            this.requirementImage1.Location = new System.Drawing.Point(4, 104);
            this.requirementImage1.Name = "requirementImage1";
            this.requirementImage1.Size = new System.Drawing.Size(25, 25);
            this.requirementImage1.TabIndex = 19;
            this.requirementImage1.TabStop = false;
            // 
            // requirementImage2
            // 
            this.requirementImage2.Location = new System.Drawing.Point(4, 74);
            this.requirementImage2.Name = "requirementImage2";
            this.requirementImage2.Size = new System.Drawing.Size(25, 25);
            this.requirementImage2.TabIndex = 17;
            this.requirementImage2.TabStop = false;
            // 
            // requirementImage3
            // 
            this.requirementImage3.Location = new System.Drawing.Point(4, 43);
            this.requirementImage3.Name = "requirementImage3";
            this.requirementImage3.Size = new System.Drawing.Size(25, 25);
            this.requirementImage3.TabIndex = 16;
            this.requirementImage3.TabStop = false;
            // 
            // Noble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReqNum1);
            this.Controls.Add(this.ReqNum2);
            this.Controls.Add(this.ReqNum3);
            this.Controls.Add(this.requirementImage1);
            this.Controls.Add(this.requirementImage2);
            this.Controls.Add(this.requirementImage3);
            this.Controls.Add(this.Score);
            this.Name = "Noble";
            this.Size = new System.Drawing.Size(135, 135);
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ReqNum1;
        private System.Windows.Forms.Label ReqNum2;
        private System.Windows.Forms.Label ReqNum3;
        private System.Windows.Forms.PictureBox requirementImage1;
        private System.Windows.Forms.PictureBox requirementImage2;
        private System.Windows.Forms.PictureBox requirementImage3;
    }
}
