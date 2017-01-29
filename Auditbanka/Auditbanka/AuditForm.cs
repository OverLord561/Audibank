using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Auditbanka
{
    public partial class AuditForm : Form
    {
        List<Models.Audit> allAudit;
        public int dogovirId = 2;
        public AuditForm(  )
        {
            InitializeComponent();
            // ПЕРЕДАТИ НОМЕР КРЕДИТНОГО ДОГОВОРУ
            SetData(dogovirId);
        }

        public void SetData( int dogovirId )
        {
            using (Models.BankContext db = new Models.BankContext())
            {
                this.allAudit = db.Audit.Where(x => x.DogovirId == dogovirId).ToList();
                dataGridViewAudit.DataSource = this.allAudit;

                dataGridViewAudit.Columns["Dogovir"].Visible = false;
                dataGridViewAudit.Columns["AuditId"].HeaderText = "№";
                dataGridViewAudit.Columns["DogovirId"].HeaderText = "№ кредитної операції";
                dataGridViewAudit.Columns["DateofAudit"].HeaderText = "Дата провірки";
                dataGridViewAudit.Columns["Result"].HeaderText = "Результат";

                dataGridViewAudit.AutoResizeColumns();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void copyAlltoClipboard()
        {
            dataGridViewAudit.SelectAll();
            DataObject dataObj = dataGridViewAudit.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();



                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Models.Audit aud in this.allAudit)
            {
                using (Models.BankContext db = new Models.BankContext())
                {
                    db.Entry(aud).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            dataGridViewAudit.DataSource = null;
            SetData(dogovirId);
        }
    }
}
