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
    public partial class ConstantuForm : Form
    {
        public delegate void ChangeGlobal(int _rate, int age);
        public int GRate = 9;
        public int GZab = 25;
        public int GAge = 21;

        public ConstantuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreditInfo _credit = new CreditInfo();
            ChangeGlobal del = new ChangeGlobal(_credit.ChangeConst);
            this.GAge = Convert.ToInt32( textBox3.Text );
            this.GRate = Convert.ToInt32(textBox1.Text);
            this.GZab = Convert.ToInt32(textBox2.Text);


            del(GRate, GAge);
            textBox3.Text = GAge.ToString();
            textBox1.Text = GRate.ToString();
            textBox2.Text = GZab.ToString();


            MessageBox.Show("Успішно оновлено", "Константи");


            
        }

    }
}
