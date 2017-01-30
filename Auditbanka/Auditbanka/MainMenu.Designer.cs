namespace Auditbanka
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAnalysOfCredits = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.аудитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemJournal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStatist = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConstantu = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.inputMainSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операціїToolStripMenuItem,
            this.аудитToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAnalysOfCredits,
            this.MenuItemExit});
            this.операціїToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // MenuItemAnalysOfCredits
            // 
            this.MenuItemAnalysOfCredits.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemAnalysOfCredits.Image")));
            this.MenuItemAnalysOfCredits.Name = "MenuItemAnalysOfCredits";
            this.MenuItemAnalysOfCredits.Size = new System.Drawing.Size(223, 22);
            this.MenuItemAnalysOfCredits.Text = "Аналіз кредитів     F2";
            this.MenuItemAnalysOfCredits.Click += new System.EventHandler(this.MenuItemAnalysOfCredits_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemExit.Image")));
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(223, 22);
            this.MenuItemExit.Text = "Вихід                    Alt+F4";
            this.MenuItemExit.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // аудитToolStripMenuItem
            // 
            this.аудитToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemJournal,
            this.MenuItemStatist,
            this.MenuItemConstantu});
            this.аудитToolStripMenuItem.Name = "аудитToolStripMenuItem";
            this.аудитToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.аудитToolStripMenuItem.Text = "Аудит";
            // 
            // MenuItemJournal
            // 
            this.MenuItemJournal.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemJournal.Image")));
            this.MenuItemJournal.Name = "MenuItemJournal";
            this.MenuItemJournal.Size = new System.Drawing.Size(229, 22);
            this.MenuItemJournal.Text = "Журнал перевірок       F3";
            this.MenuItemJournal.Click += new System.EventHandler(this.MenuItemJournal_Click);
            // 
            // MenuItemStatist
            // 
            this.MenuItemStatist.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemStatist.Image")));
            this.MenuItemStatist.Name = "MenuItemStatist";
            this.MenuItemStatist.Size = new System.Drawing.Size(229, 22);
            this.MenuItemStatist.Text = "Статистика                   F4";
            this.MenuItemStatist.Click += new System.EventHandler(this.MenuItemStatist_Click);
            // 
            // MenuItemConstantu
            // 
            this.MenuItemConstantu.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemConstantu.Image")));
            this.MenuItemConstantu.Name = "MenuItemConstantu";
            this.MenuItemConstantu.Size = new System.Drawing.Size(229, 22);
            this.MenuItemConstantu.Text = "Константи                    F5";
            this.MenuItemConstantu.Click += new System.EventHandler(this.MenuItemConstantu_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAboutProgram});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // MenuItemAboutProgram
            // 
            this.MenuItemAboutProgram.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemAboutProgram.Image")));
            this.MenuItemAboutProgram.Name = "MenuItemAboutProgram";
            this.MenuItemAboutProgram.Size = new System.Drawing.Size(196, 22);
            this.MenuItemAboutProgram.Text = "Про програму     F1";
            this.MenuItemAboutProgram.Click += new System.EventHandler(this.MenuItemAboutProgram_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.inputMainSearch,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel1.Text = "Пошук";
            // 
            // inputMainSearch
            // 
            this.inputMainSearch.Name = "inputMainSearch";
            this.inputMainSearch.Size = new System.Drawing.Size(100, 25);
            this.inputMainSearch.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(736, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Аналіз кредитної діяльності - Kisera Corp. v.1.0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.KeyDown += MainMenu_KeyDown;
            

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAnalysOfCredits;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAboutProgram;
        private System.Windows.Forms.ToolStripMenuItem аудитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemJournal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStatist;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConstantu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox inputMainSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}