using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditbanka
{
    public partial class AllStatistOfAuditForm : Form
    {
        public AllStatistOfAuditForm()
        {
            InitializeComponent();
            SetInfo();

        }

        private void SetInfo()
        {
            dtpNow.Text = DateTime.Now.ToString();
            Models.BankContext db = new Models.BankContext();

            List<Models.Dogovir> all = db.Dogovirs.ToList();

            double totalsum = 0;
            double totalsumFin = 0;
            double totalsumNotFin = 0;

            int sumFin = 0;
            int sumNotFin = 0;

            foreach (Models.Dogovir dog in all)
            {
                totalsum += dog.AmountOfCredit;
                if (dog.IsPayed == true)
                {
                    totalsumFin += dog.AmountOfCredit;
                    sumFin++;
                }
                else
                {
                    totalsumNotFin += dog.AmountOfCredit;
                    sumNotFin++;
                }
            }

            inputCountOfCred.Text = all.Count.ToString();
            inputTotalSumOfCred.Text = totalsum.ToString();
            textFinishedForSum.Text = totalsumFin.ToString();
            textNotFinishedForSum.Text = totalsumNotFin.ToString();

            textFinished.Text = sumFin.ToString();
            textNotFinished.Text = sumNotFin.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
