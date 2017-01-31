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
            // initial DB create
            BankContext db = new BankContext();
            var users = db.Users.ToList();
            try
            {
                User custom = db.Users.FirstOrDefault(x=>x.Name=="23");
                db.Users.Remove(custom);
                db.SaveChanges();
                throw new Exception();
            }
            catch(Exception ex)
            {
                User initialUser = new User { Name = "23", Password = "23", SecondName = "23" };
                db.Users.Add(initialUser);
                db.SaveChanges();
                return;
            }
            
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
                
                MainMenu mainForm = new MainMenu();
                mainForm.Show();
               
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
