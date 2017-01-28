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
    public partial class CreditInfo : Form
    {
        public Models.Dogovir dogovir;
        public int Expiriance;
        public string Position;
        public string Osvita;
        public string IsMerried;
        public int Children;
        public string HasDeposit ;
        public string Statistica;
        public double Rate;
        public double SumBaliv;
        public CreditInfo(Models.Dogovir dogovir)
        {
            this.dogovir = dogovir;
            InitializeComponent();
            SetGeneralInfo(GetGeneralinfo(dogovir.ClientId));
        }

        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            // тут отримуємо номе таба, що відкритий
            int pageNumber = tabControl1.SelectedIndex;

            switch (pageNumber)
            {
                case 0: SetGeneralInfo(GetGeneralinfo(dogovir.ClientId));break;
                case 1: SetAdressInfo(GetAdressInfo(dogovir.ClientId));break;
                case 2: SetDogovirInfo(GetDogovirInfo(dogovir.ClientId)); break;
                case 3: SetProvidingInfo(GetProvidingInfo(dogovir.ClientId)); break;
                case 4: SetStatusgInfo(); break;

                default: break;
            }


          
        }

        private void SetStatusgInfo()
        {
        
            textSingle.Text = this.IsMerried;
            textHasDeposit.Text = this.HasDeposit;
            textHistory.Text = this.Statistica;
            textChild.Text = this.Children.ToString();
            textEducation.Text = this.Osvita;


        }

        private Models.Providing GetProvidingInfo(int clientId)
        {
            Models.Providing providing = new Models.Providing();
            using (Models.BankContext db = new Models.BankContext())
            {

                providing = db.Providings.FirstOrDefault(x => x.DogovirId == this.dogovir.DogovirId);
                providing.Dogovir = this.dogovir;
                providing.Dogovir.Client = db.Clients.FirstOrDefault(x => x.ClientId == clientId);
            }
                return providing;
        }

        private void SetProvidingInfo(Models.Providing _providing)
        {
            double rate = 0.0;
            rate = Math.Ceiling((_providing.Dogovir.Client.AmountOfIncome / (_providing.Dogovir.AmountOfCredit/ _providing.Dogovir.Termin))*100);
            this.Rate = rate;


            textTypeOfProviding.Text = _providing.TypeOfProviding;
            textProvAmountOfCred.Text = _providing.Dogovir.AmountOfCredit.ToString();
            textZarplata.Text = _providing.Dogovir.Client.AmountOfIncome.ToString();
           




        }

        private Models.Dogovir GetDogovirInfo(int clientId)
        {
            Models.Dogovir _dogovir = this.dogovir;
            using (Models.BankContext db = new Models.BankContext())
            {
                _dogovir.Employee = db.Employees.FirstOrDefault(x => x.EmployeeId == _dogovir.EmployeeId);
                _dogovir.Employee.Department = db.Departments.FirstOrDefault(x => x.DepartmentId == _dogovir.Employee.DepartmentId);
            }
                return this.dogovir;
        }

        private void SetDogovirInfo(Models.Dogovir _dogovir)
        {
            
            textType.Text = _dogovir.TypeOfCredit;
            textAmountOfCred.Text = _dogovir.AmountOfCredit.ToString();
            textVidsotok.Text = _dogovir.Rate.ToString();
            textData.Text = _dogovir.DateOfGetting.ToString();
            textTermin.Text = _dogovir.Termin.ToString();
            textMeta.Text = _dogovir.Target;
            textCurrency.Text = _dogovir.Currency;

            // інф про працвника
            textEmpName.Text = _dogovir.Employee.Name;
            textEmpSurName.Text = _dogovir.Employee.Surname;
            textУEmpSecName.Text = _dogovir.Employee.SecondName;
            textEmpTel.Text = _dogovir.Employee.PersonalNumber.ToString();
            textEmpDepartament.Text = _dogovir.Employee.Department.DepartmentName;
            
        }

        public Models.Client GetGeneralinfo(int clientId)
        {
            Models.Client info = new Models.Client();
            using (Models.BankContext db = new Models.BankContext())
            {
                info = db.Clients.FirstOrDefault(x => x.ClientId == clientId);

                this.Expiriance = info.Experience;
                this.Osvita = info.Osvita;
                this.IsMerried = info.IsMarried;
                this.Children = info.Children;
                this.HasDeposit = info.HasDeposit;
                this.Statistica = info.Statistica;
            }
                
            return info;
        }


        public void SetGeneralInfo(Models.Client info)
        {
            textAge.Text = (DateTime.Now.Year- info.DateOfBirth.Year).ToString();
            textBirth.Text = info.DateOfBirth.ToString();
            textCode.Text = info.Identification.ToString();
            textIssuedBy.Text = info.PassportIssuedBy;
            textMale.Text = info.Sex;
            textName.Text = info.Name;
            textSecName.Text = info.SecondName;
            textSeriaPassporta.Text = info.Passport;
            textSurName.Text = info.SurName;
        }
        public void SetAdressInfo( Models.Adress adress)
        {
           
            textCountry.Text = adress.Country;
            textRegion.Text = adress.Region;
            textCity.Text = adress.City;
            textBBuilding.Text = adress.Building.ToString();
            textStreet.Text = adress.Street;
            textBuildNumber.Text = adress.BuildingNumber.ToString();
            textMobile.Text = adress.Client.Telephone;

        }

        public Models.Adress GetAdressInfo( int clientId)
        {
            Models.Adress adress = new Models.Adress();
            using (Models.BankContext db = new Models.BankContext())
            {
                
                adress = db.Adresses.FirstOrDefault(x => x.Client.ClientId == clientId);
                adress.Client = db.Clients.FirstOrDefault(x => x.ClientId == clientId);
            }
                return adress;

        }

        public string CalculateFinanceStatus()
        {
            string status= "";

            // VIK
            double balVik = 0.0;          
            if (Convert.ToInt32(textAge.Text) >= 18 && Convert.ToInt32(textAge.Text) <= 23)
            {
                balVik = 0;
            }
            if (Convert.ToInt32(textAge.Text) > 23 && Convert.ToInt32(textAge.Text) <= 45)
            {
                balVik = 2;
            }
            else
            {
                balVik = 1;
            }

            //Stag Robotu
            double balOstStag = 0.0;
            if (this.Expiriance < 6)
            {
                balOstStag = 0;
            }
            if (this.Expiriance >= 6 && this.Expiriance <= 12)
            {
                balOstStag = 0.5;
            }
            if (this.Expiriance > 12 && this.Expiriance <= 24)
            {
                balOstStag = 1;
            }
            if (this.Expiriance > 24)
            {
                balOstStag = 2;
            }

            //Professia
            double balprof = 0.0;
            if (this.Position == "Студент")

            {
                balprof = 0;

            }
            if (this.Position == "Пенсіонер")

            {
                balprof = 2;
            }
            if (this.Position == "Держслужбовець" || this.Position == "Керівник підприємства" ||
                this.Position == "Власник підприємства")

            {
                balprof = 4;
            }
            else
            {
                balprof = 3;
            }

            //Osvita
            int balOsvita = 0;
            if (this.Osvita == "Середня спеціальна")
            {
                balOsvita = 1;
            }
            if (this.Osvita == "Вища")
            {
                balOsvita = 2;
            }
            else
            {
                balOsvita = 0;
            }

            //Roduna
            int balroduna = 0;
            if (this.IsMerried == "Одружений / заміжня")
            {
                balroduna = 2;
            }

            if (this.IsMerried == "Вдівець(вдова)")
            {
                balroduna = 1;
            }
            else
            {
                balroduna = 0;
            }

            //DITY
            double balditu = 0.0;
            if (this.Children == 3)
            {
                balditu = 0.5;
            }
            if (this.Children == 1|| this.Children == 2)
            {
                balditu = 1;
            }
            else
            {
                balditu = 0;
            }

            //DEPOSIT
            int balDeposit = 0;
            if (this.HasDeposit == "Ні")
            {
                balDeposit = 0;
            }
            else if(this.HasDeposit == "Так")
            {
                balDeposit = 1;
            }


            // KREDUTNA ISTORIYA
            int balHistory = 0;
            if (this.Statistica == "Позитивна")
            {
                balHistory = 8;
            }
            if (this.Statistica == "Мав прострочки за платежами")
            {
                balHistory = 0;
            }
            else
            {
                balHistory = 5;
            }

            // ZABEZPECHENNYA
            int balzabez = 0;
            if (this.Rate > 30)
            {
                balzabez = 5;
            }
            else
            {
                balzabez = 0;
            }



            double sum = balVik + balprof + balOsvita + balroduna + balDeposit + balHistory + balzabez + balOstStag + balditu;
            this.SumBaliv = sum;

            if (sum < 5)
            {
                status = "Д";
            } else if (5 <= sum && sum < 13)
            {
                status = "Г";
            } else if (13 <= sum && sum < 15)
            {
                status = "В";
            } else if (15 <= sum && sum < 28)
            {
                status = "В";
            } else if (28 <= sum && sum <= 45)
            {
                status = "A";
            }

            
            return status;

        }

        private void buttonFinStan_Click(object sender, EventArgs e)
        {
            Models.Client _client = GetGeneralinfo(this.dogovir.ClientId);
            string status = CalculateFinanceStatus();

            MessageBox.Show(
                "Загальна сума балів позичальника:" +"\n" + "\n"+
                _client.SecondName+ " "+ _client.Name + " "+ _client.SurName+ " становила: "+ this.SumBaliv+"\n"+"\n"+
                "Фінансовий стан позичальника - " + status , "Фінансовий стан:"
                );
            textFinStan.Text = status;
            textFinState2.Text = status;

            if (this.Rate >= 30)
            {
                labelProviding.Text = Rate.ToString() + "% забезпечений";
               
            }
            else
            {
                labelProviding.Text = Rate.ToString() + "% незабезпечений";
                labelProviding.ForeColor = Color.Red;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnalys_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textAge.Text);
            string status = "";
            string agestatus = "";
            if (this.Rate <= 30)
            {
                status = "- фінансовий стан відрізняється";
            }
           

            if (age < 21)
            {
                agestatus = "- видано кредит клієнту, вік якого менше 21";
            }
            if (status == "" && agestatus == "")
            {
                MessageBox.Show(
                "Програма знайшла наступні помилки:" + "\n" + "\n" +
               "Помилки відсутні.", "Аналіз:"
                );
            }
            else
            {
                MessageBox.Show(
                "Програма знайшла наступні помилки:" + "\n" + "\n" +
                status + "\n" + "\n" +
                agestatus, "Аналіз:"
                );
            }
            
        }



    }
}
