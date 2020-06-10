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
            this.shop1 = new SpenderProject.Shop();
            this.coins1 = new SpenderProject.Resources.Images.Coins();
            this.SuspendLayout();
            // 
            // shop1
            // 
            this.shop1.BackColor = System.Drawing.Color.Transparent;
            this.shop1.Location = new System.Drawing.Point(-6, 234);
            this.shop1.Name = "shop1";
            this.shop1.Size = new System.Drawing.Size(817, 578);
            this.shop1.TabIndex = 17;
            // 
            // coins1
            // 
            this.coins1.BackColor = System.Drawing.Color.Transparent;
            this.coins1.Location = new System.Drawing.Point(830, 140);
            this.coins1.Name = "coins1";
            this.coins1.Size = new System.Drawing.Size(367, 672);
            this.coins1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 806);
            this.Controls.Add(this.shop1);
            this.Controls.Add(this.coins1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Coins coins1;
        private Shop shop1;
    }
}

