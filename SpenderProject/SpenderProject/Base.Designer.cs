using SpenderProject.Resources.Images;

namespace SpenderProject
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
            this.coins1 = new SpenderProject.Resources.Images.Coins();
            this.shop1 = new SpenderProject.Shop();
            this.playerStatus1 = new SpenderProject.PlayerStatus();
            this.SuspendLayout();
            // 
            // coins1
            // 
            this.coins1.BackColor = System.Drawing.Color.Transparent;
            this.coins1.board = null;
            this.coins1.coinSelectionBoard = null;
            this.coins1.firstTime = true;
            this.coins1.Location = new System.Drawing.Point(938, 254);
            this.coins1.Name = "coins1";
            this.coins1.selectedCoins = null;
            this.coins1.Size = new System.Drawing.Size(367, 672);
            this.coins1.TabIndex = 16;
            // 
            // shop1
            // 
            this.shop1.BackColor = System.Drawing.Color.Transparent;
            this.shop1.Location = new System.Drawing.Point(3, 247);
            this.shop1.Name = "shop1";
            this.shop1.Size = new System.Drawing.Size(758, 690);
            this.shop1.TabIndex = 17;
            // 
            // playerStatus1
            // 
            this.playerStatus1.BackColor = System.Drawing.Color.Transparent;
            this.playerStatus1.Location = new System.Drawing.Point(3, -1);
            this.playerStatus1.Name = "playerStatus1";
            this.playerStatus1.Size = new System.Drawing.Size(1311, 120);
            this.playerStatus1.TabIndex = 18;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 938);
            this.Controls.Add(this.playerStatus1);
            this.Controls.Add(this.shop1);
            this.Controls.Add(this.coins1);
            this.Name = "Base";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Coins coins1;
        private Shop shop1;
        private PlayerStatus playerStatus1;
    }
}

