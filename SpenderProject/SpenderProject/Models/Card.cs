using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Models
{
    public class Card
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

        public override bool Equals(object obj)
        {
            return obj is Card card &&
                   Color == card.Color &&
                   Points == card.Points &&
                   Level == card.Level &&
                   WhiteCost == card.WhiteCost &&
                   BlueCost == card.BlueCost &&
                   GreenCost == card.GreenCost &&
                   RedCost == card.RedCost &&
                   BlackCost == card.BlackCost;
        }

        public override int GetHashCode()
        {
            int hashCode = -430228195;
            hashCode = hashCode * -1521134295 + Color.GetHashCode();
            hashCode = hashCode * -1521134295 + Points.GetHashCode();
            hashCode = hashCode * -1521134295 + Level.GetHashCode();
            hashCode = hashCode * -1521134295 + WhiteCost.GetHashCode();
            hashCode = hashCode * -1521134295 + BlueCost.GetHashCode();
            hashCode = hashCode * -1521134295 + GreenCost.GetHashCode();
            hashCode = hashCode * -1521134295 + RedCost.GetHashCode();
            hashCode = hashCode * -1521134295 + BlackCost.GetHashCode();
            return hashCode;
        }
    }
}
