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
        public List<Models.Colors> BuyCard(Card card)
        {
            if (IsCardBuyable(card))
            {
                List<Models.Colors> colors = new List<Models.Colors>();

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
                                colors.Add(Models.Colors.White);
                            }

                        }
                    }
                    else
                    {
                        int diff = removedAmount - WhiteCoins;
                        WildCoins -= diff;

                        for(int i = 0; i < diff; i++)
                        {
                            colors.Add(Models.Colors.Wild);
                        }

                        for(int i = 0; i < WhiteCoins; i++)
                        {
                            colors.Add(Models.Colors.White);
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
                                colors.Add(Models.Colors.Black);
                            }
                        }
                    }
                    else
                    {
                        int diff = removedAmount - BlackCoins;
                        WildCoins -= diff;

                        for (int i = 0; i < diff; i++)
                        {
                            colors.Add(Models.Colors.Wild);
                        }

                        for (int i = 0; i < WhiteCoins; i++)
                        {
                            colors.Add(Models.Colors.White);
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
                                colors.Add(Models.Colors.Red);
                            }
                        }
                    }
                    else
                    {
                        int diff = removedAmount - RedCoins;
                        WildCoins -= diff;

                        for (int i = 0; i < diff; i++)
                        {
                            colors.Add(Models.Colors.Wild);
                        }

                        for (int i = 0; i < RedCoins; i++)
                        {
                            colors.Add(Models.Colors.Red);
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
                                colors.Add(Models.Colors.Blue);
                            }
                        }
                    }
                    else
                    {
                        int diff = removedAmount - BlueCoins;
                        WildCoins -= diff;

                        for (int i = 0; i < diff; i++)
                        {
                            colors.Add(Models.Colors.Wild);
                        }

                        for (int i = 0; i < BlueCoins; i++)
                        {
                            colors.Add(Models.Colors.Blue);
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
                                colors.Add(Models.Colors.Green);
                            }
                        }
                    }
                    else
                    {
                        int diff = removedAmount - GreenCoins;
                        WildCoins -= diff;

                        for (int i = 0; i < diff; i++)
                        {
                            colors.Add(Models.Colors.Wild);
                        }

                        for (int i = 0; i < GreenCoins; i++)
                        {
                            colors.Add(Models.Colors.Green);
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
                return new List<Models.Colors>();
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
                case Models.Colors.Black:
                    BlackCoins++;
                    break;
                case Models.Colors.Blue:
                    BlueCoins++;
                    break;
                case Models.Colors.Green:
                    GreenCoins++;
                    break;
                case Models.Colors.Red:
                    RedCoins++;
                    break;
                case Models.Colors.White:
                    WhiteCoins++;
                    break;
                case Models.Colors.Wild:
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

        public void holdCard(Card card)
        {
            if(HeldCards.Count < 4)
            {
                WildCoins++;
                HeldCards.Add(card);
            }
            else
            {
                //ADD VISUAL INDICATOR FOR ILLEGAL HOLD
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
                Console.WriteLine("PLAYER IS ATTEMPTING TO BUY A HELD CARD, ILLEGAL MOVE");
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

        public void RemoveCoins(List<Models.Colors> colors)
        {
            foreach(Models.Colors color in colors)
            {
                switch (color)
                {
                    case Models.Colors.Black:
                        BlackCoins--;
                        break;
                    case Models.Colors.Blue:
                        BlueCoins--;
                        break;
                    case Models.Colors.Green:
                        GreenCoins--;
                        break;
                    case Models.Colors.Red:
                        RedCoins--;
                        break;
                    case Models.Colors.White:
                        WhiteCoins--;
                        break;
                    case Models.Colors.Wild:
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
