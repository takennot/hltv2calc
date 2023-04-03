using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLTV2._0
{
    public partial class Form1 : Form
    {
        public int scoreCT = 0;
        public int scoreT = 0;
        public int rounds = 0;
        public int kills = 0;
        public int deaths = 0;
        public int assist = 0;
        public double APR_int = 0;
        public double KPR_int = 0;
        public double DPR_int = 0;
        public double Impact_int = 0;
        public double KAST_int = 0;
        public double ADR_int = 0;
        public double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            string url = "https://csgostats.gg";
            System.Diagnostics.Process.Start(url);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void var_calc_Click(object sender, EventArgs e)
        {
            // Passed debug
            scoreCT = int.Parse(score1.Text);
            scoreT = int.Parse(score2.Text);
            rounds = scoreT + scoreCT;
            // Passed debug
            kills = int.Parse(kills_tbx.Text);
            deaths = int.Parse(death_tbx.Text);
            assist = int.Parse(ass_tbx.Text);
            //Passed debug
            APR_int = (double)assist / rounds;
            KPR_int = (double)kills / rounds;
            KPR.Text = KPR_int.ToString();
            DPR_int = (double)deaths / rounds;
            DPR.Text = DPR_int.ToString();

            double impvar1 = 2.13 * KPR_int;
            double impvar2 = 0.42 * APR_int;
            Impact_int = impvar1 + impvar2 - 0.41;
            Impact.Text = Impact_int.ToString();
        }

        public void rating_calculate_Click(object sender, EventArgs e)
        {
            KAST_int = double.Parse(KAST.Text);
            ADR_int = double.Parse(ADR.Text);
            double resvar1 = 0.0073 * KAST_int;
            double resvar2 = 0.3591 * KPR_int;
            double resvar3 = 0.5329 * (-1) * DPR_int;
            double resvar4 = 0.2372 * Impact_int;
            double resvar5 = 0.0032 * ADR_int;
            result = resvar1 + resvar2 + resvar3 + resvar4 + resvar5 + 0.1587;
            rating.Text = Math.Round((double)result, 2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = score1;
        }

        private void srclink_Click(object sender, EventArgs e)
        {
            string url = "https://flashed.gg/posts/reverse-engineering-hltv-rating/";
            System.Diagnostics.Process.Start(url);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void roundslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
