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

namespace SpenderProject.Resources.Images
{
    public partial class Coins : UserControl
    {

        List<Models.Colors> selectedCoins = new List<Models.Colors>();
        Board board;
        bool firstTime = true;


        public Coins()
        {
            InitializeComponent();

            WildLabel.Text = "x 0";
            WhiteLabel.Text = "x 0";
            BlueLabel.Text = "x 0";
            GreenLabel.Text = "x 0";
            RedLabel.Text = "x 0";
            BlackLabel.Text = "x 0";

            CancelButton.Visible = false;
            ConfirmButton.Visible = false;

        }

        public void LoadBoard(Models.Board board)
        {
            this.board = board;
            WildLabel.Text = "x " + board.WildCoins.ToString();
            WhiteLabel.Text = "x " + board.WhiteCoins.ToString();
            BlueLabel.Text = "x " + board.BlueCoins.ToString();
            GreenLabel.Text = "x " + board.GreenCoins.ToString();
            RedLabel.Text = "x " + board.RedCoins.ToString();
            BlackLabel.Text = "x " + board.BlackCoins.ToString();

            WildCoin.Image = ImageResizer.ResizeImage((Image)new Bitmap(DirectorySelector.getChipDirectory(Colors.Wild)), WildCoin.Width, WildCoin.Height);
            WhiteCoin.Image = ImageResizer.ResizeImage((Image) new Bitmap(DirectorySelector.getChipDirectory(Colors.White)), WhiteCoin.Width, WhiteCoin.Height);
            BlueCoin.Image = ImageResizer.ResizeImage((Image) new Bitmap(DirectorySelector.getChipDirectory(Colors.Blue)), BlueCoin.Width, BlueCoin.Height);
            GreenCoin.Image = ImageResizer.ResizeImage((Image) new Bitmap(DirectorySelector.getChipDirectory(Colors.Green)), GreenCoin.Width, GreenCoin.Height);
            RedCoin.Image = ImageResizer.ResizeImage((Image) new Bitmap(DirectorySelector.getChipDirectory(Colors.Red)), RedCoin.Width, RedCoin.Height);
            BlackCoin.Image = ImageResizer.ResizeImage((Image) new Bitmap(DirectorySelector.getChipDirectory(Colors.Black)), BlackCoin.Width, BlackCoin.Height);

            if (firstTime)
            {
                firstTime = false;
                CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
                CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
                CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
            }

        }

        private void resetSelection()
        {
            switch (selectedCoins.Count)
            {
                case 0:
                    CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
                    CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
                    CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
                    break;
                case 1:
                    CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[0]));
                    CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
                    CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
                    break;
                case 2:
                    CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[0]));
                    CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[1]));
                    CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank));
                    break;
                case 3:
                    CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[0]));
                    CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[1]));
                    CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[2]));
                    break;
            }
        }

        private void WhiteCoin_Click(object sender, EventArgs e)
        {
            if(selectedCoins.Count < 3)
            {
                bool containsWhite = false;

                for(int i = 0; i < selectedCoins.Count; i++)
                {
                    if(selectedCoins[i] == Colors.White)
                    {
                        containsWhite = true;
                        break;
                    }
                }

                if (containsWhite)
                {
                    if(selectedCoins.Count == 1 && selectedCoins[0] == Colors.White && board.WhiteCoins > 3)
                    {
                        selectedCoins.Add(Colors.White);
                        CancelButton.Visible = true;
                        ConfirmButton.Visible = true;
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                        selectedCoins.Add(Colors.White);
                    CancelButton.Visible = true;
                    ConfirmButton.Visible = true;
                }
                resetSelection();
            }
        }

        private void BlueCoin_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count < 3)
            {
                bool containsBlue = false;

                for (int i = 0; i < selectedCoins.Count; i++)
                {
                    if (selectedCoins[i] == Colors.Blue)
                    {
                        containsBlue = true;
                        break;
                    }
                }

                if (containsBlue)
                {
                    if (selectedCoins.Count == 1 && selectedCoins[0] == Colors.Blue && board.BlueCoins > 3)
                    {
                        selectedCoins.Add(Colors.Blue);
                        CancelButton.Visible = true;
                        ConfirmButton.Visible = true;
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                        selectedCoins.Add(Colors.Blue);
                        CancelButton.Visible = true;
                        ConfirmButton.Visible = true;
                }
                resetSelection();
            }
        }

        private void GreenCoin_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count < 3)
            {
                bool containsGreen = false;

                for (int i = 0; i < selectedCoins.Count; i++)
                {
                    if (selectedCoins[i] == Colors.Green)
                    {
                        containsGreen = true;
                        break;
                    }
                }

                if (containsGreen)
                {
                    if (selectedCoins.Count == 1 && selectedCoins[0] == Colors.Green && board.GreenCoins > 3)
                    {
                        selectedCoins.Add(Colors.Green);
                        CancelButton.Visible = true;
                        ConfirmButton.Visible = true;
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                        selectedCoins.Add(Colors.Green);
                        CancelButton.Visible = true;
                        ConfirmButton.Visible = true;
                }
                resetSelection();
            }
        }

        private void RedCoin_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count < 3)
            {
                bool containsRed = false;

                for (int i = 0; i < selectedCoins.Count; i++)
                {
                    if (selectedCoins[i] == Colors.Red)
                    {
                        containsRed = true;
                        break;
                    }
                }

                if (containsRed)
                {
                    if (selectedCoins.Count == 1 && selectedCoins[0] == Colors.Red && board.RedCoins > 3)
                    {
                        selectedCoins.Add(Colors.Red);
                        CancelButton.Visible = true;
                        ConfirmButton.Visible = true;
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                        selectedCoins.Add(Colors.Red);
                    CancelButton.Visible = true;
                    ConfirmButton.Visible = true;
                }
                resetSelection();
            }
        }

        private void BlackCoin_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count < 3)
            {
                bool containsBlack = false;

                for (int i = 0; i < selectedCoins.Count; i++)
                {
                    if (selectedCoins[i] == Colors.Black)
                    {
                        containsBlack = true;
                        break;
                    }
                }

                if (containsBlack)
                {
                    if (selectedCoins.Count == 1 && selectedCoins[0] == Colors.Black && board.BlackCoins > 3)
                    {
                        selectedCoins.Add(Colors.Black);
                        CancelButton.Visible = true;
                        ConfirmButton.Visible = true;
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                        selectedCoins.Add(Colors.Black);

                    CancelButton.Visible = true;
                    ConfirmButton.Visible = true;
                }
                resetSelection();
            }
        }

        private void CoinSelection1_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count > 0)
            {
                selectedCoins.RemoveAt(0);
                resetSelection();

                if(selectedCoins.Count == 0)
                {
                    CancelButton.Visible = false;
                    ConfirmButton.Visible = false;
                }

            }
        }

        private void CoinSelection2_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count > 1)
            {
                selectedCoins.RemoveAt(1);
                resetSelection();

            }
        }

        private void CoinSelection3_Click(object sender, EventArgs e)
        {
            if(selectedCoins.Count > 2)
            {
                selectedCoins.RemoveAt(2);
                resetSelection();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            selectedCoins.Clear();
            resetSelection();

            CancelButton.Visible = false;
            ConfirmButton.Visible = false;

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //TODO: USE FN TO SEND SELECTED COINS TO PLAYER OBJ
            //TODO: USE FN TO REMOVE COINS FROM global board

            selectedCoins.Clear();
            resetSelection();

            CancelButton.Visible = false;
            ConfirmButton.Visible = false;
        }
    }
}
