using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcVerse1
{
    class FederationTracker
    {
        List<FederationData> allFeds;
        List<FederationData> activeFeds;
        List<FederationData> defunctFeds;

        int CloseWeighting = 0;

        public FederationTracker()
        {
            allFeds = new List<FederationData>();
            activeFeds = new List<FederationData>();
            defunctFeds = new List<FederationData>();
        }

        public int ActiveCount
        {
            get
            {
                if (activeFeds != null)
                    return activeFeds.Count;
                else
                    return 0;
            }
        }

        public FederationData GenerateNewFed(string date)
        {
            FederationData fed = new FederationData();
            fed.FedName = "New Federation " + (allFeds.Count + 1);
            fed.FedInitials = "NF" + (allFeds.Count + 1);
            fed.OpenDate = date;
            allFeds.Add(fed);
            activeFeds.Add(fed);
            return fed;
        }

        public FederationData CloseAFed(string date, Random g)
        {
            int closeNumber = g.Next(1, CloseWeighting+1);
            int cumulativeWeight = 0;
            foreach (FederationData fed in activeFeds)
            {
                cumulativeWeight += (100 - fed.Success);
                if(cumulativeWeight > closeNumber)
                {
                    fed.CloseDate = date;
                    defunctFeds.Add(fed);
                    activeFeds.Remove(fed);
                    return fed;
                }
            }
            return null;
        }

        public void AdvanceMonth(Random g, float baseCloseFedChance)
        {
            CloseWeighting = 0;
            foreach (FederationData fed in activeFeds)
            {
                int fedWeight = 100 - fed.AdjustSuccess(g, baseCloseFedChance);
                CloseWeighting += fed.ClosingLikelihood;
            }
        }

        public string ActiveFedStatus()
        {
            string s = "There are " + activeFeds.Count + " active companies." + Environment.NewLine;

            foreach (FederationData fed in activeFeds)
            {
                s += fed.FedName + ", opened in " + fed.OpenDate + " (" + fed.Success + ")" + Environment.NewLine;
            }

            return s;
        }
    }
}
