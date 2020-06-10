using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpenderProject.Tools;
using SpenderProject.Models;

namespace SpenderProject
{
    public partial class Noble : UserControl
    {
        public Models.Noble noble;

        public Noble()
        {
            InitializeComponent();
        }

        public void visibleNoble(bool value)
        {
            this.Visible = value;
        }

        public void setNoble(Models.Noble noble)
        {
            this.noble = noble;

            this.BackgroundImage = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getNobleDirectory(noble.PortraitNumber)), this.Width, this.Height);

            List<Colors> cardColors = new List<Colors>();

            ReqNum1.Text = "";
            ReqNum2.Text = "";
            ReqNum3.Text = "";

            requirementImage1.Visible = false;
            requirementImage2.Visible = false;
            requirementImage3.Visible = false;

            if (noble.BlackRequirement > 0)
            {
                cardColors.Add(Colors.Black);
            }

            if (noble.BlueRequirement > 0)
            {
                cardColors.Add(Colors.Blue);
            }

            if (noble.RedRequirement > 0)
            {
                cardColors.Add(Colors.Red);
            }

            if (noble.WhiteRequirement > 0)
            {
                cardColors.Add(Colors.White);
            }

            if (noble.GreenRequirement > 0)
            {
                cardColors.Add(Colors.Green);
            }

            int markers = 1;

            for (int i = 0; i < cardColors.Count; i++)
            {
                if (cardColors[i] == Colors.Black)
                {

                    string rectangle = DirectorySelector.getReqRectangle(Colors.Black);
                    string cost = noble.BlackRequirement.ToString();

                    requirementImage1.Image = (Image)new Bitmap(rectangle);
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

                    string rectangle = DirectorySelector.getReqRectangle(Colors.Red);
                    string cost = noble.RedRequirement.ToString();

                    switch (markers)
                    {
                        case 1:
                            requirementImage1.Image = (Image)new Bitmap(rectangle);
                            ReqNum1.Text = cost;
                            requirementImage1.Visible = true;
                            break;
                        case 2:
                            requirementImage2.Image = (Image)new Bitmap(rectangle);
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
                    string rectangle = DirectorySelector.getReqRectangle(Colors.Green);
                    string cost = noble.GreenRequirement.ToString();

                    switch (markers)
                    {
                        case 1:
                            requirementImage1.Image = (Image)new Bitmap(rectangle);
                            ReqNum1.Text = cost;
                            requirementImage1.Visible = true;
                            break;
                        case 2:
                            requirementImage2.Image = (Image)new Bitmap(rectangle);
                            ReqNum2.Text = cost;
                            requirementImage2.Visible = true;
                            break;
                        case 3:
                            requirementImage3.Image = (Image)new Bitmap(rectangle);
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
                    string rectangle = DirectorySelector.getReqRectangle(Colors.Blue);
                    string cost = noble.BlueRequirement.ToString();

                    switch (markers)
                    {
                        case 1:
                            requirementImage1.Image = (Image)new Bitmap(rectangle);
                            ReqNum1.Text = cost;
                            requirementImage1.Visible = true;
                            break;
                        case 2:
                            requirementImage2.Image = (Image)new Bitmap(rectangle);
                            ReqNum2.Text = cost;
                            requirementImage2.Visible = true;
                            break;
                        case 3:
                            requirementImage3.Image = (Image)new Bitmap(rectangle);
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
                if (cardColors[i] == Colors.White)
                {
                    string rectangle = DirectorySelector.getReqRectangle(Colors.White);
                    string cost = noble.WhiteRequirement.ToString();

                    switch (markers)
                    {
                        case 1:
                            requirementImage1.Image = (Image)new Bitmap(rectangle);
                            ReqNum1.Text = cost;
                            requirementImage1.Visible = true;
                            break;
                        case 2:
                            requirementImage2.Image = (Image)new Bitmap(rectangle);
                            ReqNum2.Text = cost;
                            requirementImage2.Visible = true;
                            break;
                        case 3:
                            requirementImage3.Image = (Image)new Bitmap(rectangle);
                            ReqNum3.Text = cost;
                            requirementImage3.Visible = true;
                            break;
                    }

                    markers++;

                    cardColors.RemoveAt(i);
                }
            }

        }

    }
}
