using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcVerse1
{
    public partial class Form1 : Form
    {
        readonly float MININUM_NEW_FED_CHANCE = 0.05f;
        readonly float MINIMUM_CLOSE_FED_CHANCE = 0.001f;
        readonly float MAXIMUM_CLOSE_FED_CHANCE = 0.95f;

        public Form1()
        {
            InitializeComponent();
        }

        int randomSeed;
        Random generator;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHistoryMonthStart.SelectedIndex = 0;
            //cmbHistoryMonthEnd.SelectedIndex = 11;
            cmbGameStartMonth.SelectedIndex = 0;            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtSeed.Text.Length == 0)
            {
                MakeSeed();
            }
            Generate();
        }

        private void MakeSeed()
        {
            Random r = new Random();
            string alphabet = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ@#%";
            string seedString = "";
            for (int i = 0; i < 20; i++)
            {
                seedString += alphabet[r.Next(0, alphabet.Length)];
            }
            txtSeed.Text = seedString;
        }

        private void Generate()
        {
            txtResults.Text = "";
            randomSeed = txtSeed.Text.GetHashCode();
            generator = new Random(randomSeed);

            int monthStart = ((int)numHistoryYearStart.Value * 12) + cmbHistoryMonthStart.SelectedIndex;
            int dbDate = ((int)numGameStartYear.Value * 12) + cmbGameStartMonth.SelectedIndex;

            int numberOfMonthsToGenerate = dbDate - monthStart;
            txtResults.Text = txtResults.Text + "Generating " + numberOfMonthsToGenerate + " months, starting with " + InterpretMonth(monthStart) + Environment.NewLine;
            GenerateFederationHistory(numberOfMonthsToGenerate, (int)numFinalSupportedFeds.Value ,generator, monthStart);
        }

        private void GenerateFederationHistory(int monthsToGen, int finalSupportedFeds, Random g, int startingMonthID)
        {
            FederationTracker ft = new FederationTracker();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < monthsToGen; i++)
            {
                float desiredFeds = (((float)i + 1) * finalSupportedFeds) / monthsToGen;
                float newFedChance = desiredFeds - ft.ActiveCount;
                float closeFedChance = ft.ActiveCount - desiredFeds - 0.75f;

                if (closeFedChance < MINIMUM_CLOSE_FED_CHANCE)
                    closeFedChance = MINIMUM_CLOSE_FED_CHANCE;
                if (closeFedChance > MAXIMUM_CLOSE_FED_CHANCE)
                    closeFedChance = MAXIMUM_CLOSE_FED_CHANCE;
                if (newFedChance < MININUM_NEW_FED_CHANCE)
                    newFedChance = MININUM_NEW_FED_CHANCE; // Always have at least SOME chance to create a new fed.

                sb.Append("----------" + InterpretMonth(startingMonthID + i) + "----------" + Environment.NewLine);
                sb.Append("Closing Chance: " + closeFedChance.ToString("P3") + Environment.NewLine);
                sb.Append("Opening Chance: " + newFedChance.ToString("P3") + Environment.NewLine);

                // Step 1 : Determine the success rate of each active fed
                ft.AdvanceMonth(g, closeFedChance);

                // Step 2 : Close feds if needed.  This comes before opening so a fed won't open and close in the same month.
                double roll = g.NextDouble();
                sb.Append("Roll to close fed: " + roll.ToString("N3") + Environment.NewLine);
                if (roll < closeFedChance)
                {
                    if (ft.ActiveCount <= 0)
                        break;
                    FederationData fd = ft.CloseAFed(InterpretMonth(startingMonthID + i), g);
                    if (fd != null)
                    {
                        sb.Append(fd.FedName + " Closed after " + fd.Age + " months" + Environment.NewLine);
                    }
                }

                // Step 3: Open new feds if needed.

                roll = g.NextDouble();
                sb.Append("Roll to open fed: " + roll.ToString("N3") + Environment.NewLine);
                while (newFedChance > 1.0f || roll < newFedChance)
                {                    
                    FederationData fd = ft.GenerateNewFed(InterpretMonth(startingMonthID + i));
                    sb.Append(fd.FedName + " opened" + Environment.NewLine);
                    newFedChance -= 1.0f;
                    if (newFedChance > 0)
                    {
                        roll = g.NextDouble();
                        sb.Append("Roll to open fed: " + roll.ToString("N3") + Environment.NewLine);
                    }
                }
            }

            sb.Append( Environment.NewLine + Environment.NewLine);
            sb.Append( ft.ActiveFedStatus());
            txtResults.Text += sb.ToString();

            Clipboard.SetText(txtResults.Text);
        }

        private void btnSeedGenerate_Click(object sender, EventArgs e)
        {
            MakeSeed();
            Generate();
        }        

        private string InterpretMonth(int monthIDToInterpret)
        {
            return new DateTime((int)(monthIDToInterpret / 12), (monthIDToInterpret % 12)+1, 1).ToString("MMMM yyyy");
        }
    }
}
