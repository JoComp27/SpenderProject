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
    public partial class GameBoard : Form
    {

        public Game game { get; set; }

        public GameBoard()
        {
            InitializeComponent();

            this.BackgroundImage = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getBackground()), this.Width, this.Height);
            this.EndGameLabel.Visible = false;

            startGame("New Game", 2);
        }

        public void startGame(string gameTitle, int numberOfPlayers)
        {
            Game newGame = new Game(gameTitle, numberOfPlayers);
            this.game = newGame;
            UpdateComponents(newGame);
        }

        internal void endActivePlayerTurn()
        {

            this.game.CheckNobles(this.game.players[this.game.ActivePlayer]); //CHECK NOBLES 

            int gameWinner = game.GameIsDone(); //CHECK IF GAME DONE

            if (gameWinner != -1) //THERE IS A WINNER
            {
                coins1.Visible = false;
                shop1.Visible = false;
                EndGameLabel.Text = "PLAYER " + gameWinner + " WINS!!!";
                EndGameLabel.Visible = true;
                Console.WriteLine("GAME IS OVER!");
                
            }
            else //THERE IS NO WINNER
            {
                if (CheckPlayerCoinCount()) //CHECK IF PLAYER HAD TOO MANY COINS)
                nextPlayer();
            }
            
        }

        internal void nextPlayer()
        {
            this.game.endCurrentTurn(); //MAKE THE GAME UPDATE THE TURN
            playerStatus1.hideHelds(); //HIDE CURRENT PLAYER HELD CARDS
            UpdateComponents(this.game); //UPDATE ALL THE COMPONENTS
        }

        private Boolean CheckPlayerCoinCount()
        {
            if (!this.game.checkActivePlayerCoins())
            {

                lockUI();

                if (this.game.ActivePlayer % 2 == 0)
                {
                    playerStatus1.LoadCoinRemover(0);
                }
                else
                {
                    playerStatus1.LoadCoinRemover(1);
                }

                unlockUI();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lockUI()
        {
            coins1.Enabled = false;
            shop1.Enabled = false;
            playerStatus1.Enabled = false;
        }

        private void unlockUI()
        {
            coins1.Enabled = true;
            shop1.Enabled = true;
            playerStatus1.Enabled = true;
        }

        internal void UpdateGame(Game game)
        {
            this.game = new Game(game);
            UpdateComponents(this.game);
        }

        public void UpdateComponents(Game game)
        {
            coins1.LoadGame(game);
            shop1.LoadGame(game);
            playerStatus1.loadGame(game);
        }

    }
}
