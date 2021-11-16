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
using System.Runtime.InteropServices;

namespace SpenderProject.Resources.Images
{
    public partial class Coins : UserControl
    {

        public Base parent;
        public List<Colors> selectedCoins { get; set; }
        public Game game { get; set; }
        public Board coinSelectionBoard { get; set; }
        public bool firstTime { get; set; } = true;


        public Coins()
        {
            InitializeComponent();

            WildLabel.Text = "x 0";
            WhiteLabel.Text = "x 0";
            BlueLabel.Text = "x 0";
            GreenLabel.Text = "x 0";
            RedLabel.Text = "x 0";
            BlackLabel.Text = "x 0";

            CancelConfirmVisibility(false);

        }

        public void LoadGame(Game game)
        {
            this.game = game;
            Board board = game.board;

            WildLabel.Text = "x " + board.WildCoins.ToString();
            WhiteLabel.Text = "x " + board.WhiteCoins.ToString();
            BlueLabel.Text = "x " + board.BlueCoins.ToString();
            GreenLabel.Text = "x " + board.GreenCoins.ToString();
            RedLabel.Text = "x " + board.RedCoins.ToString();
            BlackLabel.Text = "x " + board.BlackCoins.ToString();

            this.coinSelectionBoard = new Board(board.WhiteCoins, board.BlueCoins, board.RedCoins, board.BlackCoins, board.GreenCoins, board.WildCoins);
            
            selectedCoins = new List<Colors>();
            resetSelection();

            if (firstTime)
            {

                firstTime = false;

                this.parent = (this.Parent as Base);

                CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));
                CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));
                CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));

                WildCoin.Image = ImageResizer.ResizeImage((Image)new Bitmap(DirectorySelector.getChipDirectory(Colors.Wild)), WildCoin.Width, WildCoin.Height);
                WhiteCoin.Image = ImageResizer.ResizeImage((Image)new Bitmap(DirectorySelector.getChipDirectory(Colors.White)), WhiteCoin.Width, WhiteCoin.Height);
                BlueCoin.Image = ImageResizer.ResizeImage((Image)new Bitmap(DirectorySelector.getChipDirectory(Colors.Blue)), BlueCoin.Width, BlueCoin.Height);
                GreenCoin.Image = ImageResizer.ResizeImage((Image)new Bitmap(DirectorySelector.getChipDirectory(Colors.Green)), GreenCoin.Width, GreenCoin.Height);
                RedCoin.Image = ImageResizer.ResizeImage((Image)new Bitmap(DirectorySelector.getChipDirectory(Colors.Red)), RedCoin.Width, RedCoin.Height);
                BlackCoin.Image = ImageResizer.ResizeImage((Image)new Bitmap(DirectorySelector.getChipDirectory(Colors.Black)), BlackCoin.Width, BlackCoin.Height);
            }

        }
        private void LoadGame(Board board)
        {

            WildLabel.Text = "x " + board.WildCoins.ToString();
            WhiteLabel.Text = "x " + board.WhiteCoins.ToString();
            BlueLabel.Text = "x " + board.BlueCoins.ToString();
            GreenLabel.Text = "x " + board.GreenCoins.ToString();
            RedLabel.Text = "x " + board.RedCoins.ToString();
            BlackLabel.Text = "x " + board.BlackCoins.ToString();

        }

        private void resetSelection()
        {
            switch (selectedCoins.Count)
            {
                case 0:
                    CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));
                    CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));
                    CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));
                    break;
                case 1:
                    CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[0]));
                    CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));
                    CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));
                    break;
                case 2:
                    CoinSelection1.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[0]));
                    CoinSelection2.Image = new Bitmap(DirectorySelector.getChipDirectory(selectedCoins[1]));
                    CoinSelection3.Image = new Bitmap(DirectorySelector.getChipDirectory(Colors.Blank));
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
            if(selectedCoins.Count < 3 && coinSelectionBoard.WhiteCoins > 0)
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
                    if(selectedCoins.Count == 1 && selectedCoins[0] == Colors.White && coinSelectionBoard.WhiteCoins >= 3)
                    {
                        coinSelectionBoard.removeCoin(Colors.White);
                        LoadGame(coinSelectionBoard);
                        selectedCoins.Add(Colors.White);
                        CancelConfirmVisibility(true);
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                    {
                        selectedCoins.Add(Colors.White);
                        coinSelectionBoard.removeCoin(Colors.White);
                        LoadGame(coinSelectionBoard);

                        if(selectedCoins.Count == 3)
                        {
                            CancelConfirmVisibility(true);
                        }
                        
                    }

                    
                }
                resetSelection();
            }
        }

        private void BlueCoin_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count < 3 && coinSelectionBoard.BlueCoins > 0)
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
                    if (selectedCoins.Count == 1 && selectedCoins[0] == Colors.Blue && coinSelectionBoard.BlueCoins >= 3)
                    {
                        coinSelectionBoard.removeCoin(Colors.Blue);
                        LoadGame(coinSelectionBoard);
                        selectedCoins.Add(Colors.Blue);
                        CancelConfirmVisibility(true);
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                    {
                        selectedCoins.Add(Colors.Blue);
                        coinSelectionBoard.removeCoin(Colors.Blue);
                        LoadGame(coinSelectionBoard);

                        if (selectedCoins.Count == 3)
                        {
                            CancelConfirmVisibility(true);
                        }
                    }

                    
                }
                resetSelection();
            }
        }

        private void GreenCoin_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count < 3 && coinSelectionBoard.GreenCoins > 0)
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
                    if (selectedCoins.Count == 1 && selectedCoins[0] == Colors.Green && coinSelectionBoard.GreenCoins >= 3)
                    {
                        coinSelectionBoard.removeCoin(Colors.Green);
                        LoadGame(coinSelectionBoard);
                        selectedCoins.Add(Colors.Green);
                        CancelConfirmVisibility(true);
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                    {
                        selectedCoins.Add(Colors.Green);
                        coinSelectionBoard.removeCoin(Colors.Green);
                        LoadGame(coinSelectionBoard);

                        if (selectedCoins.Count == 3)
                        {
                            CancelConfirmVisibility(true);
                        }
                    }
                }
                resetSelection();
            }
        }

        private void RedCoin_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count < 3 && coinSelectionBoard.RedCoins > 0)
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
                    if (selectedCoins.Count == 1 && selectedCoins[0] == Colors.Red && coinSelectionBoard.RedCoins >= 3)
                    {
                        coinSelectionBoard.removeCoin(Colors.Red);
                        LoadGame(coinSelectionBoard);
                        selectedCoins.Add(Colors.Red);
                        CancelConfirmVisibility(true);
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                    {
                        selectedCoins.Add(Colors.Red);
                        coinSelectionBoard.removeCoin(Colors.Red);
                        LoadGame(coinSelectionBoard);

                        if (selectedCoins.Count == 3)
                        {
                            CancelConfirmVisibility(true);
                        }
                    }

                }
                resetSelection();
            }
        }

        private void BlackCoin_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count < 3 && coinSelectionBoard.BlackCoins > 0)
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
                    if (selectedCoins.Count == 1 && selectedCoins[0] == Colors.Black && coinSelectionBoard.BlackCoins >= 3)
                    {
                        coinSelectionBoard.removeCoin(Colors.Black);
                        LoadGame(coinSelectionBoard);
                        selectedCoins.Add(Colors.Black);
                        CancelConfirmVisibility(true);
                    }
                }
                else
                {
                    if (!(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1]))
                    {
                        selectedCoins.Add(Colors.Black);
                        coinSelectionBoard.removeCoin(Colors.Black);
                        LoadGame(coinSelectionBoard);

                        if (selectedCoins.Count == 3)
                        {
                            CancelConfirmVisibility(true);
                        }
                    }

                }
                resetSelection();
            }
        }

        private void CoinSelection1_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count > 0)
            {
                coinSelectionBoard.addCoin(selectedCoins[0]);
                selectedCoins.RemoveAt(0);
                resetSelection();

                CancelConfirmVisibility(false);

                LoadGame(coinSelectionBoard);

            }
        }

        private void CoinSelection2_Click(object sender, EventArgs e)
        {
            if (selectedCoins.Count > 1)
            {
                coinSelectionBoard.addCoin(selectedCoins[1]);
                selectedCoins.RemoveAt(1);
                resetSelection();

                if(selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1])
                {
                    CancelConfirmVisibility(true);
                }
                else
                {
                    CancelConfirmVisibility(false);
                }

                LoadGame(coinSelectionBoard);

            }
        }

        private void CoinSelection3_Click(object sender, EventArgs e)
        {
            if(selectedCoins.Count > 2)
            {
                coinSelectionBoard.addCoin(selectedCoins[2]);
                selectedCoins.RemoveAt(2);
                resetSelection();

                if (selectedCoins.Count == 2 && selectedCoins[0] == selectedCoins[1])
                {
                    CancelConfirmVisibility(true);
                }
                else
                {
                    CancelConfirmVisibility(false);
                }

                LoadGame(coinSelectionBoard);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            selectedCoins.Clear();
            resetSelection();

            this.coinSelectionBoard = new Board(this.game.board.WhiteCoins, this.game.board.BlueCoins, this.game.board.RedCoins, this.game.board.BlackCoins, this.game.board.GreenCoins, this.game.board.WildCoins);
            LoadGame(coinSelectionBoard);

            CancelConfirmVisibility(false);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            game.giveCoinsToActivePlayer(selectedCoins);

            selectedCoins.Clear();
            resetSelection();

            this.game.board.setCoins(coinSelectionBoard.WhiteCoins, coinSelectionBoard.BlueCoins, coinSelectionBoard.RedCoins, 
                coinSelectionBoard.BlackCoins, coinSelectionBoard.GreenCoins, coinSelectionBoard.WildCoins);

            CancelConfirmVisibility(false);

            parent.UpdateGame(this.game);
            parent.endActivePlayerTurn();
        }

        private void CancelConfirmVisibility(bool value)
        {
            CancelButton.Visible = value;
            ConfirmButton.Visible = value;
        }
    }
}
