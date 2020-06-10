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

namespace SpenderProject
{
    public partial class Deck : UserControl
    {
        public Deck()
        {
            InitializeComponent();
        }

        public void setLevel(int level)
        {
            pictureBox1.Image = (Image)ImageResizer.ResizeImage(new Bitmap(DirectorySelector.getDeckDirectory(level)), pictureBox1.Width, pictureBox1.Height);
        }

        public void setNumber(int number)
        {
            label1.Text = number.ToString();
        }
    }
}
