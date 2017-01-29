using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditbanka.Models
{
    static class Global
    {
        static int GRate = 9;
        static int GZab = 25;
        static int GAge = 21;

        public static int GRateChange
        {
            get
            {
                return GRate;
            }

            set
            {
                GRate = value;
            }
        }

        public static int GZabChange
        {
            get
            {
                return GZab;
            }

            set
            {
                GZab = value;
            }
        }

        public static int GAgeChange
        {
            get
            {
                return GAge;
            }

            set
            {
                GAge = value;
            }
        }
    }

    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
