using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpenderProject.Models
{
    class Noble
    {

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

        public Noble(int[] attributes)
        {
            Score = attributes[0];

            BlackRequirement = attributes[1];
            WhiteRequirement = attributes[2];
            RedRequirement = attributes[3];
            BlueRequirement = attributes[4];
            GreenRequirement = attributes[5];
        }

    }
}
