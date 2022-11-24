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
using SpenderProject.Models;

namespace SpenderProject
{
    public partial class Shop : UserControl
    {

        GameBoard parent;
        public Game game { get; set; }
        bool firstTime = true;

        public Shop()
        {
            InitializeComponent();
        }

        public void LoadGame(Game game)
        {
            this.game = game;
            Board board = this.game.board;

            if (!firstTime)
            {
                setNobles();
            }

            if (firstTime)
            {
                firstTime = false;

                this.parent = this.Parent as GameBoard;

                deck1.setLevel(1);
                deck2.setLevel(2);
                deck3.setLevel(3);

                if (game.numberOfPlayers == 2)
                {
                    noble3.setNoble(board.DisplayNoble[0]);
                    noble4.setNoble(board.DisplayNoble[1]);
                    noble5.setNoble(board.DisplayNoble[2]);
                }
                else if(game.numberOfPlayers == 3)
                {
                    noble2.setNoble(board.DisplayNoble[0]);
                    noble3.setNoble(board.DisplayNoble[1]);
                    noble4.setNoble(board.DisplayNoble[2]);
                    noble5.setNoble(board.DisplayNoble[3]);
                }
                else if (game.numberOfPlayers == 4)
                {
                    noble1.setNoble(board.DisplayNoble[0]);
                    noble2.setNoble(board.DisplayNoble[1]);
                    noble3.setNoble(board.DisplayNoble[2]);
                    noble4.setNoble(board.DisplayNoble[3]);
                    noble5.setNoble(board.DisplayNoble[4]);
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

        public void setNobles()
        {
            switch (game.board.DisplayNoble.Count)
            {
                case 4:
                    noble1.setNoble(null);
                    noble2.setNoble(game.board.DisplayNoble[0]);
                    noble3.setNoble(game.board.DisplayNoble[1]);
                    noble4.setNoble(game.board.DisplayNoble[2]);
                    noble5.setNoble(game.board.DisplayNoble[3]);
                    break;
                case 3:
                    noble1.setNoble(null);
                    noble2.setNoble(null);
                    noble3.setNoble(game.board.DisplayNoble[0]);
                    noble4.setNoble(game.board.DisplayNoble[1]);
                    noble5.setNoble(game.board.DisplayNoble[2]);
                    break;
                case 2:
                    noble1.setNoble(null);
                    noble1.setNoble(null);
                    noble3.setNoble(null);
                    noble4.setNoble(game.board.DisplayNoble[0]);
                    noble5.setNoble(game.board.DisplayNoble[1]);
                    break;
                case 1:
                    noble1.setNoble(null);
                    noble1.setNoble(null);
                    noble3.setNoble(null);
                    noble4.setNoble(null);
                    noble5.setNoble(game.board.DisplayNoble[0]);
                    break;
                case 0:
                    noble1.setNoble(null);
                    noble1.setNoble(null);
                    noble3.setNoble(null);
                    noble4.setNoble(null);
                    noble5.setNoble(null);
                    break;
            }
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
                    for (i = 0; i < game.board.Display1.Count; i++)
                    {
                        if (game.board.Display1[i].Equals(card))
                        {
                            break;
                        }
                    }
                    
                    if (game.currentPlayerHoldsCard(card)) //ADD PLAYER HOLD CARD
                    {
                        removeCard(cardLevel, i);
                        game.board.replaceDeck1Card(i);
                        parent.UpdateGame(game);
                        parent.endActivePlayerTurn();
                    }
                    
                    break;

                case 2:
                    for (i = 0; i < game.board.Display2.Count; i++)
                    {
                        if (game.board.Display2[i].Equals(card))
                        {
                            break;
                        }
                    }
                    if (game.currentPlayerHoldsCard(card)) //ADD PLAYER HOLD CARD
                    {
                        removeCard(cardLevel, i);
                        game.board.replaceDeck2Card(i);
                        parent.UpdateGame(game);                        
                        parent.endActivePlayerTurn();
                    }
                    break;

                case 3:
                    for (i = 0; i < game.board.Display3.Count; i++)
                    {
                        if (game.board.Display3[i].Equals(card))
                        {
                            break;
                        }
                    }
                    if (game.currentPlayerHoldsCard(card)) //ADD PLAYER HOLD CARD
                    {
                        removeCard(cardLevel, i);
                        game.board.replaceDeck3Card(i);
                        parent.UpdateGame(game);
                        parent.endActivePlayerTurn();
                    }
                    break;
            }

        }

        internal void CheckBuyHold(Models.Card card)
        {
            bool isBuyable = game.checkBuy(card);
            bool isHoldable = game.checkHold(card);

            buyHoldSet(card, isBuyable, isHoldable);
        }

        public void buyHoldSet(Models.Card card, bool buy, bool hold)
        {

            int level = card.Level;
            int cardNumber = -1;

            switch (level)
            {
                case 1:
                    for(int i = 0; i < game.board.Display1.Count; i++)
                    {

                        if (game.board.Display1[i].Equals(card))
                        {
                            cardNumber = i;
                        }
                        
                    }
                    break;
                case 2:
                    for (int i = 0; i < game.board.Display2.Count; i++)
                    {
                        if (game.board.Display2[i].Equals(card))
                        {
                            cardNumber = i;
                        }

                    }
                    break;
                case 3:
                    for (int i = 0; i < game.board.Display3.Count; i++)
                    {
                        if (game.board.Display3[i].Equals(card))
                        {
                            cardNumber = i;
                        }

                    }
                    break;
            }

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
                    for(i = 0; i < game.board.Display1.Count; i++)
                    {
                        if (game.board.Display1[i].Equals(card))
                        {
                            break;
                        }
                    }
                    game.board.replaceDeck1Card(i);
                    game.currentPlayerBuysCard(card, false);//ADD PLAYER BUY CARD
                    parent.UpdateGame(game);
                    parent.endActivePlayerTurn();
                    break;

                case 2:
                    for (i = 0; i < game.board.Display2.Count; i++)
                    {
                        if (game.board.Display2[i].Equals(card))
                        {
                            break;
                        }
                    }
                    game.board.replaceDeck2Card(i);
                    game.currentPlayerBuysCard(card, false);//ADD PLAYER BUY CARD
                    parent.UpdateGame(game); 
                    parent.endActivePlayerTurn();
                    break;

                case 3:
                    for (i = 0; i < game.board.Display3.Count; i++)
                    {
                        if (game.board.Display3[i].Equals(card))
                        {
                            break;
                        }
                    }
                    game.board.replaceDeck3Card(i);
                    game.currentPlayerBuysCard(card, false);//ADD PLAYER BUY CARD
                    parent.UpdateGame(game);
                    parent.endActivePlayerTurn();
                    break;
            }
        }
    }
}
