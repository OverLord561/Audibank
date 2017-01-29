using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditbanka.Models
{
    public partial class Form2 : Form
    {
        public string TypeOfCredit;
        public string Valuta;
        public string TermOfCredit;
        public string SumOfCredit;
        public int DogovirNumber;
        public DateTime StartDate;
        public DateTime EndDate;
        List<Models.Dogovir> dogovirs;
        BankContext db = new BankContext();

        public Form2()
        {
           
            InitializeComponent();
            //dtpStartDate.Format = DateTimePickerFormat.Custom;
            //dtpStartDate.CustomFormat = " ";
          

            //dtpEndDate.Format = DateTimePickerFormat.Custom;
            //dtpEndDate.CustomFormat = " ";
            this.dogovirs = db.Dogovirs.ToList();

            dataGridView1.DataSource = dogovirs;

            dataGridView1.Columns["EmployeeId"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
            dataGridView1.Columns["Client"].Visible = false;
            dataGridView1.Columns["ClientId"].Visible = false;
           dataGridView1.Columns["Target"].Visible = false;
            dataGridView1.Columns["Termin"].HeaderText = "Термін";
            dataGridView1.Columns["DogovirId"].HeaderText = "Номер";
            dataGridView1.Columns["TypeOfCredit"].HeaderText = "Вид кредиту";
            dataGridView1.Columns["AmountOfCredit"].HeaderText = "Сума кредиту";
            dataGridView1.Columns["Currency"].HeaderText = "Валюта";
            dataGridView1.Columns["Rate"].HeaderText = "Відсоток";
            dataGridView1.Columns["DateOfGetting"].HeaderText = "Дата видачі";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboValuta.SelectedItem.ToString();
            this.Valuta = selectedState;
          

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboTypeOfCredit.SelectedItem.ToString();

            this.TypeOfCredit = selectedState;
           
            var button = this.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string selectedState = radioButton3.Text;
            this.TermOfCredit = selectedState;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string selectedState = radioButton2.Text;
            this.TermOfCredit = selectedState;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string selectedState = radioButton1.Text;
            this.TermOfCredit = selectedState;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string selectedState = radioButton6.Text;
            this.SumOfCredit = selectedState;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string selectedState = radioButton5.Text;
            this.SumOfCredit = selectedState;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string selectedState = radioButton4.Text;
            this.SumOfCredit = selectedState;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            if (TypeOfCredit == null && Valuta == null &&
                TermOfCredit == null && SumOfCredit == null &&
                DogovirNumber == 0 && StartDate == DateTime.MinValue && EndDate == DateTime.MinValue)
            {
                MessageBox.Show("Введіть умову для пошуку!!!");
            }

            else
            {
                //виконується функція пошуку кредитних договорів
               dataGridView1.DataSource =  SerchDogovir();
            }

    }

        private void inputDogovirNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DogovirNumber = Convert.ToInt32(inputDogovirNumber.Text);
            }
            catch
            {
                 MessageBox.Show("Номер кредиту повинен бути числового формату!!!");
            }

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.StartDate  = dtpStartDate.Value;        
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.EndDate  = dtpEndDate.Value;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //
               

                int rowIndex = e.RowIndex;
                int celIndex = e.ColumnIndex;

                ContextMenu menuItem1 = new ContextMenu();
                menuItem1.MenuItems.Add(new MenuItem("Аналізувати кредит ->"));
               

                if (rowIndex < 0)
                {
                    return;
                }

                int row = e.RowIndex;
                int cel = e.ColumnIndex;

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).ColumnIndex;

               // menuItem1.MenuItems.Click += new System.EventHandler(this.menuItem1_Click);

                menuItem1.Show(dataGridView1, new Point(e.X, e.Y));

                CreditInfo _creditInfo = new CreditInfo(this.dogovirs[rowIndex]);
                _creditInfo.Show();
            }
        }

        public List<Dogovir> SerchDogovir()
        {
      

            int terminMIN = 0;
            int terminMAX = 0;
            int credMAX = 0;
            int credMIN = 0;
            try
            {
                switch (TermOfCredit)
                {
                    case "Короткострокові": terminMAX = 10; terminMIN = 0; break;
                    case "Середньострокові": terminMAX = 20; terminMIN = 10; break;
                    case "Довгострокові": terminMAX = 100; terminMIN = 20; break;
                    default: break;
                }
            }
            catch
            {
                this.TermOfCredit = null;
            }

            try
            {
                switch (SumOfCredit)
                {
                    case "Малі кредити": credMAX = 30000; credMIN = 0; break;
                    case "Середні кредити": credMAX = 100000; credMIN = 30000; break;
                    case "Великі кредити": credMAX = 10000000; credMIN = 100000; break;
                    default: break;
                }
            }
            catch
            {
                this.SumOfCredit = null;
            }
            

            var Dogovirs = db.Dogovirs.ToList();
            var _Type = TypeOfCredit != null ? Dogovirs.Where(x => x.TypeOfCredit.ToUpper() == this.TypeOfCredit.ToUpper()):Dogovirs;
            var _TermMIN = TermOfCredit != null ? Dogovirs.Where(x => x.Termin > terminMIN):Dogovirs;
            var _TermMAX = TermOfCredit != null ? Dogovirs.Where(x => x.Termin <= terminMAX) : Dogovirs;
            var _Valuta = Valuta !=null? Dogovirs.Where(x => x.Currency == Valuta) : Dogovirs;
            var _credMIN = SumOfCredit != null ? Dogovirs.Where(x => x.AmountOfCredit > credMIN) : Dogovirs;
            var _credMAX = SumOfCredit != null ? Dogovirs.Where(x => x.AmountOfCredit <= credMAX) : Dogovirs;
            var _Number = DogovirNumber !=0? Dogovirs.Where(x => x.DogovirId == DogovirNumber) : Dogovirs;
            var _Start = StartDate != DateTime.MinValue ? Dogovirs.Where(x => x.DateOfGetting >= StartDate) : Dogovirs;
            var _End = EndDate != DateTime.MinValue ? Dogovirs.Where(x => x.DateOfGetting <= EndDate) : Dogovirs;

            var All = _Type.Intersect(_TermMIN).Intersect(_TermMAX).Intersect(_Valuta).Intersect(_credMAX).Intersect(_credMIN).Intersect(_Number)
                .Intersect(_Start).Intersect(_End);

            return All.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConstantuForm d = new ConstantuForm();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllStatistOfAuditForm аа = new AllStatistOfAuditForm();
            аа.Show();
        }
    }


    
}
