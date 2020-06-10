using SpenderProject.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Tools
{
    public static class DirectorySelector
    {

        public static string getBackgroundPath(Models.Card card)
        {

            return @"..\\..\\Resources\\Images\\" + Enum.GetName(typeof(Colors), card.Color) + card.Level + ".jpg";

        }

        public static string getGemDirectory(Models.Card card)
        {
            return @"..\\..\\Resources\\Images\\" + Enum.GetName(typeof(Colors), card.Color) + "Gem.jpg";
        }

        public static string getChipDirectory(Colors color)
        {
                return @"..\\..\\Resources\\Images\\" + Enum.GetName(typeof(Colors), color) + "Chip.jpg";
        }

        public static string getDeckDirectory(int level)
        {
            return @"..\\..\\Resources\\Images\\Deck" + level + ".jpg";
        }

        public static string getNobleDirectory(int number)
        {
            return @"..\\..\\Resources\\Images\\Noble" + number + ".jpg";
        }

        public static string getReqCircle(Models.Colors color)
        {
            return @"..\\..\\Resources\\Images\\Req" + Enum.GetName(typeof(Colors), color) + ".jpg";
        }

        public static string getReqRectangle(Models.Colors color)
        {
            return @"..\\..\\Resources\\Images\\Card" + Enum.GetName(typeof(Colors), color) + ".jpg";
        }

        public static string getBackground()
        {
            return @"..\\..\\Resources\\Images\\Background.jpg";
        }

    }
}
