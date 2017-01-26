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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BankContext db = new BankContext();
            var users = db.Users.ToList();
            Form2 ff = new Form2();
            ff.Show();
        }

        

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    BankContext db = new BankContext();
        //    var users =  db.Users.ToList();

        //    User user = new User { Name = "Roman", SecondName = "Kisera" };

        //    db.Users.Add(user);
        //    db.SaveChanges();
        //}


    }
}
