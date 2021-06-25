using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditValue
{
    public partial class Form1 : Form
    {
        double creditValue;
        double days;
        string percent;
        double diff = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void create_b_Click(object sender, EventArgs e)
        {
            string[] daysAndProcent;

            daysAndProcent = TB_ppd.Text.Split(' ');
            int creditValue = Convert.ToInt32(TB_credit.Text);
            double[] procentOnDay = new double[Convert.ToInt32(TB_days.Text)];

            for (int i = 0; i < procentOnDay.Length; i++)
            {
                procentOnDay[i] = Convert.ToDouble(TB_percent.Text);
            }

            if (TB_amount_result.Text != "")
            {
                for (int i = 0; i < daysAndProcent.Length; i++)
                {
                    string[] SplitDateAndProcent = daysAndProcent[i].Split(' ');
                    procentOnDay[Convert.ToInt32(SplitDateAndProcent[0]) - 1] = Convert.ToDouble(SplitDateAndProcent[1]);
                }
            }
            for (int i = 0; i < procentOnDay.Length; i++)
            {
                diff = diff + creditValue / 100 * procentOnDay[i];
            }

            double sumProcent = 0;
            for (int i = 0; i < procentOnDay.Length; i++)
            {
                sumProcent += procentOnDay[i];
            }

            double res = creditValue + diff;
            double eff = res / creditValue / days;
            TB_amount_result.Text = Convert.ToString(res);
            TB_effValue.Text = Convert.ToString(eff);
            TB_ppd.Text = Convert.ToString(diff);
        }
    }
}
