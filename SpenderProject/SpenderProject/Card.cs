using SpenderProject.Models;
using SpenderProject.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace SpenderProject
{
    public partial class Card : UserControl
    {

        public Models.Card card { get; set; }
        Shop parentForm;
        PlayerStatus playerStatusParent;
        bool firstTime = true;
        bool ShopCard;

        public Card()
        {
            InitializeComponent();
            buyButton.Visible = false;
            holdButton.Visible = false;
        }

        public void setCard(Models.Card card, bool shopCard)
        {

            this.ShopCard = shopCard;

            if (this.card == null || this.card != null && !this.card.Equals(card))
            {

                this.card = new Models.Card(card);

                if (firstTime)
                {
                    firstTime = false;

                    if (shopCard)
                    {
                        parentForm = (this.Parent as Shop);
                    }
                    else
                    {
                        playerStatusParent = (this.Parent as PlayerStatus);
                    }


                }

                this.BackgroundImage = (Image)ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getBackgroundPath(card)), this.Width, this.Height);
                ColorImage.Image = (Image)ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getGemDirectory(card)), ColorImage.Width, ColorImage.Height);

                if (card.Points != 0)
                {
                    Score.Text = card.Points.ToString();
                }
                else
                {
                    Score.Text = "";
                }


                List<Colors> cardColors = new List<Colors>();

                ReqNum1.Text = "";
                ReqNum2.Text = "";
                ReqNum3.Text = "";
                ReqNum4.Text = "";

                requirementImage1.Visible = false;
                requirementImage2.Visible = false;
                requirementImage3.Visible = false;
                requirementImage4.Visible = false;

                if (card.BlackCost > 0)
                {
                    cardColors.Add(Colors.Black);
                }

                if (card.BlueCost > 0)
                {
                    cardColors.Add(Colors.Blue);
                }

                if (card.RedCost > 0)
                {
                    cardColors.Add(Colors.Red);
                }

                if (card.WhiteCost > 0)
                {
                    cardColors.Add(Colors.White);
                }

                if (card.GreenCost > 0)
                {
                    cardColors.Add(Colors.Green);
                }

                int markers = 1;

                for (int i = 0; i < cardColors.Count; i++)
                {
                    if (cardColors[i] == Colors.Black)
                    {

                        string circle = DirectorySelector.getReqCircle(Colors.Black);
                        string cost = card.BlackCost.ToString();

                        requirementImage1.Image = (Image)new Bitmap(circle);
                        ReqNum1.Text = cost;

                        requirementImage1.Visible = true;

                        markers++;

                        cardColors.RemoveAt(i);
                    }
                }

                for (int i = 0; i < cardColors.Count; i++)
                {
                    if (cardColors[i] == Colors.Red)
                    {

                        string circle = DirectorySelector.getReqCircle(Colors.Red);
                        string cost = card.RedCost.ToString();

                        switch (markers)
                        {
                            case 1:
                                requirementImage1.Image = (Image)new Bitmap(circle);
                                ReqNum1.Text = cost;
                                requirementImage1.Visible = true;
                                break;
                            case 2:
                                requirementImage2.Image = (Image)new Bitmap(circle);
                                ReqNum2.Text = cost;
                                requirementImage2.Visible = true;
                                break;
                        }

                        markers++;

                        cardColors.RemoveAt(i);
                    }
                }

                for (int i = 0; i < cardColors.Count; i++)
                {
                    if (cardColors[i] == Colors.Green)
                    {
                        string circle = DirectorySelector.getReqCircle(Colors.Green);
                        string cost = card.GreenCost.ToString();

                        switch (markers)
                        {
                            case 1:
                                requirementImage1.Image = (Image)new Bitmap(circle);
                                ReqNum1.Text = cost;
                                requirementImage1.Visible = true;
                                break;
                            case 2:
                                requirementImage2.Image = (Image)new Bitmap(circle);
                                ReqNum2.Text = cost;
                                requirementImage2.Visible = true;
                                break;
                            case 3:
                                requirementImage3.Image = (Image)new Bitmap(circle);
                                ReqNum3.Text = cost;
                                requirementImage3.Visible = true;
                                break;
                        }

                        markers++;

                        cardColors.RemoveAt(i);
                    }
                }

                for (int i = 0; i < cardColors.Count; i++)
                {
                    if (cardColors[i] == Colors.Blue)
                    {
                        string circle = DirectorySelector.getReqCircle(Colors.Blue);
                        string cost = card.BlueCost.ToString();

                        switch (markers)
                        {
                            case 1:
                                requirementImage1.Image = (Image)new Bitmap(circle);
                                ReqNum1.Text = cost;
                                requirementImage1.Visible = true;
                                break;
                            case 2:
                                requirementImage2.Image = (Image)new Bitmap(circle);
                                ReqNum2.Text = cost;
                                requirementImage2.Visible = true;
                                break;
                            case 3:
                                requirementImage3.Image = (Image)new Bitmap(circle);
                                ReqNum3.Text = cost;
                                requirementImage3.Visible = true;
                                break;
                            case 4:
                                requirementImage4.Image = (Image)new Bitmap(circle);
                                ReqNum4.Text = cost;
                                requirementImage4.Visible = true;
                                break;
                        }

                        markers++;

                        cardColors.RemoveAt(i);
                    }
                }

                for (int i = 0; i < cardColors.Count; i++)
                {
                    if (cardColors[i] == Colors.White)
                    {
                        string circle = DirectorySelector.getReqCircle(Colors.White);
                        string cost = card.WhiteCost.ToString();

                        switch (markers)
                        {
                            case 1:
                                requirementImage1.Image = (Image)new Bitmap(circle);
                                ReqNum1.Text = cost;
                                requirementImage1.Visible = true;
                                break;
                            case 2:
                                requirementImage2.Image = (Image)new Bitmap(circle);
                                ReqNum2.Text = cost;
                                requirementImage2.Visible = true;
                                break;
                            case 3:
                                requirementImage3.Image = (Image)new Bitmap(circle);
                                ReqNum3.Text = cost;
                                requirementImage3.Visible = true;
                                break;
                            case 4:
                                requirementImage4.Image = (Image)new Bitmap(circle);
                                ReqNum4.Text = cost;
                                requirementImage4.Visible = true;
                                break;
                        }

                        markers++;

                        cardColors.RemoveAt(i);
                    }
                }

        }

        }

        public void showButtons(bool value)
        {
            buyButton.Visible = value;
            holdButton.Visible = value;
        }

        public void enableBuyButton(bool value)
        {
            buyButton.Enabled = value;
        }

        public void enableHoldButton(bool value)
        {
            holdButton.Enabled = value;
        }

        private void backgroundPicture_mouseEntered(object sender, EventArgs e)
        {
            showButtons(true);
            parentForm.CheckBuyHold(card);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (ShopCard)
            {
                parentForm.buyClicked(card);
            }
            else
            {
                playerStatusParent.buyCard(card);
            }

        }

        private void holdButton_Click(object sender, EventArgs e)
        {
            if (ShopCard)
            {
                parentForm.holdClicked(card);
            }
        }

        private void backgroundPicture_mouseEntered(object sender, MouseEventArgs e)
        {
            showButtons(true);
            if (ShopCard)
            {
                parentForm.CheckBuyHold(card);
            }
            else
            {
                playerStatusParent.CheckBuy(card);
            }
        }


    }
}
