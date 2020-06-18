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


        //Function for when a player attempts to buy a card
        public List<Colors> BuyCard(Card card, bool held)
        {
            if (IsCardBuyable(card) && !held || held && IsCardBuyable(card) && checkIfActuallyHeld(card))
            {
                List<Colors> colors = new List<Colors>();

                //Increment Score by card's score
                Score += card.Points;

                //Remove any needed coins for the transaction
                if(card.WhiteCost != 0)
                {
                    int removedAmount = card.WhiteCost - WhiteCards;

                    if (WhiteCoins >= removedAmount)
                    {
                        if(removedAmount > 0)
                        {
                            WhiteCoins -= removedAmount;

                            for(int i = 0; i < removedAmount; i++)
                            {
                                colors.Add(Colors.White);
                            }

                        }
                    }
                    else
                    {
                        int diff = removedAmount - WhiteCoins;
                        WildCoins -= diff;

                        for(int i = 0; i < diff; i++)
                        {
                            colors.Add(Colors.Wild);
                        }

                        for(int i = 0; i < WhiteCoins; i++)
                        {
                            colors.Add(Colors.White);
                        }

                        WhiteCoins = 0;
                    }
                    
                }

                if(card.BlackCost != 0)
                {
                    int removedAmount = card.BlackCost - BlackCards;

                    if (BlackCoins >= removedAmount)
                    {
                        if(removedAmount > 0)
                        {
                            BlackCoins -= removedAmount;
                            for (int i = 0; i < removedAmount; i++)
                            {
                                colors.Add(Colors.Black);
                            }
                        }
                    }
                    else
                    {
                        int diff = removedAmount - BlackCoins;
                        WildCoins -= diff;

                        for (int i = 0; i < diff; i++)
                        {
                            colors.Add(Colors.Wild);
                        }

                        for (int i = 0; i < WhiteCoins; i++)
                        {
                            colors.Add(Colors.White);
                        }

                        BlackCoins = 0;
                    }

                }

                if(card.RedCost != 0)
                {
                    int removedAmount = card.RedCost - RedCards;

                    if (RedCoins >= removedAmount)
                    {
                        if(removedAmount > 0)
                        {
                            RedCoins -= removedAmount;
                            for(int i = 0; i < removedAmount; i++)
                            {
                                colors.Add(Colors.Red);
                            }
                        }
                    }
                    else
                    {
                        int diff = removedAmount - RedCoins;
                        WildCoins -= diff;

                        for (int i = 0; i < diff; i++)
                        {
                            colors.Add(Colors.Wild);
                        }

                        for (int i = 0; i < RedCoins; i++)
                        {
                            colors.Add(Colors.Red);
                        }

                        RedCoins = 0;
                    }

                }

                if(card.BlueCost != 0)
                {
                    int removedAmount = card.BlueCost - BlueCards;

                    if (BlueCoins >= removedAmount)
                    {
                        if(removedAmount > 0)
                        {
                            BlueCoins -= removedAmount;
                            for (int i = 0; i < removedAmount; i++)
                            {
                                colors.Add(Colors.Blue);
                            }
                        }
                    }
                    else
                    {
                        int diff = removedAmount - BlueCoins;
                        WildCoins -= diff;

                        for (int i = 0; i < diff; i++)
                        {
                            colors.Add(Colors.Wild);
                        }

                        for (int i = 0; i < BlueCoins; i++)
                        {
                            colors.Add(Colors.Blue);
                        }

                        BlueCoins = 0;
                    }

                }
                if(card.GreenCost != 0)
                {
                    int removedAmount = card.GreenCost - GreenCards;

                    if (GreenCoins >= removedAmount)
                    {
                        if(removedAmount > 0)
                        {
                            GreenCoins -= removedAmount;
                            for (int i = 0; i < removedAmount; i++)
                            {
                                colors.Add(Colors.Green);
                            }
                        }
                    }
                    else
                    {
                        int diff = removedAmount - GreenCoins;
                        WildCoins -= diff;

                        for (int i = 0; i < diff; i++)
                        {
                            colors.Add(Colors.Wild);
                        }

                        for (int i = 0; i < GreenCoins; i++)
                        {
                            colors.Add(Colors.Green);
                        }

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

                return colors;

            }
            else
            {

                //ADD VISUAL INDICATOR FOR ILLEGAL BUY
                Console.WriteLine("PLAYER IS ATTEMPTING TO BUY A CARD, ILLEGAL MOVE");
                return new List<Colors>();
            }
        }

        private bool checkIfActuallyHeld(Models.Card card)
        {
            int index = -1;

            for (int i = 0; i < HeldCards.Count; i++)
            {
                if (card.Equals(HeldCards[i]))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                HeldCards.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
                Console.WriteLine("PLAYER IS ATTEMPTING TO BUY AN UNKNOWN HELD CARD, ILLEGAL MOVE");
            }

        }

        internal bool isNobleBuyable(Noble noble)
        {
            bool black = BlackCards >= noble.BlackRequirement;
            bool blue = BlueCards >= noble.BlueRequirement;
            bool red = RedCards >= noble.RedRequirement;
            bool green = GreenCards >= noble.GreenRequirement;
            bool white = WhiteCards >= noble.WhiteRequirement;

            return black && blue && red && green && white;
        }

        internal void AddCoin(Colors colors)
        {
            switch (colors)
            {
                case Colors.Black:
                    BlackCoins++;
                    break;
                case Colors.Blue:
                    BlueCoins++;
                    break;
                case Colors.Green:
                    GreenCoins++;
                    break;
                case Colors.Red:
                    RedCoins++;
                    break;
                case Colors.White:
                    WhiteCoins++;
                    break;
                case Colors.Wild:
                    WildCoins++;
                    break;
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
            return HeldCards.Count < 3;
        }

        public bool holdCard(Card card)
        {
            if(HeldCards.Count < 4)
            {
                HeldCards.Add(card);
                return true;
            }
            else
            {
                return false;
                //ADD VISUAL INDICATOR FOR ILLEGAL HOLD
                Console.WriteLine("PLAYER IS ATTEMPTING TO HOLD A CARD, ILLEGAL MOVE");
            }
        }

        public bool CheckCoinCount()
        {
            return GetSumOfCoins() <= 10;
        }

        public void AddCoins(int white, int black, int red, int blue, int green, int wild)
        {
            WhiteCoins += white;
            BlackCoins += black;
            RedCoins += red;
            BlueCoins += blue;
            GreenCoins += green;
            WildCoins += wild;

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

        public void RemoveCoins(List<Colors> colors)
        {
            foreach(Colors color in colors)
            {
                switch (color)
                {
                    case Colors.Black:
                        BlackCoins--;
                        break;
                    case Colors.Blue:
                        BlueCoins--;
                        break;
                    case Colors.Green:
                        GreenCoins--;
                        break;
                    case Colors.Red:
                        RedCoins--;
                        break;
                    case Colors.White:
                        WhiteCoins--;
                        break;
                    case Colors.Wild:
                        WildCoins--;
                        break;

                }
            }
        }

        public int GetSumOfCoins()
        {
            return WhiteCoins + BlueCoins + GreenCoins + RedCoins + BlackCoins + WildCoins;
        }

    }
}
