﻿using SpenderProject.Models;
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
                game.currentPlayerAddWildCoin();
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
            game.endCurrentTurn();
            playerStatus1.hideHelds();
            playerStatus1.loadGame(game);
            //TODO: Trigger Player UI to change Active visual
        }
    }
}
