namespace SpenderProject.VisualElements
{
    partial class Base
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.PlayerMinusButton = new System.Windows.Forms.Button();
            this.playerPlusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numPlayersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(488, 732);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(415, 75);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(488, 651);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(415, 75);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start Game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(608, 151);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(161, 50);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Spendor";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerMinusButton
            // 
            this.PlayerMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMinusButton.Location = new System.Drawing.Point(488, 585);
            this.PlayerMinusButton.Name = "PlayerMinusButton";
            this.PlayerMinusButton.Size = new System.Drawing.Size(150, 60);
            this.PlayerMinusButton.TabIndex = 3;
            this.PlayerMinusButton.Text = "-";
            this.PlayerMinusButton.UseVisualStyleBackColor = true;
            this.PlayerMinusButton.Click += new System.EventHandler(this.playerMinus_Click);
            // 
            // playerPlusButton
            // 
            this.playerPlusButton.Location = new System.Drawing.Point(753, 585);
            this.playerPlusButton.Name = "playerPlusButton";
            this.playerPlusButton.Size = new System.Drawing.Size(150, 60);
            this.playerPlusButton.TabIndex = 4;
            this.playerPlusButton.Text = "+";
            this.playerPlusButton.UseVisualStyleBackColor = true;
            this.playerPlusButton.Click += new System.EventHandler(this.playerPlus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "1";
            // 
            // numPlayersLabel
            // 
            this.numPlayersLabel.AutoSize = true;
            this.numPlayersLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlayersLabel.Location = new System.Drawing.Point(588, 533);
            this.numPlayersLabel.Name = "numPlayersLabel";
            this.numPlayersLabel.Size = new System.Drawing.Size(216, 31);
            this.numPlayersLabel.TabIndex = 6;
            this.numPlayersLabel.Text = "Number of players";
            this.numPlayersLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 961);
            this.Controls.Add(this.numPlayersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerPlusButton);
            this.Controls.Add(this.PlayerMinusButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "Base";
            this.Text = "Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button PlayerMinusButton;
        private System.Windows.Forms.Button playerPlusButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numPlayersLabel;
    }
}