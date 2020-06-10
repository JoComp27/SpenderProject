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

        public void loadBoard(Models.Board board)
        {
            this.board = board;

            if (firstTime)
            {
                firstTime = false;

                this.parent = this.Parent as Base;

                deck1.setLevel(1);
                deck2.setLevel(2);
                deck3.setLevel(3);


            }
            

            deck1.setNumber(board.Deck1.Count);
            deck2.setNumber(board.Deck2.Count);
            deck3.setNumber(board.Deck3.Count);

            card3_1.setCard(board.Display3[0]);
            card3_2.setCard(board.Display3[1]);
            card3_3.setCard(board.Display3[2]);
            card3_4.setCard(board.Display3[3]);

            card2_1.setCard(board.Display2[0]);
            card2_2.setCard(board.Display2[1]);
            card2_3.setCard(board.Display2[2]);
            card2_4.setCard(board.Display2[3]);

            card1_1.setCard(board.Display1[0]);
            card1_2.setCard(board.Display1[1]);
            card1_3.setCard(board.Display1[2]);
            card1_4.setCard(board.Display1[3]);

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
                            card1_1.setCard(blankCard);
                            break;
                        case 2:
                            card1_2.setCard(blankCard);
                            break;
                        case 3:
                            card1_3.setCard(blankCard);
                            break;
                        case 4:
                            card1_4.setCard(blankCard);
                            break;
                    }
                    break;
                case 2:
                    switch (index)
                    {
                        case 1:
                            card2_1.setCard(blankCard);
                            break;
                        case 2:
                            card2_2.setCard(blankCard);
                            break;
                        case 3:
                            card2_3.setCard(blankCard);
                            break;
                        case 4:
                            card2_4.setCard(blankCard);
                            break;
                    }
                    break;
                case 3:
                    switch (index)
                    {
                        case 1:
                            card3_1.setCard(blankCard);
                            break;
                        case 2:
                            card3_2.setCard(blankCard);
                            break;
                        case 3:
                            card3_3.setCard(blankCard);
                            break;
                        case 4:
                            card3_4.setCard(blankCard);
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
                        case 1:
                            card1_1.setCard(card);
                            break;
                        case 2:
                            card1_2.setCard(card);
                            break;
                        case 3:
                            card1_3.setCard(card);
                            break;
                        case 4:
                            card1_4.setCard(card);
                            break;
                    }
                    break;
                case 2:
                    switch (index)
                    {
                        case 1:
                            card2_1.setCard(card);
                            break;
                        case 2:
                            card2_2.setCard(card);
                            break;
                        case 3:
                            card2_3.setCard(card);
                            break;
                        case 4:
                            card2_4.setCard(card);
                            break;
                    }
                    break;
                case 3:
                    switch (index)
                    {
                        case 1:
                            card3_1.setCard(card);
                            break;
                        case 2:
                            card3_2.setCard(card);
                            break;
                        case 3:
                            card3_3.setCard(card);
                            break;
                        case 4:
                            card3_4.setCard(card);
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

                    replaceCard(cardLevel, i, board.Deck1[0]);
                    board.Deck1.RemoveAt(0);
                    parent.updateDecks(1, board.Deck1, board.Display1); // UPDATE DISPLAY1 and DECK1 in GLOBAL DECK
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

                    replaceCard(cardLevel, i, board.Deck2[0]);
                    board.Deck2.RemoveAt(0);
                    parent.updateDecks(2, board.Deck2, board.Display2); // UPDATE DISPLAY2 and DECK2 in GLOBAL DECK
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
                    
                    replaceCard(cardLevel, i, board.Deck3[0]);
                    board.Deck3.RemoveAt(0);
                    parent.updateDecks(3, board.Deck3, board.Display3); // UPDATE DISPLAY3 and DECK3 in GLOBAL DECK
                    break;
            }

        }

        internal void CheckBuyHold(Models.Card card)
        {
            parent.CheckPlayerBuyHold();
            throw new NotImplementedException();
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
                    replaceCard(cardLevel, i, board.Deck1[0]);
                    board.Deck1.RemoveAt(0);
                    parent.updateDecks(1, board.Deck1, board.Display1); // UPDATE DISPLAY1 and DECK1 in GLOBAL DECK
                    parent.buyCard(card); //ADD PLAYER BUY CARD
                    break;

                case 2:
                    for (i = 0; i < board.Display2.Count; i++)
                    {
                        if (board.Display2[i].Equals(card))
                        {
                            break;
                        }
                    }
                    replaceCard(cardLevel, i, board.Deck2[0]);
                    board.Deck2.RemoveAt(0);
                    parent.updateDecks(2, board.Deck2, board.Display2); // UPDATE DISPLAY2 and DECK2 in GLOBAL DECK
                    parent.buyCard(card); //ADD PLAYER BUY CARD
                    break;

                case 3:
                    for (i = 0; i < board.Display3.Count; i++)
                    {
                        if (board.Display3[i].Equals(card))
                        {
                            break;
                        }
                    }
                    replaceCard(cardLevel, i, board.Deck3[0]);
                    board.Deck3.RemoveAt(0);
                    parent.updateDecks(3, board.Deck3, board.Display3); // UPDATE DISPLAY3 and DECK3 in GLOBAL DECK
                    parent.buyCard(card); //ADD PLAYER BUY CARD
                    break;
            }
        }
    }
}
