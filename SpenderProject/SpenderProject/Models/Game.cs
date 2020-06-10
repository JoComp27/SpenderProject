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

        public Game(string gameTitle, int numberOfPlayers)
        {
            this.gameTitle = gameTitle;

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

        public void currentPlayerBuysCard(Card card)
        {
            players[ActivePlayer].BuyCard(card);
        }

        public void currentPlayerHoldsCard(Card card)
        {
            players[ActivePlayer].holdCard(card);
        }

    }
}
