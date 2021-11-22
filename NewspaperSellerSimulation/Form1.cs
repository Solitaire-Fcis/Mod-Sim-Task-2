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

        string[] lines = File.ReadAllLines(@"TestCase1.txt");

        public Form1()
        {
            InitializeComponent();

            //Reading From file and assign to classes
            for (int i=0; i < lines.Length; i++)
            {
                if (lines[i] == "NumOfNewspapers")
                {
                    textBox1.Text = lines[i + 1];
                }
                if (lines[i] == "NumOfRecords")
                {
                    textBox2.Text = lines[i + 1];
                }
                if (lines[i] == "PurchasePrice")
                {
                    textBox3.Text = lines[i + 1];
                }
                if (lines[i] == "ScrapPrice")
                {
                    textBox4.Text = lines[i + 1];
                }
                if (lines[i] == "SellingPrice")
                {
                    textBox5.Text = lines[i + 1];
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();

            DataGridView table = new DataGridView();

            table.ColumnCount = 9;

            table.Columns[0].Name = "Day";
            table.Columns[0].Width = 50;


            table.Columns[1].Name = "Random Digits for Type of Newsday";
            table.Columns[1].Width = 190;

            table.Columns[2].Name = "Type of Newsday";

            table.Columns[3].Name = "Random Digits for Demand";
            table.Columns[3].Width = 140;

            table.Columns[4].Name = "Demand";
            table.Columns[4].Width = 50;

            table.Columns[5].Name = "Revenue from Sales";
            table.Columns[5].Width = 120;


            table.Columns[6].Name = "Lost Profit from Excess Demand";
            table.Columns[6].Width = 170;

            table.Columns[7].Name = "Salvage from Sale of Scrap";
            table.Columns[7].Width = 150;

            table.Columns[8].Name = "Daily Profit";

            table.Width = 1115;
            table.Height = 700;

            form.Controls.Add(table);

            form.Text = "Simulation";
            form.AutoSize = true;

            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
