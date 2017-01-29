namespace Auditbanka
{
    partial class AllStatistOfAuditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputCountOfCred = new System.Windows.Forms.TextBox();
            this.dtpNow = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.inputTotalSumOfCred = new System.Windows.Forms.TextBox();
            this.textFinished = new System.Windows.Forms.TextBox();
            this.textNotFinished = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textNotFinishedForSum = new System.Windows.Forms.TextBox();
            this.textFinishedForSum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Вихід";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(507, 57);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(159, 20);
            this.dtpEndDate.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(436, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(240, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "з";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(270, 57);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(121, 20);
            this.dtpStartDate.TabIndex = 30;
            this.dtpStartDate.Value = new System.DateTime(1995, 1, 29, 0, 0, 0, 0);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(224, 222);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 29;
            this.buttonSearch.Text = "Відобразити";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Кількість сплачених кредитів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Загальна сума кредитів:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Кількість кредитів:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Період статистики:";
            // 
            // inputCountOfCred
            // 
            this.inputCountOfCred.Location = new System.Drawing.Point(270, 92);
            this.inputCountOfCred.Name = "inputCountOfCred";
            this.inputCountOfCred.ReadOnly = true;
            this.inputCountOfCred.Size = new System.Drawing.Size(70, 20);
            this.inputCountOfCred.TabIndex = 22;
            // 
            // dtpNow
            // 
            this.dtpNow.Location = new System.Drawing.Point(507, 92);
            this.dtpNow.Name = "dtpNow";
            this.dtpNow.Size = new System.Drawing.Size(159, 20);
            this.dtpNow.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(64, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Кількість кредитів до сплати:";
            // 
            // inputTotalSumOfCred
            // 
            this.inputTotalSumOfCred.Location = new System.Drawing.Point(270, 123);
            this.inputTotalSumOfCred.Name = "inputTotalSumOfCred";
            this.inputTotalSumOfCred.ReadOnly = true;
            this.inputTotalSumOfCred.Size = new System.Drawing.Size(148, 20);
            this.inputTotalSumOfCred.TabIndex = 37;
            // 
            // textFinished
            // 
            this.textFinished.Location = new System.Drawing.Point(270, 157);
            this.textFinished.Name = "textFinished";
            this.textFinished.ReadOnly = true;
            this.textFinished.Size = new System.Drawing.Size(148, 20);
            this.textFinished.TabIndex = 38;
            // 
            // textNotFinished
            // 
            this.textNotFinished.Location = new System.Drawing.Point(270, 188);
            this.textNotFinished.Name = "textNotFinished";
            this.textNotFinished.ReadOnly = true;
            this.textNotFinished.Size = new System.Drawing.Size(148, 20);
            this.textNotFinished.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "грн.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "на суму:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "на суму:";
            // 
            // textNotFinishedForSum
            // 
            this.textNotFinishedForSum.Location = new System.Drawing.Point(501, 188);
            this.textNotFinishedForSum.Name = "textNotFinishedForSum";
            this.textNotFinishedForSum.ReadOnly = true;
            this.textNotFinishedForSum.Size = new System.Drawing.Size(148, 20);
            this.textNotFinishedForSum.TabIndex = 44;
            // 
            // textFinishedForSum
            // 
            this.textFinishedForSum.Location = new System.Drawing.Point(501, 157);
            this.textFinishedForSum.Name = "textFinishedForSum";
            this.textFinishedForSum.ReadOnly = true;
            this.textFinishedForSum.Size = new System.Drawing.Size(148, 20);
            this.textFinishedForSum.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(433, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Сьогодні:";
            // 
            // AllStatistOfAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 274);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textNotFinishedForSum);
            this.Controls.Add(this.textFinishedForSum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textNotFinished);
            this.Controls.Add(this.textFinished);
            this.Controls.Add(this.inputTotalSumOfCred);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputCountOfCred);
            this.Name = "AllStatistOfAudit";
            this.Text = "Статистика аудиту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputCountOfCred;
        private System.Windows.Forms.DateTimePicker dtpNow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputTotalSumOfCred;
        private System.Windows.Forms.TextBox textFinished;
        private System.Windows.Forms.TextBox textNotFinished;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textNotFinishedForSum;
        private System.Windows.Forms.TextBox textFinishedForSum;
        private System.Windows.Forms.Label label11;
    }
}