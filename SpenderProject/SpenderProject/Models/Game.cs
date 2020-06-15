using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Models
{
    public class Game
    {
        string gameTitle;

        public Board board { get; set; }
        public int ActivePlayer { get; set; } = 0;
        public List<Player> players { get; set; }

        public int numberOfPlayers;

        public int firstWinner = -1;

        public Game(string gameTitle, int numberOfPlayers)
        {
            this.gameTitle = gameTitle;
            this.players = new List<Player>();

            board = new Board(numberOfPlayers);

            for(int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player((i + 1).ToString()));
            }

            this.numberOfPlayers = numberOfPlayers;

        }



        public void endCurrentTurn()
        {
            ActivePlayer = (ActivePlayer + 1) % numberOfPlayers;
        }

        public List<Models.Colors> currentPlayerBuysCard(Card card)
        {
            return players[ActivePlayer].BuyCard(card);
        }

        public void currentPlayerHoldsCard(Card card)
        {
            players[ActivePlayer].holdCard(card);
        }

        public bool checkBuy(Card card)
        {
            return players[ActivePlayer].IsCardBuyable(card);
        }

        public bool checkHold(Models.Card card)
        {
            return players[ActivePlayer].isCardHoldable(card);
        }

        internal void giveCoinsToActivePlayer(List<Colors> coins)
        {

            int white = 0;
            int blue = 0;
            int red = 0;
            int black = 0;
            int wild = 0;
            int green = 0;

            for(int i = 0; i < coins.Count; i++)
            {
                switch (coins[i])
                {
                    case Colors.White:
                        white++;
                        break;
                    case Colors.Blue:
                        blue++;
                        break;
                    case Colors.Red:
                        red++;
                        break;
                    case Colors.Black:
                        black++;
                        break;
                    case Colors.Wild:
                        wild++;
                        break;
                    case Colors.Green:
                        green++;
                        break;
                }
            }

            players[ActivePlayer].AddCoins(white, black, red, blue, green, wild);

        }



        internal int GameIsDone()
        {
            if(firstWinner == -1)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].Score >= 15)
                    {
                        firstWinner = i;
                    }
                }
            }

            if(firstWinner != -1 && ActivePlayer == players.Count - 1)
            {

                int max = players[firstWinner].Score;
                int maxIndex = firstWinner;

                for (int i = 0; i < players.Count; i++)
                {
                    if (players[firstWinner].Score < players[i].Score)
                    {
                        max = players[i].Score;
                        maxIndex = i;
                    }
                }

                return maxIndex;
            }

            return -1; ;

        }

        internal void currentPlayerAddWildCoin()
        {
            players[ActivePlayer].AddCoins(0, 0, 0, 0, 0, 1);
        }

        internal bool checkActivePlayerCoins()
        {
            return players[ActivePlayer].CheckCoinCount();
        }
    }
}
