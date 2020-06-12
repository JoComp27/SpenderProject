using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpenderProject
{
    public partial class Shop : UserControl
    {

        Base parent;
        Models.Board board;
        bool firstTime = true;

        public Shop()
        {
            InitializeComponent();
        }

        public void loadBoard(Models.Board board, int numberOfPlayers)
        {
            this.board = board;

            if (firstTime)
            {
                firstTime = false;

                this.parent = this.Parent as Base;

                deck1.setLevel(1);
                deck2.setLevel(2);
                deck3.setLevel(3);

                if (numberOfPlayers == 2)
                {
                    noble3.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble4.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble5.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                }
                else if(numberOfPlayers == 3)
                {
                    noble2.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble3.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble4.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble5.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                }
                else if (numberOfPlayers == 4)
                {
                    noble1.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble2.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble3.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble4.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                    noble5.setNoble(board.DisplayNoble[0]);
                    board.DisplayNoble.RemoveAt(0);
                }

                
            }

                card3_1.setCard(board.Display3[0], true);
                card3_2.setCard(board.Display3[1], true);
                card3_3.setCard(board.Display3[2], true);
                card3_4.setCard(board.Display3[3], true);

                card2_1.setCard(board.Display2[0], true);
                card2_2.setCard(board.Display2[1], true);
                card2_3.setCard(board.Display2[2], true);
                card2_4.setCard(board.Display2[3], true);

                card1_1.setCard(board.Display1[0], true);
                card1_2.setCard(board.Display1[1], true);
                card1_3.setCard(board.Display1[2], true);
                card1_4.setCard(board.Display1[3], true);

            deck1.setNumber(board.Deck1.Count);
            deck2.setNumber(board.Deck2.Count);
            deck3.setNumber(board.Deck3.Count);

        }

        public void removeCard(int level, int index)
        {

            Models.Card blankCard = new Models.Card(0, level, 0, 0, 0, 0, 0, 0);

            switch (level)
            {
                case 1:
                    switch (index)
                    {
                        case 1:
                            card1_1.setCard(blankCard, true);
                            break;
                        case 2:
                            card1_2.setCard(blankCard, true);
                            break;
                        case 3:
                            card1_3.setCard(blankCard, true);
                            break;
                        case 4:
                            card1_4.setCard(blankCard, true);
                            break;
                    }
                    break;
                case 2:
                    switch (index)
                    {
                        case 1:
                            card2_1.setCard(blankCard, true);
                            break;
                        case 2:
                            card2_2.setCard(blankCard, true);
                            break;
                        case 3:
                            card2_3.setCard(blankCard, true);
                            break;
                        case 4:
                            card2_4.setCard(blankCard, true);
                            break;
                    }
                    break;
                case 3:
                    switch (index)
                    {
                        case 1:
                            card3_1.setCard(blankCard, true);
                            break;
                        case 2:
                            card3_2.setCard(blankCard, true);
                            break;
                        case 3:
                            card3_3.setCard(blankCard, true);
                            break;
                        case 4:
                            card3_4.setCard(blankCard, true);
                            break;
                    }
                    break;
            }
        }

        public void replaceCard(int level, int index, Models.Card card)
        {
            switch (level)
            {
                case 1:
                    switch (index)
                    {
                        case 0:
                            card1_1.setCard(card, true);
                            break;
                        case 1:
                            card1_2.setCard(card, true);
                            break;
                        case 2:
                            card1_3.setCard(card, true);
                            break;
                        case 3:
                            card1_4.setCard(card, true);
                            break;
                    }
                    break;
                case 2:
                    switch (index)
                    {
                        case 0:
                            card2_1.setCard(card, true);
                            break;
                        case 1:
                            card2_2.setCard(card, true);
                            break;
                        case 2:
                            card2_3.setCard(card, true);
                            break;
                        case 3:
                            card2_4.setCard(card, true);
                            break;
                    }
                    break;
                case 3:
                    switch (index)
                    {
                        case 0:
                            card3_1.setCard(card, true);
                            break;
                        case 1:
                            card3_2.setCard(card, true);
                            break;
                        case 2:
                            card3_3.setCard(card, true);
                            break;
                        case 3:
                            card3_4.setCard(card, true);
                            break;
                    }
                    break;
            }
        }

        private void Shop_MouseEnter(object sender, EventArgs e)
        {
            card1_1.showButtons(false);
            card1_2.showButtons(false);
            card1_3.showButtons(false);
            card1_4.showButtons(false);

            card2_1.showButtons(false);
            card2_2.showButtons(false);
            card2_3.showButtons(false);
            card2_4.showButtons(false);

            card3_1.showButtons(false);
            card3_2.showButtons(false);
            card3_3.showButtons(false);
            card3_4.showButtons(false);
        }

        //Function for Card to call when Hold is clicked
        public void holdClicked(Models.Card card)
        {
            int cardLevel = card.Level;
            int i = 0;
            switch (cardLevel)
            {
                case 1:
                    for (i = 0; i < board.Display1.Count; i++)
                    {
                        if (board.Display1[i].Equals(card))
                        {
                            break;
                        }
                    }
                    removeCard(cardLevel, i);
                    parent.HoldCard(card);  //ADD PLAYER HOLD CARD

                    while (!parent.CheckPlayerCoins()) //CHECK PLAYER COIN COUNT!
                    {
                        Thread.Sleep(1000);
                    }

                    board.replaceDeck1Card(i);
                    parent.endActivePlayerTurn();
                    loadBoard(board, board.NumberOfPlayers);
                    break;

                case 2:
                    for (i = 0; i < board.Display2.Count; i++)
                    {
                        if (board.Display2[i].Equals(card))
                        {
                            break;
                        }
                    }
                    removeCard(cardLevel, i);
                    parent.HoldCard(card);//ADD PLAYER HOLD CARD

                    while (!parent.CheckPlayerCoins()) //CHECK PLAYER COIN COUNT!
                    {
                        Thread.Sleep(1000);
                    }

                    board.replaceDeck2Card(i);
                    parent.endActivePlayerTurn();
                    loadBoard(board, board.NumberOfPlayers);
                    break;

                case 3:
                    for (i = 0; i < board.Display3.Count; i++)
                    {
                        if (board.Display3[i].Equals(card))
                        {
                            break;
                        }
                    }
                    removeCard(cardLevel, i);
                    parent.HoldCard(card);//ADD PLAYER HOLD CARD

                    while (!parent.CheckPlayerCoins()) //CHECK PLAYER COIN COUNT!
                    {
                        Thread.Sleep(1000);
                    }
                    
                    board.replaceDeck3Card(i);
                    parent.endActivePlayerTurn();
                    loadBoard(board, board.NumberOfPlayers);
                    break;
            }

        }

        internal void CheckBuyHold(Models.Card card)
        {
            Console.WriteLine("SHOP");
            parent.CheckPlayerBuyHold(card);
        }

        public void buyHoldSet(Models.Card card, bool buy, bool hold)
        {

            int level = card.Level;
            int cardNumber = -1;

            switch (level)
            {
                case 1:
                    for(int i = 0; i < board.Display1.Count; i++)
                    {

                        if(i == 1)
                        {
                            Console.WriteLine("Board1_2: " + board.Display1[i].ToString());
                            Console.WriteLine("EQUALS");
                            Console.WriteLine("Card: " + card.ToString());
                        }

                        if (board.Display1[i].Equals(card))
                        {
                            cardNumber = i;
                        }
                        
                    }
                    break;
                case 2:
                    for (int i = 0; i < board.Display2.Count; i++)
                    {
                        if (board.Display2[i].Equals(card))
                        {
                            cardNumber = i;
                        }

                    }
                    break;
                case 3:
                    for (int i = 0; i < board.Display3.Count; i++)
                    {
                        if (board.Display3[i].Equals(card))
                        {
                            cardNumber = i;
                        }

                    }
                    break;
            }

            Console.WriteLine("Level: " + level + ", Card Number: " + cardNumber);

            switch (level)
            {
                case 1:
                    switch (cardNumber)
                    {
                        case 0:
                            card1_1.enableBuyButton(buy);
                            card1_1.enableHoldButton(hold);
                            break;
                        case 1:
                            
                            card1_2.enableBuyButton(buy);
                            card1_2.enableHoldButton(hold);
                            break;
                        case 2:
                            card1_3.enableBuyButton(buy);
                            card1_3.enableHoldButton(hold);
                            break;
                        case 3:
                            card1_4.enableBuyButton(buy);
                            card1_4.enableHoldButton(hold);
                            break;
                    }
                    break;
                case 2:
                    switch (cardNumber)
                    {
                        case 0:
                            card2_1.enableBuyButton(buy);
                            card2_1.enableHoldButton(hold);
                            break;
                        case 1:
                            card2_2.enableBuyButton(buy);
                            card2_2.enableHoldButton(hold);
                            break;
                        case 2:
                            card2_3.enableBuyButton(buy);
                            card2_3.enableHoldButton(hold);
                            break;
                        case 3:
                            card2_4.enableBuyButton(buy);
                            card2_4.enableHoldButton(hold);
                            break;
                    }
                    break;
                case 3:
                    switch (cardNumber)
                    {
                        case 0:
                            card3_1.enableBuyButton(buy);
                            card3_1.enableHoldButton(hold);
                            break;
                        case 1:
                            card3_2.enableBuyButton(buy);
                            card3_2.enableHoldButton(hold);
                            break;
                        case 2:
                            card3_3.enableBuyButton(buy);
                            card3_3.enableHoldButton(hold);
                            break;
                        case 3:
                            card3_4.enableBuyButton(buy);
                            card3_4.enableHoldButton(hold);
                            break;
                    }
                    break;
            }

        }

        //Function for Card to call when Buy is clicked
        public void buyClicked(Models.Card card)
        {
            int cardLevel = card.Level;
            int i = 0;
            switch (cardLevel)
            {
                case 1:
                    for(i = 0; i < board.Display1.Count; i++)
                    {
                        if (board.Display1[i].Equals(card))
                        {
                            break;
                        }
                    }
                    board.replaceDeck1Card(i);
                    parent.buyCard(card); //ADD PLAYER BUY CARD
                    parent.endActivePlayerTurn();
                    loadBoard(board, board.NumberOfPlayers);
                    break;

                case 2:
                    for (i = 0; i < board.Display2.Count; i++)
                    {
                        if (board.Display2[i].Equals(card))
                        {
                            break;
                        }
                    }
                    board.replaceDeck2Card(i);
                    parent.buyCard(card); //ADD PLAYER BUY CARD
                    parent.endActivePlayerTurn();
                    loadBoard(board, board.NumberOfPlayers);
                    break;

                case 3:
                    for (i = 0; i < board.Display3.Count; i++)
                    {
                        if (board.Display3[i].Equals(card))
                        {
                            break;
                        }
                    }
                    board.replaceDeck3Card(i);
                    parent.buyCard(card); //ADD PLAYER BUY CARD
                    parent.endActivePlayerTurn();
                    loadBoard(board, board.NumberOfPlayers);
                    break;
            }
        }
    }
}
