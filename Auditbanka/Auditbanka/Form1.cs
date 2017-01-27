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
    public partial class Form1 : Form
    {
        public bool IsAuthorised = false;
        public Form1()
        {
            InitializeComponent();
            BankContext db = new BankContext();
            var users = db.Users.ToList();
            
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            if (inputPassword.Text == "" || inputName.Text == "")
            {
                MessageBox.Show("Поля повинні бути заповнені!!!");
                return;
            }

            this.IsAuthorised =  CheckIfUserExist(inputName.Text, inputPassword.Text);

            if (!IsAuthorised)
            {
                MessageBox.Show("Введено невірні дані!!!");
            }
            else
            {
                this.Hide();
                Form2 ListOfCredits = new Form2();
                ListOfCredits.Show();
            }
        }


        public bool CheckIfUserExist(string name, string password)
        {
            using (BankContext db=  new BankContext())
            {
                List<User> user = db.Users.Where(x => x.Name.ToUpper() == name.ToUpper()).ToList();
                List<User> userPerPassword = user.Where(z => z.Password == password).ToList();

                if (userPerPassword.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                    
            }
               
        }



    }
}
