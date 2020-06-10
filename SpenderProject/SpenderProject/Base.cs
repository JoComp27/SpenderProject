using SpenderProject.Models;
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
        }

        public void startGame(string gameTitle, int numberOfPlayers)
        {
            game = new Game(gameTitle, numberOfPlayers);
            coins1.LoadBoard(game.board);
            shop1.loadBoard(game.board);
        }

        internal void updateDecks(int v, List<Models.Card> deck2, List<Models.Card> display2)
        {
            throw new NotImplementedException();
        }

        internal void CheckPlayerBuyHold()
        {
            throw new NotImplementedException();
        }

        internal void buyCard(Models.Card card)
        {
            throw new NotImplementedException();
        }

        internal void HoldCard(Models.Card card)
        {
            throw new NotImplementedException();
        }

        internal bool CheckPlayerCoins()
        {
            throw new NotImplementedException();
        }
    }
}
