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
    public partial class Form2 : Form
    {
        public string TypeOfCredit;
        public string Valuta;
        public string TermOfCredit;
        public string SumOfCredit;
        public int DogovirNumber;
        public DateTime StartDate;
        public DateTime EndDate;
        BankContext db = new BankContext();

        public Form2()
        {
           
            InitializeComponent();
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = " ";

            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = " ";

            dataGridView1.DataSource = db.Users.ToList();
          
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboValuta.SelectedItem.ToString();
            this.Valuta = selectedState;
           // MessageBox.Show(selectedState);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboTypeOfCredit.SelectedItem.ToString();

            this.TypeOfCredit = selectedState;
            // MessageBox.Show(selectedState);
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

        private void dataGridView1_CellMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Аналізувати кредит ->"));
                m.MenuItems.Add(new MenuItem("Copy"));

                

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                //if (currentMouseOverRow >= 0)
                //{

                //    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                //}

                m.Show(dataGridView1, new Point(e.X, e.Y));

            }
        }
    }


    
}
