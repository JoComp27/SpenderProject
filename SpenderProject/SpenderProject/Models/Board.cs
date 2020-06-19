using SpenderProject.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Models
{
    public class Board
    {
        public const string DeckAddress = @"..\\..\\Resources\\CSV\\Cards.csv";
        public const string NobleAddress = @"..\\..\\Resources\\CSV\\Nobles.csv";

        public int NumberOfPlayers { get; set; }
        public int NumberOfNoblesShown { get; set; }

        public List<Card> Deck1 { get; set; }
        public List<Card> Deck2 { get; set; }
        public List<Card> Deck3 { get; set; }
        public List<Noble> DeckNoble { get; set; }

        public List<Card> Display1 { get; set; }
        public List<Card> Display2 { get; set; }
        public List<Card> Display3 { get; set; }
        public List<Noble> DisplayNoble { get; set; }

        public int WhiteCoins { get; set; }
        public int BlackCoins { get; set; }
        public int BlueCoins { get; set; }
        public int RedCoins { get; set; }
        public int GreenCoins { get; set; }
        public int WildCoins { get; set; }

        public Board(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
            this.Deck1 = new List<Card>();
            this.Deck2 = new List<Card>();
            this.Deck3 = new List<Card>();

            this.Display1 = new List<Card>();
            this.Display2 = new List<Card>();
            this.Display3 = new List<Card>();

            this.DeckNoble = new List<Noble>();
            this.DisplayNoble = new List<Noble>();

            WildCoins = 5;

            if(NumberOfPlayers == 2)
            {
                WhiteCoins = 4;
                BlackCoins = 4;
                BlueCoins = 4;
                RedCoins = 4;
                GreenCoins = 4;
                NumberOfNoblesShown = 3;
            }
            else if (NumberOfPlayers == 3)
            {
                WhiteCoins = 5;
                BlackCoins = 5;
                BlueCoins = 5;
                RedCoins = 5;
                GreenCoins = 5;
                NumberOfNoblesShown = 4;
            }
            else if (NumberOfPlayers == 4)
            {
                WhiteCoins = 7;
                BlackCoins = 7;
                BlueCoins = 7;
                RedCoins = 7;
                GreenCoins = 7;
                NumberOfNoblesShown = 5;
            }

            initializeDeck();
            initializeNoble();

        }

        public Board(int whiteCoins, int blueCoins, int redCoins, int blackCoins, int greenCoins, int wildCoins)
        {
            WhiteCoins = whiteCoins;
            BlueCoins = blueCoins;
            RedCoins = redCoins;
            BlackCoins = blackCoins;
            GreenCoins = greenCoins;
            WildCoins = wildCoins;
        }

        public Board(Board board)
        {
            NumberOfNoblesShown = board.NumberOfNoblesShown;
            Deck1 = board.Deck1;
            Deck2 = board.Deck2;
            Deck3 = board.Deck3;
            DeckNoble = board.DeckNoble;
            Display1 = board.Display1;
            Display2 = board.Display2;
            Display3 = board.Display3;
            DisplayNoble = board.DisplayNoble;
            WhiteCoins = board.WhiteCoins;
            BlackCoins = board.BlackCoins;
            BlueCoins = board.BlueCoins;
            RedCoins = board.RedCoins;
            GreenCoins = board.GreenCoins;
            WildCoins = board.WildCoins;
        }

        private void initializeDeck()
        {
            List<List<int>> intDeck = FileReader.ReadFile(DeckAddress);

            //Creating Cards and setting them to the decks
            for (int i = 0; i < intDeck.Count; i++)
            {
                Card newCard = new Card(intDeck[i]);

                if (intDeck[i][1] == 1)
                {
                    Deck1.Add(newCard);
                }
                else if (intDeck[i][1] == 2)
                {
                    Deck2.Add(newCard);
                }
                else if (intDeck[i][1] == 3)
                {
                    Deck3.Add(newCard);
                }
            }

            //Shuffling Decks
            ShuffleDecks();

            //Turning 4 cards from each deck
            for(int i = 0; i < 4; i++)
            {
                Display1.Add(Deck1[0]);
                Deck1.RemoveAt(0);
                Display2.Add(Deck2[0]);
                Deck2.RemoveAt(0);
                Display3.Add(Deck3[0]);
                Deck3.RemoveAt(0);
            }

        }

        private void initializeNoble()
        {
            List<List<int>> intNoble = FileReader.ReadFile(NobleAddress);

            //Creating and setting the nobles
            for(int i = 0; i < intNoble.Count; i++)
            {
                DeckNoble.Add(new Noble(intNoble[i]));
            }

            //Shuffling the nobles
            ShuffleNobles();

            //Turning X nobles for the board
            for(int i = 0; i < NumberOfNoblesShown; i++)
            {
                DisplayNoble.Add(DeckNoble[0]);
                DeckNoble.RemoveAt(0);
            }

        }

        private void ShuffleDecks()
        {

            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<Card> newDeck1 = new List<Card>();
            List<Card> newDeck2 = new List<Card>();
            List<Card> newDeck3 = new List<Card>();

            int deck1Size = Deck1.Count;
            int deck2Size = Deck2.Count;
            int deck3Size = Deck3.Count;

            for (int i = 0; i < deck1Size; i++)
            {
                int max = deck1Size - (i+1);
                max = ((max == -1)? 0 : max);

                int index = random.Next(0, max);
                newDeck1.Add(Deck1[index]);
                Deck1.RemoveAt(index);
            }

            Deck1 = newDeck1;

            for (int i = 0; i < deck2Size; i++)
            {
                int max = deck2Size - (i + 1);
                max = ((max == -1) ? 0 : max);

                int index = random.Next(0, max);
                newDeck2.Add(Deck2[index]);
                Deck2.RemoveAt(index);
            }

            Deck2 = newDeck2;

            for (int i = 0; i < deck3Size; i++)
            {
                int max = deck3Size - (i + 1);
                max = ((max == -1) ? 0 : max);

                int index = random.Next(0, max);
                newDeck3.Add(Deck3[index]);
                Deck3.RemoveAt(index);
            }

            Deck3 = newDeck3;

        }

        private void ShuffleNobles()
        {

            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<Noble> newNobles = new List<Noble>();

            for(int i = 0; i < DeckNoble.Count; i++)
            {
                int max = DeckNoble.Count - (i + 1);

                int index = random.Next(0, max);
                newNobles.Add(DeckNoble[index]);
                DeckNoble.RemoveAt(index);
            }

            DeckNoble = newNobles;

        }

        public void replaceDeck1Card(int index)
        {
            Display1[index] = Deck1[0];
            Deck1.RemoveAt(0);
        }

        public void replaceDeck2Card(int index)
        {
            Display2[index] = Deck2[0];
            Deck2.RemoveAt(0);
        }

        public void replaceDeck3Card(int index)
        {
            Display3[index] = Deck3[0];
            Deck3.RemoveAt(0);
        }

        public void removeNoble(int index)
        {
            DisplayNoble.RemoveAt(index);
        }


        public void removeCoin(Colors color)
        {
            switch (color)
            {
                case Colors.White:
                    WhiteCoins--;
                    break;
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
                case Colors.Wild:
                    WildCoins--;
                    break;
            }
        }

        public void addCoin(Colors color)
        {
            switch (color)
            {
                case Colors.White:
                    WhiteCoins++;
                    break;
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
                case Colors.Wild:
                    WildCoins++;
                    break;
            }
        }

        public void setCoins(int whiteCoins, int blueCoins, int redCoins, int blackCoins, int greenCoins, int wildCoins)
        {
            WhiteCoins = whiteCoins;
            BlueCoins = blueCoins;
            RedCoins = redCoins;
            BlackCoins = blackCoins;
            GreenCoins = greenCoins;
            WildCoins = wildCoins;
        }

    }
}
