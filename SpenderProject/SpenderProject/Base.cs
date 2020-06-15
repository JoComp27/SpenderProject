using SpenderProject.Models;
using SpenderProject.Resources.Images;
using SpenderProject.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpenderProject
{
    public partial class Base : Form
    {

        public Game game;

        public Base()
        {
            InitializeComponent();

            startGame("New Game", 2);

            this.BackgroundImage = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getBackground()), this.Width, this.Height);
            this.EndGameLabel.Visible = false;
        }

        public void startGame(string gameTitle, int numberOfPlayers)
        {
            game = new Game(gameTitle, numberOfPlayers);
            coins1.LoadBoard(game.board);
            shop1.loadBoard(game.board, numberOfPlayers);
            playerStatus1.loadGame(game);
        }

        internal void CheckPlayerBuyHold(Models.Card card)
        {
            Console.WriteLine("BASE");
            
            bool isBuyable = game.checkBuy(card);
            bool isHoldable = game.checkHold(card);

            shop1.buyHoldSet(card, isBuyable, isHoldable);

        }

        internal void buyCard(Models.Card card)
        {

            coins1.addCoins(game.currentPlayerBuysCard(card));
            
            playerStatus1.loadGame(game);
        }

        internal void HoldCard(Models.Card card)
        {
            game.currentPlayerHoldsCard(card);
            playerStatus1.loadGame(game);

            if (coins1.board.WildCoins > 0)
            {
                coins1.removeCoin(Models.Colors.Wild);
            }
        }

        internal bool CheckPlayerCoins()
        {
            return game.checkActivePlayerCoins();
        }

        internal void giveCoinsToActivePlayer(List<Colors> coins)
        {
            game.giveCoinsToActivePlayer(coins);
            playerStatus1.loadGame(game);
        }

        internal void endActivePlayerTurn()
        {
            playerStatus1.CheckPlayerCoinCount();

            int nobleIndex = shop1.CheckNobles(game.players[game.ActivePlayer]);
            if (nobleIndex != -1) //ADD NOBLES CHECK!
            {
                game.players[game.ActivePlayer].Score += shop1.board.DeckNoble[nobleIndex].Score;
                shop1.removeNoble(nobleIndex);
            }

            int gameWinner = game.GameIsDone();

            if (gameWinner == -1)
            {
                game.endCurrentTurn();
                playerStatus1.hideHelds();
                playerStatus1.loadGame(game);
            }
            else
            {
                coins1.Visible = false;
                shop1.Visible = false;
                EndGameLabel.Text = "PLAYER " + gameWinner + " WINS!!!";
                EndGameLabel.Visible = true;
                Console.WriteLine("GAME IS OVER!");
            }
            
        }

        internal void removeExcessCoins(List<Colors> colors)
        {
            game.players[game.ActivePlayer].RemoveCoins(colors);
            playerStatus1.loadGame(game);
        }

        internal void lockUI()
        {
            coins1.Enabled = false;
            shop1.Enabled = false;
        }

        internal void unlockUI()
        {
            coins1.Enabled = true;
            shop1.Enabled = true;
        }
    }
}
