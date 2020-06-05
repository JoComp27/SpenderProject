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

        public int WhiteCost { get; }

        public int BlueCost { get; }

        public int GreenCost { get; }

        public int RedCost { get; }

        public int BlackCost { get; }

        public Card(Colors Color, int Points, int WhiteCost, int BlueCost, int GreenCost, int RedCost, int BlackCost)
        {
            this.Color = Color;
            this.Points = Points;

            this.WhiteCost = WhiteCost;
            this.BlueCost = BlueCost;
            this.GreenCost = GreenCost;
            this.RedCost = RedCost;
            this.BlackCost = BlackCost;
        }


    }
}
