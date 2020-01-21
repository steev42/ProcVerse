using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcVerse1
{
    class FederationData
    {
        public bool Active = true;
        public string FedName;
        public string FedInitials;
        public string OpenDate;
        public string CloseDate;

        public int Age = 0;

        public int Success = 0;
        private int NegativeRun = 0;

        public int ClosingLikelihood
        {
            get
            {
                int chance = 1;
                if (Success < 0)
                    chance += 5;
                chance += NegativeRun;
                chance = Math.Min(chance,Age);
                                
                return chance;
            }
        }

        public int AdjustSuccess(Random g, float baseCloseFedChance = 0f)
        {
            Age++;
            double roll = g.NextDouble();

            if (roll < 0.1)
            {
                Success -= 3;
                NegativeRun += 2;
            }
            else if (roll < 0.15)
            {
                Success -= 2;
                NegativeRun += 1;
            }
            else if (roll < 0.25)
            {
                Success -= 1;
                NegativeRun += 1;
            }
            else if (roll > 0.9)
            {
                Success += 3;
                NegativeRun = 0;
            }
            else if (roll > 0.85)
            {
                Success += 2;
                NegativeRun = 0;
            }
            else if (roll > 0.75)
            {
                Success += 1;
                NegativeRun = Math.Max(0, NegativeRun - 2);
            }
            else
            {
                NegativeRun = Math.Max(0, NegativeRun - 1);
            }

           /* if (Success < 0)
                Success = 0;
            if (Success > 100)
                Success = 100;*/

            return Success;
        }
    }
}
