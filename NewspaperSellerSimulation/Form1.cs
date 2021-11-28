using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;
using System.IO;


namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        public string[] lines = File.ReadAllLines(@"TestCase1.txt");
        public Generate gen = new Generate();
        public SimulationSystem SimSys = new SimulationSystem();
        public SimulationCase sc = new SimulationCase();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "NumOfNewspapers")
                {
                    textBox1.Text = lines[i + 1];
                    SimSys.NumOfNewspapers = int.Parse(lines[i + 1]);
                }
                else if (lines[i] == "NumOfRecords")
                {
                    textBox2.Text = lines[i + 1];
                    SimSys.NumOfRecords = int.Parse(lines[i + 1]);
                }
                else if (lines[i] == "PurchasePrice")
                {
                    textBox3.Text = lines[i + 1];
                    SimSys.PurchasePrice = decimal.Parse(lines[i + 1]);
                }
                else if (lines[i] == "SellingPrice")
                {
                    textBox4.Text = lines[i + 1];
                    SimSys.SellingPrice = decimal.Parse(lines[i + 1]);
                }
                else if (lines[i] == "ScrapPrice")
                {
                    textBox5.Text = lines[i + 1];
                    SimSys.ScrapPrice = decimal.Parse(lines[i + 1]);
                }
                else if (lines[i] == "DayTypeDistributions")
                {
                    i++;
                    int TypeCount = 0;
                    string[] DayTypeDistFile = lines[i].Split(',', (char)StringSplitOptions.RemoveEmptyEntries);
                    DayTypeDistribution DT;
                    while (TypeCount != 3)
                    {
                        DT = new DayTypeDistribution();
                        DT.Probability = decimal.Parse(DayTypeDistFile[TypeCount]);
                        if (TypeCount == 0)
                        {

                            DT.CummProbability = DT.Probability;
                            DT.MaxRange = Decimal.ToInt32(DT.Probability * 100);
                            DT.MinRange = 1;
                            DT.DayType = Enums.DayType.Good;
                        }
                        if (TypeCount == 1)
                        {
                            DT.CummProbability = DT.Probability + SimSys.DayTypeDistributions[0].Probability;
                            DT.MinRange = SimSys.DayTypeDistributions[0].MaxRange + 1;
                            DT.MaxRange = Decimal.ToInt32(DT.CummProbability * 100);
                            DT.DayType = Enums.DayType.Fair;
                        }
                        if (TypeCount == 2)
                        {
                            DT.CummProbability = DT.Probability + SimSys.DayTypeDistributions[0].Probability + SimSys.DayTypeDistributions[1].Probability;
                            DT.MinRange = SimSys.DayTypeDistributions[1].MaxRange + 1;
                            DT.MaxRange = 100;
                            DT.DayType = Enums.DayType.Poor;
                        }
                        SimSys.DayTypeDistributions.Add(DT);
                        TypeCount++;
                    }
                }
                else if (lines[i] == "DemandDistributions")
                {
                    i++;
                    while (lines[i] != "")
                    {
                        DemandDistribution DemandDistribution = new DemandDistribution();
                        string[] DemandDistFile = lines[i].Split(',', (char)StringSplitOptions.RemoveEmptyEntries);
                        DemandDistribution.Demand = int.Parse(DemandDistFile[0]);
                        List<DayTypeDistribution> DayTypeDistribution = new List<DayTypeDistribution>();
                        DayTypeDistribution DayTypeDistSpec;
                        for (int j = 1; j <= 3; j++)
                        {
                            DayTypeDistSpec = new DayTypeDistribution();
                            DayTypeDistSpec.Probability = decimal.Parse(DemandDistFile[j]);
                            if (j == 1)
                                DayTypeDistSpec.DayType = Enums.DayType.Good;
                            else if (j == 2)
                                DayTypeDistSpec.DayType = Enums.DayType.Fair;
                            else
                                DayTypeDistSpec.DayType = Enums.DayType.Poor;
                            DayTypeDistribution.Add(DayTypeDistSpec);
                        }
                        DemandDistribution.DayTypeDistributions = DayTypeDistribution;
                        SimSys.DemandDistributions.Add(DemandDistribution);
                        i++;
                        if (i == lines.Length)
                            break;
                    }
                    for (int DemCounter = 0; DemCounter < SimSys.DemandDistributions.Count; DemCounter++)
                    {
                        for (int DayTypeCounter = 0; DayTypeCounter < 3; DayTypeCounter++)
                        {
                            decimal ProbTemp;
                            if (DemCounter == 0)
                            {
                                SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].CummProbability = SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].Probability;
                                SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].MinRange = 0;
                                ProbTemp = SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].CummProbability * 100;
                                SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].MaxRange = (int)ProbTemp;
                            }
                            else
                            {
                                ProbTemp = SimSys.DemandDistributions[DemCounter - 1].DayTypeDistributions[DayTypeCounter].CummProbability * 100;
                                SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].MinRange = (int)ProbTemp + 1;
                                SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].CummProbability = SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].Probability + SimSys.DemandDistributions[DemCounter - 1].DayTypeDistributions[DayTypeCounter].CummProbability;
                                ProbTemp = SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].CummProbability * 100;
                                SimSys.DemandDistributions[DemCounter].DayTypeDistributions[DayTypeCounter].MaxRange = (int)ProbTemp;
                            }
                        }
                    }
                }
            }
            for (int Record = 0; Record < SimSys.NumOfRecords; Record++)
            {
                int RandomDayType = gen.generate_rand(), DayType = -1, DemTemp = -1;
                System.Threading.Thread.Sleep(50);
                int RandomDemand = gen.generate_rand();
                if (RandomDayType <= SimSys.DayTypeDistributions[0].MaxRange)
                    DayType = 0;
                else if (RandomDayType <= SimSys.DayTypeDistributions[1].MaxRange)
                    DayType = 1;
                else if (RandomDayType <= SimSys.DayTypeDistributions[2].MaxRange)
                    DayType = 2;
                for (int i = 0; i < SimSys.DemandDistributions.Count; i++)
                {
                    int min = SimSys.DemandDistributions[i].DayTypeDistributions[DayType].MinRange, max = SimSys.DemandDistributions[i].DayTypeDistributions[DayType].MaxRange;
                    if (RandomDemand >= min && RandomDemand <= max)
                        DemTemp = SimSys.DemandDistributions[i].Demand;
                }
                sc = new SimulationCase();
                sc.SalesProfit = sales_revnue(DemTemp);
                sc.LostProfit = lost_profit(DemTemp);
                sc.ScrapProfit = scrap_profit(DemTemp);
                sc.DailyNetProfit = total_profit(DemTemp);
                sc.DayNo = Record + 1;
                sc.RandomNewsDayType = RandomDayType;
                sc.RandomDemand = RandomDemand;
                sc.Demand = DemTemp;
                if (DayType == 0)
                    sc.NewsDayType = Enums.DayType.Good;
                if (DayType == 1)
                    sc.NewsDayType = Enums.DayType.Fair;
                if (DayType == 2)
                    sc.NewsDayType = Enums.DayType.Poor;
                SimSys.SimulationTable.Add(sc);
                System.Threading.Thread.Sleep(50);
            }
        }
        decimal sales_revnue(int demand)
        {
            decimal SalesProfit = 0;
            if (SimSys.NumOfNewspapers > demand)
                return SalesProfit = demand * SimSys.SellingPrice;
            return SalesProfit = SimSys.NumOfNewspapers * SimSys.SellingPrice;
        }
        decimal Cost_Newspapers(int demand)
        {
            return sc.DailyCost = SimSys.NumOfNewspapers * SimSys.PurchasePrice;
        }
        decimal lost_profit(int demand)
        {
            if (demand > SimSys.NumOfNewspapers)
                return (sc.LostProfit = ((demand* SimSys.SellingPrice) - (demand * SimSys.PurchasePrice)) - ((SimSys.NumOfNewspapers*SimSys.SellingPrice) - (SimSys.NumOfNewspapers*SimSys.PurchasePrice)));
            return 0;
        }
        decimal scrap_profit(int demand)
        {
            if (demand < SimSys.NumOfNewspapers)
                return sc.ScrapProfit = (SimSys.NumOfNewspapers - demand) * SimSys.ScrapPrice;
            return 0;
        }
        decimal total_profit(int demand)
        {
            return sc.DailyNetProfit = sales_revnue(demand) - Cost_Newspapers(demand) - lost_profit(demand) + scrap_profit(demand);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            SimSys.PerformanceMeasures.TotalSalesProfit = 0;
            SimSys.PerformanceMeasures.TotalCost = 0;
            SimSys.PerformanceMeasures.TotalLostProfit = 0;
            SimSys.PerformanceMeasures.TotalScrapProfit = 0;
            SimSys.PerformanceMeasures.TotalNetProfit = 0;
            SimSys.PerformanceMeasures.DaysWithMoreDemand = 0;
            SimSys.PerformanceMeasures.DaysWithUnsoldPapers = 0;
            for (int i = 0; i < SimSys.SimulationTable.Count; i++)
            {
                dataGridView1.Rows.Add(SimSys.SimulationTable[i].DayNo, SimSys.SimulationTable[i].NewsDayType,
                   SimSys.SimulationTable[i].RandomNewsDayType, SimSys.SimulationTable[i].RandomDemand,
                   SimSys.SimulationTable[i].Demand,SimSys.SimulationTable[i].DailyCost, SimSys.SimulationTable[i].SalesProfit, SimSys.SimulationTable[i].LostProfit,
                   SimSys.SimulationTable[i].ScrapProfit, SimSys.SimulationTable[i].DailyNetProfit);
                System.Threading.Thread.Sleep(50);
                SimSys.PerformanceMeasures.TotalSalesProfit += SimSys.SimulationTable[i].SalesProfit;
                SimSys.PerformanceMeasures.TotalCost += SimSys.SimulationTable[i].DailyCost;
                SimSys.PerformanceMeasures.TotalLostProfit += SimSys.SimulationTable[i].LostProfit;
                SimSys.PerformanceMeasures.TotalScrapProfit += SimSys.SimulationTable[i].ScrapProfit;
                SimSys.PerformanceMeasures.TotalNetProfit += SimSys.SimulationTable[i].DailyNetProfit;
                if (SimSys.SimulationTable[i].Demand > SimSys.NumOfNewspapers)
                    SimSys.PerformanceMeasures.DaysWithMoreDemand++;
                if (SimSys.SimulationTable[i].Demand < SimSys.NumOfNewspapers)
                    SimSys.PerformanceMeasures.DaysWithUnsoldPapers++;
            }
            string TSP = "Total Sales Profit: " + SimSys.PerformanceMeasures.TotalSalesProfit.ToString() + "\n";
            string TC = "Total Cost: " + SimSys.PerformanceMeasures.TotalCost.ToString() + "\n";
            string TLP = "Total Lost Profit: " + SimSys.PerformanceMeasures.TotalLostProfit.ToString() + "\n";
            string TSCP = "Total Scrap Profit: " + SimSys.PerformanceMeasures.TotalScrapProfit.ToString() + "\n";
            string TNP = "Total Net Profit: " + SimSys.PerformanceMeasures.TotalNetProfit.ToString() + "\n";
            MessageBox.Show(TSP + TC + TLP + TSCP + TNP);
            string testingResult = TestingManager.Test(SimSys, Constants.FileNames.TestCase1);
            MessageBox.Show(testingResult);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}