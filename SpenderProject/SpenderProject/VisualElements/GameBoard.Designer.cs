using SpenderProject.Resources.Images;

namespace SpenderProject
{
    partial class GameBoard
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
            this.EndGameLabel = new System.Windows.Forms.Label();
            this.playerStatus1 = new SpenderProject.PlayerStatus();
            this.shop1 = new SpenderProject.Shop();
            this.coins1 = new SpenderProject.Resources.Images.Coins();
            this.SuspendLayout();
            // 
            // EndGameLabel
            // 
            this.EndGameLabel.AutoSize = true;
            this.EndGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGameLabel.Location = new System.Drawing.Point(503, 303);
            this.EndGameLabel.Name = "EndGameLabel";
            this.EndGameLabel.Size = new System.Drawing.Size(169, 61);
            this.EndGameLabel.TabIndex = 19;
            this.EndGameLabel.Text = "label1";
            // 
            // playerStatus1
            // 
            this.playerStatus1.BackColor = System.Drawing.Color.Transparent;
            this.playerStatus1.Location = new System.Drawing.Point(3, -1);
            this.playerStatus1.Name = "playerStatus1";
            this.playerStatus1.Size = new System.Drawing.Size(1311, 242);
            this.playerStatus1.TabIndex = 18;
            // 
            // shop1
            // 
            this.shop1.BackColor = System.Drawing.Color.Transparent;
            this.shop1.game = null;
            this.shop1.Location = new System.Drawing.Point(3, 247);
            this.shop1.Name = "shop1";
            this.shop1.Size = new System.Drawing.Size(758, 690);
            this.shop1.TabIndex = 17;
            // 
            // coins1
            // 
            this.coins1.BackColor = System.Drawing.Color.Transparent;
            this.coins1.game = null;
            this.coins1.coinSelectionBoard = null;
            this.coins1.firstTime = true;
            this.coins1.Location = new System.Drawing.Point(938, 254);
            this.coins1.Name = "coins1";
            this.coins1.selectedCoins = null;
            this.coins1.Size = new System.Drawing.Size(367, 672);
            this.coins1.TabIndex = 16;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 938);
            this.Controls.Add(this.EndGameLabel);
            this.Controls.Add(this.playerStatus1);
            this.Controls.Add(this.shop1);
            this.Controls.Add(this.coins1);
            this.Name = "Base";
            this.Text = "Splendor Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Coins coins1;
        private Shop shop1;
        private PlayerStatus playerStatus1;
        private System.Windows.Forms.Label EndGameLabel;
    }
}

