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
        public Form1()
        {
            InitializeComponent();
        }

        int randomSeed;
        Random generator;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHistoryMonthStart.SelectedIndex = 0;
            cmbHistoryMonthEnd.SelectedIndex = 11;
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

            int monthStart = ((int)numHistoryYearStart.Value * 12) + cmbHistoryMonthStart.SelectedIndex + 1;
            int monthEnd = ((int)numHistoryYearEnd.Value * 12) + cmbHistoryMonthEnd.SelectedIndex + 1;
            int dbDate = ((int)numGameStartYear.Value * 12) + cmbGameStartMonth.SelectedIndex + 1;

            int actualStart = generator.Next(monthStart, monthEnd + 1);
            int numberOfMonthsToGenerate = dbDate - actualStart;
            txtResults.Text = txtResults.Text + "Generating " + numberOfMonthsToGenerate + " months, starting with ";
            /*int diff = actualStart - monthStart;
            int monthSelect = diff % 12;
            int yearSelect = (int)(diff / 12);
            txtResults.Text = txtResults.Text + cmbHistoryMonthStart.Items[monthSelect] + " " + ((int)numHistoryYearStart.Value + yearSelect);*/
            txtResults.Text = txtResults.Text + InterpretMonth(monthStart, actualStart);
            GenerateFederationHistory(numberOfMonthsToGenerate, (int)numFinalSupportedFeds.Value ,generator);
        }

        private void GenerateFederationHistory(int monthsToGen, int finalSupportedFeds, Random g)
        {
            //throw new NotImplementedException();
        }

        private void btnSeedGenerate_Click(object sender, EventArgs e)
        {
            MakeSeed();
            Generate();
        }

        

        private string InterpretMonth(int startMonth, int monthToInterpret)
        {
            int diff = monthToInterpret - startMonth;
            int monthSelect = (diff % 12) + 1; // +1 to make 1 to 12 instead of 0 to 11
            int yearSelect = (int)(diff / 12);
            return (new DateTime(1, monthSelect, 1).ToString("MMMM") + " " + (int)(monthToInterpret/12));
        }
    }
}
