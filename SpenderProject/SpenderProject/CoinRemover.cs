using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpenderProject.Tools;
using SpenderProject.Models;

namespace SpenderProject
{
    public partial class CoinRemover : UserControl
    {

        public Player player;
        public List<Colors> colors;
        PlayerStatus parent;

        bool FirstTime = true;

        public CoinRemover()
        {
            InitializeComponent();

            WhiteLabel.Text = "";
            BlueLabel.Text = "";
            GreenLabel.Text = "";
            RedLabel.Text = "";
            BlackLabel.Text = "";
            CountTotalText.Text = "";

            ConfirmButton.Visible = false;

        }

        public void loadPlayer(Player player, bool inside)
        {

            if (FirstTime)
            {
                FirstTime = false;
                parent = (this.Parent as PlayerStatus);

                WhiteCoin.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.White)), WhiteCoin.Width, WhiteCoin.Height);
                BlueCoin.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Blue)), BlueCoin.Width, BlueCoin.Height);
                GreenCoin.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Green)), GreenCoin.Width, GreenCoin.Height);
                RedCoin.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Red)), RedCoin.Width, RedCoin.Height);
                BlackCoin.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Black)), BlackCoin.Width, BlackCoin.Height);

                ConfirmButton.Text = "Confirm";
            
            }

            this.player = player;

            this.Visible = true;
            ConfirmButton.Visible = true;
            
            CountTotalText.Text = player.GetSumOfCoins().ToString();

            WhiteLabel.Text = player.WhiteCoins.ToString();
            BlueLabel.Text = player.BlueCoins.ToString();
            GreenLabel.Text = player.GreenCoins.ToString();
            RedLabel.Text = player.RedCoins.ToString();
            BlackLabel.Text = player.BlackCoins.ToString();

            if (!inside)
            {
                colors = new List<Colors>();
            }

        }

        public void reloadCoins()
        {
            switch (colors.Count)
            {
                case 0:
                    Selection1Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank)), Selection1Image.Width,Selection1Image.Height);
                    Selection2Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank)), Selection2Image.Width, Selection2Image.Height);
                    Selection3Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank)), Selection3Image.Width, Selection3Image.Height);
                    break;
                case 1:
                    Selection1Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(colors[0])), Selection1Image.Width, Selection1Image.Height);
                    Selection2Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank)), Selection2Image.Width, Selection2Image.Height);
                    Selection3Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank)), Selection3Image.Width, Selection3Image.Height);
                    break;
                case 2:
                    Selection1Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(colors[0])), Selection1Image.Width, Selection1Image.Height);
                    Selection2Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(colors[1])), Selection2Image.Width, Selection2Image.Height);
                    Selection3Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank)), Selection3Image.Width, Selection3Image.Height);
                    break;
                case 3:
                    Selection1Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(colors[0])), Selection1Image.Width, Selection1Image.Height);
                    Selection2Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(colors[1])), Selection2Image.Width, Selection2Image.Height);
                    Selection3Image.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(colors[1])), Selection3Image.Width, Selection3Image.Height);
                    break;
            }
        }


        private void WhiteCoin_Click(object sender, EventArgs e)
        {
            if(player.WhiteCoins > 0 && player.GetSumOfCoins() > 10)
            {
                player.RemoveCoins(1, 0, 0, 0, 0, 0);
                WhiteLabel.Text = player.WhiteCoins.ToString();
                CountTotalText.Text = player.GetSumOfCoins().ToString();
                colors.Add(Colors.White);
                reloadCoins();

            }
        }

        private void BlueCoin_Click(object sender, EventArgs e)
        {
            if (player.BlueCoins > 0 && player.GetSumOfCoins() > 10)
            {
                player.RemoveCoins(0, 0, 0, 1, 0, 0);
                BlueLabel.Text = player.BlueCoins.ToString();
                CountTotalText.Text = player.GetSumOfCoins().ToString();
                colors.Add(Colors.Blue);
                reloadCoins();

            }
        }

        private void GreenCoin_Click(object sender, EventArgs e)
        {
            if (player.GreenCoins > 0 && player.GetSumOfCoins() > 10)
            {
                player.RemoveCoins(0, 0, 0, 0, 1, 0);
                GreenLabel.Text = player.GreenCoins.ToString();
                CountTotalText.Text = player.GetSumOfCoins().ToString();
                colors.Add(Colors.Green);
                reloadCoins();

            }
        }

        private void RedCoin_Click(object sender, EventArgs e)
        {
            if (player.RedCoins > 0 && player.GetSumOfCoins() > 10)
            {
                player.RemoveCoins(0, 0, 1, 0, 0, 0);
                RedLabel.Text = player.RedCoins.ToString();
                CountTotalText.Text = player.GetSumOfCoins().ToString();
                colors.Add(Colors.Red);
                reloadCoins();

            }
        }

        private void BlackCoin_Click(object sender, EventArgs e)
        {
            if (player.BlackCoins > 0 && player.GetSumOfCoins() > 10)
            {
                player.RemoveCoins(0, 1, 0, 0, 0, 0);
                RedLabel.Text = player.BlackCoins.ToString();
                CountTotalText.Text = player.GetSumOfCoins().ToString();
                colors.Add(Colors.Black);
                reloadCoins();

            }
        }

        private void Selection1Image_Click(object sender, EventArgs e)
        {
            if(colors.Count > 0)
            {
                player.AddCoin(colors[0]);
                colors.RemoveAt(0);
                reloadCoins();
                loadPlayer(this.player, true);
            }
        }

        private void Selection2Image_Click(object sender, EventArgs e)
        {
            if (colors.Count > 1)
            {
                player.AddCoin(colors[1]);
                colors.RemoveAt(1);
                reloadCoins();
                loadPlayer(this.player, true);
            }
        }

        private void Selection3Image_Click(object sender, EventArgs e)
        {
            if (colors.Count > 2)
            {
                player.AddCoin(colors[2]);
                colors.RemoveAt(2);
                reloadCoins();
                loadPlayer(this.player, true);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(player.GetSumOfCoins() == 10)
            {
                parent.removeExcessCoins(colors);
                Visible = false;

                WhiteLabel.Text = "";
                BlueLabel.Text = "";
                GreenLabel.Text = "";
                RedLabel.Text = "";
                BlackLabel.Text = "";
                CountTotalText.Text = "";

                ConfirmButton.Visible = false;
            }
        }
    }
}
