using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Models
{
    class Card
    {
        public Colors Color { get; }

        public int Points { get; }

        public int Level { get; }

        public int WhiteCost { get; }

        public int BlueCost { get; }

        public int GreenCost { get; }

        public int RedCost { get; }

        public int BlackCost { get; }

        public Card(Colors Color, int Level, int Points, int WhiteCost, int BlueCost, int GreenCost, int RedCost, int BlackCost)
        {
            this.Color = Color;
            this.Level = Level;
            this.Points = Points;
            
            this.WhiteCost = WhiteCost;
            this.BlueCost = BlueCost;
            this.GreenCost = GreenCost;
            this.RedCost = RedCost;
            this.BlackCost = BlackCost;
        }

        public Card(List<int> attributes)
        {
            this.Color = (Colors)attributes[0];
            this.Level = attributes[1];
            this.Points = attributes[2];

            this.BlackCost = attributes[3];
            this.WhiteCost = attributes[4];
            this.RedCost = attributes[5];
            this.BlueCost = attributes[6];
            this.GreenCost = attributes[7];
        }



    }
}
