using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Models
{
    public class Noble
    {
        public int PortraitNumber { get; }
        public int Score { get; }

        public int WhiteRequirement { get; }

        public int BlackRequirement { get; }

        public int BlueRequirement { get; }

        public int RedRequirement { get; }

        public int GreenRequirement { get; }

        public Noble(int score, int whiteRequirement, int blackRequirement, int blueRequirement, int redRequirement, int greenRequirement)
        {
            Score = score;
            WhiteRequirement = whiteRequirement;
            BlackRequirement = blackRequirement;
            BlueRequirement = blueRequirement;
            RedRequirement = redRequirement;
            GreenRequirement = greenRequirement;
        }

        public Noble(List<int> attributes)
        {
            PortraitNumber = attributes[0];
            Score = attributes[1];

            BlackRequirement = attributes[2];
            WhiteRequirement = attributes[3];
            RedRequirement = attributes[4];
            BlueRequirement = attributes[5];
            GreenRequirement = attributes[6];
        }

    }
}
