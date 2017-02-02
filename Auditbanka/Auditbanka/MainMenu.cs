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
        public int ClientId = 0;
        public int DeptId = 0;
        public int EmpID = 0;
        public int DogID = 0;
        Models.Client _client;
        Models.Adress _adress;
        Models.Employee _emp;
        Models.Splata _splata;
        Models.Department _dept;
        Models.Dogovir _dogovir;
        Models.Providing _providing;

        public MainMenu()
        {
            InitializeComponent();
            tabMainForm.Visible = false;
            DepartmentTab.Visible = false;
            tabSplata.Visible = false;
            tabDogovir.Visible = false;
            HideAll.Visible = false;


        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabMainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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
            } else if (e.KeyCode == Keys.F10)
            {
                tabMainForm.Visible = true;
                DepartmentTab.Visible = true;
                tabSplata.Visible = true;
                tabDogovir.Visible = true;
                HideAll.Visible = true;
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

        private void внесенняДанихF10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabMainForm.Visible = true;
            DepartmentTab.Visible = true;
            tabSplata.Visible = true;
            tabDogovir.Visible = true;
            HideAll.Visible = true;
            _client = new Models.Client();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _client = new Models.Client();

            _client.Name = clientName.Text;
            _client.SecondName = clientSecName.Text;
            _client.SurName = clientSurName.Text;
            _client.DateOfBirth = ClientBirth.Value;
            _client.Passport = clientPassport.Text ;
            _client.PassportIssuedBy = ClientPassportIssuedBy.Text;
            _client.Position = ClientJobPosada.Text;
            _client.PlaceOfJob = ClientJobPlace.Text;
            _client.Sex = ClientMale.Text;
            _client.AmountOfIncome = Convert.ToDouble(ClientJobIncome.Text);
            _client.Experience = Convert.ToInt32(ClientjobExperiance.Text);
            _client.Telephone = ClientTelephone.Text;
            _client.Osvita = ClientEducation.Text;
            _client.Children = Convert.ToInt32(ClientChild.Text);
            _client.HasDeposit = ClientHasDeposit.Text;
            _client.Statistica = ClientHistory.Text;
            _client.Identification = Convert.ToInt32(ClientIdentification.Text);
            _client.IsMarried = ClientIsMerried.Text;
            _client.DateOfPassport = ClientDateOfPassport.Value;

            Models.BankContext db = new Models.BankContext();
            
                db.Clients.Add(_client);
                db.SaveChanges();
                this.ClientId = _client.ClientId;

                _adress = new Models.Adress();
                _adress.Country = ClientCountry.Text;
                _adress.City = ClientCity.Text;
                _adress.Region = ClientRegion.Text;
                _adress.Street = ClientStreet.Text;
                _adress.Building = Convert.ToInt32(ClientBuilding.Text);
                _adress.BuildingNumber = Convert.ToInt32(ClientBuildNumber.Text);
                _adress.Client = _client;
                db.Adresses.Add(_adress);
                db.SaveChanges();
                MessageBox.Show("Дані збережено" + "\n"+
                    "Номер клієнта:"+ this.ClientId);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некоректні дані"+
                    "\n"+
                    ex.Message+ "\n" +
                    ex.InnerException
                    );
            }
            



        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            
            try
            {
                Models.BankContext db = new Models.BankContext();
                _emp = new Models.Employee();
                _dept = new Models.Department();
                
                _dept.DepartmentName = DEPTName.Text;
                _dept.LegalAdress = DEPTADRESS.Text;
                db.Departments.Add(_dept);
                db.SaveChanges();
                this.DeptId = _dept.DepartmentId;

                _emp.Name = EmpName.Text;
                _emp.SecondName = EmpSecName.Text;
                _emp.Surname = EmpSurName.Text;
                _emp.PersonalNumber = Convert.ToInt32(EmpPersonalNumber.Text);
                _emp.Position = LabelPos.Text;
                _emp.DepartmentId = this.DeptId;
                db.Employees.Add(_emp);
                db.SaveChanges();

                this.EmpID = _emp.EmployeeId;

                MessageBox.Show("Дані збережено" + "\n" +
                    "Номер клієнта:" + this.EmpID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некоректні дані" +
                    "\n" +
                    ex.Message + "\n" +
                    ex.InnerException
                    );
            }
        }

        private void buttonSplata_Click(object sender, EventArgs e)
        {
            try
            {
                Models.BankContext db = new Models.BankContext();
                _splata = new Models.Splata();
             
                _splata.SumOfSplata = Convert.ToDouble(SplataSum.Text);               
                _splata.ClientId = Convert.ToInt32(SplataClientNumber.Text);
                _splata.DateOfSplata = SplataDate.Value;

                Models.Splata _lastSplata = db.Splata.Where(x=> x.ClientId == _splata.ClientId).OrderByDescending(c=>c.NumberOfSplata).FirstOrDefault();
                _splata.NumberOfSplata = _lastSplata.NumberOfSplata + 1;
                _splata.TotalSplata = _lastSplata.TotalSplata + _splata.SumOfSplata;

                db.Splata.Add(_splata);
                db.SaveChanges();




                MessageBox.Show("Дані збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некоректні дані" +
                    "\n" +
                    ex.Message + "\n" +
                    ex.InnerException
                    );
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                Models.BankContext db = new Models.BankContext();
                _dogovir = new Models.Dogovir();
                _providing = new Models.Providing();

                _dogovir.EmployeeId = Convert.ToInt32(DogEmp.Text);
                _dogovir.ClientId = Convert.ToInt32(DogClient.Text);
                _dogovir.Currency = DogCurrency.Text;
                _dogovir.AmountOfCredit = Convert.ToDouble(DogAmount.Text);
                _dogovir.IsPayed = false;
                _dogovir.Rate = Convert.ToDouble(DogRate.Text);
                _dogovir.Target = DogTarget.Text;
                _dogovir.Termin = Convert.ToInt32(DOGXurrency.Text);
                _dogovir.TypeOfCredit = DogType.Text;
                _dogovir.DateOfGetting = DogDate.Value;

                db.Dogovirs.Add(_dogovir);
                db.SaveChanges();

                this.DogID = _dogovir.DogovirId;

                _providing.DogovirId = this.DogID;
                _providing.Total = Convert.ToDouble(ProvSum.Text);
                _providing.TypeOfProviding = ProvType.Text;

                db.Providings.Add(_providing);
                db.SaveChanges();


                MessageBox.Show("Дані збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некоректні дані" +
                    "\n" +
                    ex.Message + "\n" +
                    ex.InnerException
                    );
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabMainForm.Visible = false;
            DepartmentTab.Visible = false;
            tabSplata.Visible = false;
            tabDogovir.Visible = false;
            HideAll.Visible = false;
        }
    }
}
