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
            Score.Text = "";
            ReqNum1.Text = "";
            ReqNum2.Text = "";
            ReqNum3.Text = "";
        }

        public void visibleNoble(bool value)
        {
            this.Visible = value;
        }

        public void setNoble(Models.Noble noble)
        {
            this.noble = noble;

            if (this.noble == null)
            {
                this.Hide();
            }
            else
            {

                requirementImage1.Visible = false;
                requirementImage2.Visible = false;
                
                ReqNum1.Visible = false;
                ReqNum2.Visible = false;
                

                this.BackgroundImage = ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getNobleDirectory(noble.PortraitNumber)), this.Width, this.Height);

                List<Colors> cardColors = new List<Colors>();

                Score.Text = (noble.Score).ToString();

                var colors = new Dictionary<Colors, int>();

                if (noble.BlackRequirement > 0)
                {
                    colors.Add(Colors.Black, noble.BlackRequirement);
                }

                if (noble.BlueRequirement > 0)
                {
                    colors.Add(Colors.Blue, noble.BlueRequirement);
                }

                if (noble.RedRequirement > 0)
                {
                    colors.Add(Colors.Red, noble.RedRequirement);
                }

                if (noble.WhiteRequirement > 0)
                {
                    colors.Add(Colors.White, noble.WhiteRequirement);
                }

                if (noble.GreenRequirement > 0)
                {
                    colors.Add(Colors.Green, noble.GreenRequirement);
                }

                if(colors.Count > 2)
                {

                }
                else
                {
                    ReqNum3.Text = "";
                    ReqNum3.Visible = false;
                    requirementImage3.Visible = false;
                }

                int markers = 1;

                if (colors.ContainsKey(Colors.Black))
                {
                    string rectangle = DirectorySelector.getReqRectangle(Colors.Black);
                    string cost = noble.BlackRequirement.ToString();

                    requirementImage1.Image = (Image)new Bitmap(rectangle);
                    ReqNum1.Text = cost;

                    requirementImage1.Visible = true;
                    ReqNum1.Visible = true;

                    markers++;

                    colors.Remove(Colors.Black);
                }

                if (colors.ContainsKey(Colors.Red))
                {
                    string rectangle = DirectorySelector.getReqRectangle(Colors.Red);
                    string cost = noble.RedRequirement.ToString();

                    switch (markers)
                    {
                        case 1:
                            requirementImage1.Image = (Image)new Bitmap(rectangle);
                            ReqNum1.Text = cost;
                            requirementImage1.Visible = true;
                            ReqNum1.Visible = true;
                            break;
                        case 2:
                            requirementImage2.Image = (Image)new Bitmap(rectangle);
                            ReqNum2.Text = cost;
                            requirementImage2.Visible = true;
                            ReqNum2.Visible = true;
                            break;
                    }

                    markers++;

                    colors.Remove(Colors.Red);
                }

                if(colors.Count != 0 && colors.ContainsKey(Colors.Green))
                {
                    string rectangle = DirectorySelector.getReqRectangle(Colors.Green);
                    string cost = noble.GreenRequirement.ToString();

                    switch (markers)
                    {
                        case 1:
                            requirementImage1.Image = (Image)new Bitmap(rectangle);
                            ReqNum1.Text = cost;
                            requirementImage1.Visible = true;
                            ReqNum1.Visible = true;
                            break;
                        case 2:
                            requirementImage2.Image = (Image)new Bitmap(rectangle);
                            ReqNum2.Text = cost;
                            requirementImage2.Visible = true;
                            ReqNum2.Visible = true;
                            break;
                        case 3:
                            requirementImage3.Image = (Image)new Bitmap(rectangle);
                            ReqNum3.Text = cost;
                            requirementImage3.Visible = true;
                            ReqNum3.Visible = true;
                            break;
                    }

                    markers++;

                    cardColors.Remove(Colors.Green);
                }

                if (colors.Count != 0 && colors.ContainsKey(Colors.Blue))
                {
                    string rectangle = DirectorySelector.getReqRectangle(Colors.Blue);
                    string cost = noble.BlueRequirement.ToString();

                    switch (markers)
                    {
                        case 1:
                            requirementImage1.Image = (Image)new Bitmap(rectangle);
                            ReqNum1.Text = cost;
                            requirementImage1.Visible = true;
                            ReqNum1.Visible = true;
                            break;
                        case 2:
                            requirementImage2.Image = (Image)new Bitmap(rectangle);
                            ReqNum2.Text = cost;
                            requirementImage2.Visible = true;
                            ReqNum2.Visible = true;
                            break;
                        case 3:
                            requirementImage3.Image = (Image)new Bitmap(rectangle);
                            ReqNum3.Text = cost;
                            requirementImage3.Visible = true;
                            ReqNum3.Visible = true;
                            break;
                    }

                    markers++;

                    cardColors.Remove(Colors.Blue);

                }

                if (colors.Count != 0 && colors.ContainsKey(Colors.White))
                {
                    string rectangle = DirectorySelector.getReqRectangle(Colors.White);
                    string cost = noble.WhiteRequirement.ToString();

                    switch (markers)
                    {
                        case 1:
                            requirementImage1.Image = (Image)new Bitmap(rectangle);
                            ReqNum1.Text = cost;
                            requirementImage1.Visible = true;
                            ReqNum1.Visible = true;
                            break;
                        case 2:
                            requirementImage2.Image = (Image)new Bitmap(rectangle);
                            ReqNum2.Text = cost;
                            requirementImage2.Visible = true;
                            ReqNum2.Visible = true;
                            break;
                        case 3:
                            requirementImage3.Image = (Image)new Bitmap(rectangle);
                            ReqNum3.Text = cost;
                            requirementImage3.Visible = true;
                            ReqNum3.Visible = true;
                            break;
                    }

                    markers++;

                    cardColors.Remove(Colors.White);
                }

            }

        }

    }
}
