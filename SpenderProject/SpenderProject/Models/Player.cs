using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Models
{
    public class Player
    {
        public string PlayerName { get; set; }
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

        public List<Card> HeldCards { get; set; }

        public Player(string PlayerName)
        {

            this.PlayerName = PlayerName;

            this.Score = 0;

            this.WhiteCoins = 0;
            this.WhiteCards = 0;

            this.BlackCoins = 0;
            this.BlackCards = 0;

            this.BlueCoins = 0;
            this.BlueCards = 0;

            this.RedCoins = 0;
            this.RedCards = 0;

            this.GreenCoins = 0;
            this.GreenCards = 0;

            this.WildCoins = 0;

            this.HeldCards = new List<Card>();
        }

        public Player(string playerName, int score, int whiteCoins, int blueCoins, int greenCoins, int redCoins, int blackCoins, int wildCoins, int whiteCards, int blueCards, int greenCards, int redCards, int blackCards, List<Card> heldCards) : this(playerName)
        {
            Score = score;
            WhiteCoins = whiteCoins;
            BlueCoins = blueCoins;
            GreenCoins = greenCoins;
            RedCoins = redCoins;
            BlackCoins = blackCoins;
            WildCoins = wildCoins;
            WhiteCards = whiteCards;
            BlueCards = blueCards;
            GreenCards = greenCards;
            RedCards = redCards;
            BlackCards = blackCards;
            HeldCards = heldCards;
        }



        //Function for when a player attempts to buy a card
        public void BuyCard(Card card)
        {
            if (IsCardBuyable(card))
            {
                //Increment Score by card's score
                Score += card.Points;

                //Remove any needed coins for the transaction
                if(card.WhiteCost != 0)
                {
                    int removedAmount = card.WhiteCost - WhiteCards;

                    if (WhiteCoins >= removedAmount)
                    {
                        WhiteCoins = ((removedAmount > 0) ? WhiteCoins - removedAmount : WhiteCoins);
                    }
                    else
                    {
                        int diff = removedAmount - WhiteCoins;
                        WildCoins -= diff;
                        WhiteCoins = 0;
                    }
                    
                }

                if(card.BlackCost != 0)
                {
                    int removedAmount = card.BlackCost - BlackCards;

                    if (BlackCoins >= removedAmount)
                    {
                        BlackCoins = ((removedAmount > 0) ? BlackCoins - removedAmount : BlackCoins);
                    }
                    else
                    {
                        int diff = removedAmount - BlackCoins;
                        WildCoins -= diff;
                        BlackCoins = 0;
                    }

                }

                if(card.RedCost != 0)
                {
                    int removedAmount = card.RedCost - RedCards;

                    if (RedCoins >= removedAmount)
                    {
                        RedCoins = ((removedAmount > 0) ? RedCoins - removedAmount : RedCoins);
                    }
                    else
                    {
                        int diff = removedAmount - RedCoins;
                        WildCoins -= diff;
                        RedCoins = 0;
                    }

                }

                if(card.BlueCost != 0)
                {
                    int removedAmount = card.BlueCost - BlueCards;

                    if (BlueCoins >= removedAmount)
                    {
                        BlueCoins = ((removedAmount > 0) ? BlueCoins - removedAmount : BlueCoins);
                    }
                    else
                    {
                        int diff = removedAmount - BlueCoins;
                        WildCoins -= diff;
                        BlueCoins = 0;
                    }

                }
                if(card.GreenCost != 0)
                {
                    int removedAmount = card.GreenCost - GreenCards;

                    if (GreenCoins >= removedAmount)
                    {
                        GreenCoins = ((removedAmount > 0) ? GreenCoins - removedAmount : GreenCoins);
                    }
                    else
                    {
                        int diff = removedAmount - GreenCoins;
                        WildCoins -= diff;
                        GreenCoins = 0;
                    }

                }

                switch (card.Color)
                {
                    case Colors.White:
                        WhiteCards++;
                        break;
                    case Colors.Black:
                        BlackCards++;
                        break;
                    case Colors.Blue:
                        BlueCards++;
                        break;
                    case Colors.Red:
                        RedCards++;
                        break;
                    case Colors.Green:
                        GreenCards++;
                        break;

                }

            }
            else
            {
                //TODO: ADD VISUAL INDICATOR FOR ILLEGAL BUY
                Console.WriteLine("PLAYER IS ATTEMPTING TO BUY A CARD, ILLEGAL MOVE");
            }
        }

        public Boolean IsCardBuyable(Card card)
        {

            int tempWildCoins = WildCoins;

            if (!(card.WhiteCost <= WhiteCoins + WhiteCards))
            {
                int diff = card.WhiteCost - (WhiteCoins + WhiteCards);
                if (diff > tempWildCoins)
                    return false;
                else
                    tempWildCoins -= diff;
                
            }

            if (!(card.BlackCost <= BlackCoins + BlackCards))
            {
                int diff = card.BlackCost - (BlackCoins + BlackCards);
                if (diff > tempWildCoins)
                    return false;
                else
                    tempWildCoins -= diff;

            }

            if (!(card.RedCost <= RedCoins + RedCards))
            {
                int diff = card.RedCost - (RedCoins + RedCards);
                if (diff > tempWildCoins)
                    return false;
                else
                    tempWildCoins -= diff;

            }

            if (!(card.BlueCost <= BlueCoins + BlueCards))
            {
                int diff = card.BlueCost - (BlueCoins + BlueCards);
                if (diff > tempWildCoins)
                    return false;
                else
                    tempWildCoins -= diff;

            }

            if (!(card.GreenCost <= GreenCoins + GreenCards))
            {
                int diff = card.GreenCost - (GreenCoins + GreenCards);
                if (diff > tempWildCoins)
                    return false;
                else
                    tempWildCoins -= diff;

            }

            return true;
        }

        public bool isCardHoldable(Models.Card card)
        {
            return HeldCards.Count < 4;
        }

        public void holdCard(Card card)
        {
            if(HeldCards.Count < 4)
            {
                WildCoins++; //TODO: FIX THIS TO REMOVE COINS FROM BOARD
                HeldCards.Add(card);
            }
            else
            {
                //TODO: ADD VISUAL INDICATOR FOR ILLEGAL HOLD
                Console.WriteLine("PLAYER IS ATTEMPTING TO HOLD A CARD, ILLEGAL MOVE");
            }
        }

        public void buyHeldCard(int heldCardIndex)
        {
            Card temp = HeldCards[heldCardIndex];

            if (IsCardBuyable(temp))
            {
                BuyCard(temp);
                HeldCards.RemoveAt(heldCardIndex);
            }
            else
            {
                //TODO: ADD VISUAL INDICATOR FOR ILLEGAL BUYING HELD CARD
                Console.WriteLine("PLAYER IS ATTEMPTING TO BUY A HELD CARD, ILLEGAL MOVE");
            }

        }

        public bool CheckCoinCount()
        {
            return GetSumOfCoins() < 10;
        }

        public void AddCoins(int white, int black, int red, int blue, int green, int wild)
        {
            WhiteCoins += white;
            BlackCoins += black;
            RedCoins += red;
            BlueCoins += blue;
            GreenCoins += green;
            WildCoins += wild;

            CheckCoinCount(); //TODO: ADD REMOVING COINS PART FROM HERE
        }

        public void RemoveCoins(int white, int black, int red, int blue, int green, int wild)
        {
            WhiteCoins -= white;
            BlackCoins -= black;
            RedCoins -= red;
            BlueCoins -= blue;
            GreenCoins -= green;
            WildCoins -= wild;
        }

        private int GetSumOfCoins()
        {
            return WhiteCoins + BlueCoins + GreenCoins + RedCoins + BlackCoins + WildCoins;
        }

    }
}
