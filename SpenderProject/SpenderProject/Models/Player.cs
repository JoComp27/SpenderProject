using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Models
{
    class Player
    {

        public int Score { get; set; }

        public int WhiteCoins { get; set; }
        public int BlueCoins { get; set; }
        public int GreenCoins { get; set; }
        public int RedCoins { get; set; }
        public int BlackCoins { get; set; }
        public int WildCoins { get; set; }

        public int WhiteCards { get; set; }
        public int BlueCards { get; set; }
        public int GreenCards { get; set; }
        public int RedCards { get; set; }
        public int BlackCards { get; set; }

        public void buyCard(Card card)
        {
            if (IsCardBuyable(card))
            {
                Score += card.Points;
            }
            else
            {
                Console.WriteLine("Trying to buy a card you can't afford");
            }
        }

        public Boolean IsCardBuyable(Card card)
        {
            return false;
        }

        public int getSumOfCoins()
        {
            return WhiteCoins + BlueCoins + GreenCoins + RedCoins + BlackCoins + WildCoins;
        }

    }
}
