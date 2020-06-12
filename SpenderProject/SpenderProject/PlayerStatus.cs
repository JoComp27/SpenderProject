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

namespace SpenderProject
{
    public partial class PlayerStatus : UserControl
    {
        Models.Game game;
        bool firstTime = true;
        bool showHide = false;

        public PlayerStatus()
        {
            InitializeComponent();

            Player1BlackCardText.Text = "";
            Player1BlackCoinText.Text = "";
            Player1WhiteCoinText.Text = "";
            Player1WhiteCardText.Text = "";
            Player1WildCoinText.Text = "";
            Player1BlueCardText.Text = "";
            Player1BlueCoinText.Text = "";
            Player1GreenCardText.Text = "";
            Player1GreenCoinText.Text = "";
            Player1RedCardText.Text = "";
            Player1RedCoinText.Text = "";
            Player1Score.Text = "";

            Player2BlackCardText.Text = "";
            Player2BlackCoinText.Text = "";
            Player2WhiteCoinText.Text = "";
            Player2WhiteCardText.Text = "";
            Player2WildCoinText.Text = "";
            Player2BlueCardText.Text = "";
            Player2BlueCoinText.Text = "";
            Player2GreenCardText.Text = "";
            Player2GreenCoinText.Text = "";
            Player2RedCardText.Text = "";
            Player2RedCoinText.Text = "";
            Player2Score.Text = "";

            Player3BlackCardText.Text = "";
            Player3BlackCoinText.Text = "";
            Player3WhiteCoinText.Text = "";
            Player3WhiteCardText.Text = "";
            Player3WildCoinText.Text = "";
            Player3BlueCardText.Text = "";
            Player3BlueCoinText.Text = "";
            Player3GreenCardText.Text = "";
            Player3GreenCoinText.Text = "";
            Player3RedCardText.Text = "";
            Player3RedCoinText.Text = "";
            Player3Score.Text = "";

            Player4BlackCardText.Text = "";
            Player4BlackCoinText.Text = "";
            Player4WhiteCoinText.Text = "";
            Player4WhiteCardText.Text = "";
            Player4WildCoinText.Text = "";
            Player4BlueCardText.Text = "";
            Player4BlueCoinText.Text = "";
            Player4GreenCardText.Text = "";
            Player4GreenCoinText.Text = "";
            Player4RedCardText.Text = "";
            Player4RedCoinText.Text = "";
            Player4Score.Text = "";

            deck1.setText("");
            deck2.setText("");
            deck3.setText("");

            ShowHideButton.Text = "Show";

        }

        public void loadGame(Models.Game game)
        {

            this.game = game;

            //Assumption that 2 players is minimum

            switch (game.ActivePlayer)
            {
                case 0:
                    //Player 1 is active
                    Player1Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Red)), Player1Turn.Width, Player1Turn.Height);
                    Player2Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player2Turn.Width, Player2Turn.Height);
                    
                    if(game.numberOfPlayers > 2)
                    {
                        Player3Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player3Turn.Width, Player3Turn.Height);
                        if(game.numberOfPlayers > 3)
                        {
                            Player4Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player4Turn.Width, Player4Turn.Height);
                        }
                    }

                    break;
                case 1:
                    //Player2 is active
                    Player1Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player1Turn.Width, Player1Turn.Height);
                    Player2Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Blue)), Player2Turn.Width, Player2Turn.Height);

                    if (game.numberOfPlayers > 2)
                    {
                        Player3Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player3Turn.Width, Player3Turn.Height);
                        if (game.numberOfPlayers > 3)
                        {
                            Player4Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player4Turn.Width, Player4Turn.Height);
                        }
                    }
                    break;
                case 2:
                    //Player3 is active
                    Player1Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player1Turn.Width, Player1Turn.Height);
                    Player2Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player2Turn.Width, Player2Turn.Height);
                    Player3Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Wild)), Player3Turn.Width, Player3Turn.Height);
                    if (game.numberOfPlayers > 3)
                        {
                            Player4Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player4Turn.Width, Player4Turn.Height);
                        }
                    
                    break;
                case 3:
                    //Player4 is active

                    Player1Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player1Turn.Width, Player1Turn.Height);
                    Player2Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player2Turn.Width, Player2Turn.Height);
                    Player3Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getChipDirectory(Models.Colors.Blank)), Player3Turn.Width, Player3Turn.Height);
                    Player4Turn.Image = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Wild)), Player4Turn.Width, Player4Turn.Height);
                    break;

            }

            Player1BlackCardText.Text = game.players[0].BlackCards.ToString();
            Player1BlackCoinText.Text = game.players[0].BlackCoins.ToString();
            Player1WhiteCoinText.Text = game.players[0].WhiteCoins.ToString();
            Player1WhiteCardText.Text = game.players[0].WhiteCards.ToString();
            Player1WildCoinText.Text = game.players[0].WildCoins.ToString();
            Player1BlueCardText.Text = game.players[0].BlueCards.ToString();
            Player1BlueCoinText.Text = game.players[0].BlueCoins.ToString();
            Player1GreenCardText.Text = game.players[0].GreenCards.ToString();
            Player1GreenCoinText.Text = game.players[0].GreenCoins.ToString();
            Player1RedCardText.Text = game.players[0].RedCards.ToString();
            Player1RedCoinText.Text = game.players[0].RedCoins.ToString();
            Player1Score.Text = game.players[0].Score.ToString();

            

            Player2BlackCardText.Text = game.players[1].BlackCards.ToString();
            Player2BlackCoinText.Text = game.players[1].BlackCoins.ToString();
            Player2WhiteCoinText.Text = game.players[1].WhiteCoins.ToString();
            Player2WhiteCardText.Text = game.players[1].WhiteCards.ToString();
            Player2WildCoinText.Text = game.players[1].WildCoins.ToString();
            Player2BlueCardText.Text = game.players[1].BlueCards.ToString();
            Player2BlueCoinText.Text = game.players[1].BlueCoins.ToString();
            Player2GreenCardText.Text = game.players[1].GreenCards.ToString();
            Player2GreenCoinText.Text = game.players[1].GreenCoins.ToString();
            Player2RedCardText.Text = game.players[1].RedCards.ToString();
            Player2RedCoinText.Text = game.players[1].RedCoins.ToString();
            Player2Score.Text = game.players[1].Score.ToString();

            if (firstTime)
            {
                Player1BlackCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Black));
                Player1BlackCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Black));
                Player1WhiteCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.White));
                Player1WhiteCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.White));
                Player1BlueCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Blue));
                Player1BlueCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Blue));
                Player1RedCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Red));
                Player1RedCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Red));
                Player1GreenCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Green));
                Player1GreenCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Green));
                Player1WildCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Wild));

                Player2BlackCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Black));
                Player2BlackCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Black));
                Player2WhiteCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.White));
                Player2WhiteCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.White));
                Player2BlueCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Blue));
                Player2BlueCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Blue));
                Player2RedCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Red));
                Player2RedCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Red));
                Player2GreenCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Green));
                Player2GreenCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Green));
                Player2WildCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Wild));
            }


            if (game.numberOfPlayers > 2)
            {

                Player3BlackCardText.Text = game.players[2].BlackCards.ToString();
                Player3BlackCoinText.Text = game.players[2].BlackCoins.ToString();
                Player3WhiteCoinText.Text = game.players[2].WhiteCoins.ToString();
                Player3WhiteCardText.Text = game.players[2].WhiteCards.ToString();
                Player3WildCoinText.Text = game.players[2].WildCoins.ToString();
                Player3BlueCardText.Text = game.players[2].BlueCards.ToString();
                Player3BlueCoinText.Text = game.players[2].BlueCoins.ToString();
                Player3GreenCardText.Text = game.players[2].GreenCards.ToString();
                Player3GreenCoinText.Text = game.players[2].GreenCoins.ToString();
                Player3RedCardText.Text = game.players[2].RedCards.ToString();
                Player3RedCoinText.Text = game.players[2].RedCoins.ToString();
                Player3Score.Text = game.players[2].Score.ToString();

                if (firstTime)
                {
                    Player3BlackCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Black));
                    Player3BlackCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Black));
                    Player3WhiteCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.White));
                    Player3WhiteCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.White));
                    Player3BlueCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Blue));
                    Player3BlueCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Blue));
                    Player3RedCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Red));
                    Player3RedCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Red));
                    Player3GreenCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Green));
                    Player3GreenCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Green));
                    Player3WildCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Wild));
                }
               

                if (game.numberOfPlayers > 3)
                {
                    Player4BlackCardText.Text = game.players[3].BlackCards.ToString();
                    Player4BlackCoinText.Text = game.players[3].BlackCoins.ToString();
                    Player4WhiteCoinText.Text = game.players[3].WhiteCoins.ToString();
                    Player4WhiteCardText.Text = game.players[3].WhiteCards.ToString();
                    Player4WildCoinText.Text = game.players[3].WildCoins.ToString();
                    Player4BlueCardText.Text = game.players[3].BlueCards.ToString();
                    Player4BlueCoinText.Text = game.players[3].BlueCoins.ToString();
                    Player4GreenCardText.Text = game.players[3].GreenCards.ToString();
                    Player4GreenCoinText.Text = game.players[3].GreenCoins.ToString();
                    Player4RedCardText.Text = game.players[3].RedCards.ToString();
                    Player4RedCoinText.Text = game.players[3].RedCoins.ToString();
                    Player4Score.Text = game.players[3].Score.ToString();

                    if (firstTime)
                    {
                        Player4BlackCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Black));
                        Player4BlackCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Black));
                        Player4WhiteCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.White));
                        Player4WhiteCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.White));
                        Player4BlueCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Blue));
                        Player4BlueCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Blue));
                        Player4RedCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Red));
                        Player4RedCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Red));
                        Player4GreenCard.Image = new Bitmap(DirectorySelector.getReqRectangle(Models.Colors.Green));
                        Player4GreenCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Green));
                        Player4WildCoins.Image = new Bitmap(DirectorySelector.getReqCircle(Models.Colors.Wild));
                    }
                    
                }
            }

            resetHeldCards();

            firstTime = false;

        }

        public void resetHeldCards()
        {

            switch (this.game.players[this.game.ActivePlayer].HeldCards.Count)
            {
                case 0:
                    deck1.Visible = false;
                    deck2.Visible = false;
                    deck3.Visible = false;
                    card1.Visible = false;
                    card2.Visible = false;
                    card3.Visible = false;
                    break;
                case 1:
                    deck1.setLevel(game.players[this.game.ActivePlayer].HeldCards[0].Level);
                    card1.setCard(game.players[this.game.ActivePlayer].HeldCards[0], false);

                    deck1.Visible = !showHide;
                    deck2.Visible = false;
                    deck3.Visible = false;
                    card1.Visible = showHide;
                    card2.Visible = false;
                    card3.Visible = false;

                    card1.enableHoldButton(false);

                    break;
                case 2:
                    deck1.setLevel(game.players[this.game.ActivePlayer].HeldCards[0].Level);
                    card1.setCard(game.players[this.game.ActivePlayer].HeldCards[0], false);

                    deck2.setLevel(game.players[this.game.ActivePlayer].HeldCards[1].Level);
                    card2.setCard(game.players[this.game.ActivePlayer].HeldCards[1], false);

                    deck1.Visible = !showHide;
                    deck2.Visible = !showHide;
                    deck3.Visible = false;
                    card1.Visible = showHide;
                    card2.Visible = showHide;
                    card3.Visible = false;

                    card1.enableHoldButton(false);
                    card2.enableHoldButton(false);

                    break;
                case 3:
                    deck1.setLevel(game.players[this.game.ActivePlayer].HeldCards[0].Level);
                    card1.setCard(game.players[this.game.ActivePlayer].HeldCards[0], false);

                    deck2.setLevel(game.players[this.game.ActivePlayer].HeldCards[1].Level);
                    card2.setCard(game.players[this.game.ActivePlayer].HeldCards[1], false);

                    deck3.setLevel(game.players[this.game.ActivePlayer].HeldCards[2].Level);
                    card3.setCard(game.players[this.game.ActivePlayer].HeldCards[2], false);

                    deck1.Visible = !showHide;
                    deck2.Visible = !showHide;
                    deck3.Visible = !showHide;
                    card1.Visible = showHide;
                    card2.Visible = showHide;
                    card3.Visible = showHide;

                    card1.enableHoldButton(false);
                    card2.enableHoldButton(false);
                    card3.enableHoldButton(false);

                    break;
            }
        }

        public void hideHelds()
        {
            ShowHideButton.Text = "Show";
            showHide = false;
            resetHeldCards();
        }

        private void changeButtonText()
        {
            if (showHide)
            {
                ShowHideButton.Text = "Show";
                showHide = false;
                resetHeldCards();
            }
            else
            {
                ShowHideButton.Text = "Hide";
                showHide = true;
                resetHeldCards();
            }
        }

        private void ShowHideButton_Click(object sender, EventArgs e)
        {
            changeButtonText();
        }

        internal void CheckBuy(Models.Card card)
        {
            buySet(card, game.players[game.ActivePlayer].IsCardBuyable(card));
        }

        public void buySet(Models.Card card, bool buy)
        {
            if (card.Equals(card1.card))
            {
                card1.enableBuyButton(buy);
            }
            else if (card.Equals(card2.card))
            {
                card2.enableBuyButton(buy);
            }
            else if (card.Equals(card3.card))
            {
                card3.enableBuyButton(buy);
            }

        }

    }
}
