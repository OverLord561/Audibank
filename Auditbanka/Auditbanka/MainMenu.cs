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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemConstantu_Click(object sender, EventArgs e)
        {
            ConstantuForm _constForm = new ConstantuForm();
            _constForm.Show();
        }

        private void MenuItemStatist_Click(object sender, EventArgs e)
        {
            AllStatistOfAuditForm _statist = new AllStatistOfAuditForm();
            _statist.Show();
        }

        private void MenuItemJournal_Click(object sender, EventArgs e)
        {           
        
            AuditForm _audit = new AuditForm();
            _audit.Show();        
    }

        private void MenuItemAboutProgram_Click(object sender, EventArgs e)
        {
            AboutForm _about = new AboutForm();
            _about.Show();
        }

        private void MenuItemAnalysOfCredits_Click(object sender, EventArgs e)
        {
            Models.Form2 _dogovirs = new Models.Form2();
            _dogovirs.Show();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                AboutForm _about = new AboutForm();
                _about.Show();
            }
            else if (e.KeyCode == Keys.F2)
            {
                Models.Form2 _dogovirs = new Models.Form2();
                _dogovirs.Show();
            }
            else if (e.KeyCode == Keys.F3)
            {
                AuditForm _audit = new AuditForm();
                _audit.Show();
            }
            else if (e.KeyCode == Keys.F4)
            {
                AllStatistOfAuditForm _statist = new AllStatistOfAuditForm();
                _statist.Show();
            }
            else if (e.KeyCode == Keys.F5)
            {
                ConstantuForm _constForm = new ConstantuForm();
                _constForm.Show();
            }
            else
            {
                return;
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int dogovirId = 0;
            try
            {
                dogovirId = Convert.ToInt32(inputMainSearch.Text);
            }
            catch
            {
                MessageBox.Show("Номер договору повинен містити тільки цифри", "Договір не існує");
                return;
            }
            
            Models.Dogovir _dogovir;
            using (Models.BankContext db = new Models.BankContext())
            {
                  _dogovir = db.Dogovirs.FirstOrDefault(x => x.DogovirId == dogovirId);
                var dd = db.Dogovirs.ToList();
            }
            if (_dogovir == null)
            {
                MessageBox.Show("По кредитному договору № " + dogovirId + " дані відсутні", "Договір не існує");
            }
            else
            {
                CreditInfo _credit = new CreditInfo(_dogovir);
                _credit.Show();
            }
                
        }
    }
}
