namespace PBD_Proiect
{
    partial class MainApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.notaMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.restantieriMenuAfisare = new System.Windows.Forms.ToolStripMenuItem();
            this.restantieriMenuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.raportStudentMenuAfisare = new System.Windows.Forms.ToolStripMenuItem();
            this.raportDetaliatMenuAfisare = new System.Windows.Forms.ToolStripMenuItem();
            this.promovabilitateStudentMenuAfisare = new System.Windows.Forms.ToolStripMenuItem();
            this.restanteConsecutiveMenuAfisare = new System.Windows.Forms.ToolStripMenuItem();
            this.prezentariExamenMenuAfisare = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.restantieriMenuAfisare,
            this.iesireMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentMenuAdd,
            this.notaMenuAdd});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "Adaugă";
            // 
            // studentMenuAdd
            // 
            this.studentMenuAdd.Name = "studentMenuAdd";
            this.studentMenuAdd.Size = new System.Drawing.Size(115, 22);
            this.studentMenuAdd.Text = "Student";
            this.studentMenuAdd.Click += new System.EventHandler(this.studentMenuAdd_Click);
            // 
            // notaMenuAdd
            // 
            this.notaMenuAdd.Name = "notaMenuAdd";
            this.notaMenuAdd.Size = new System.Drawing.Size(115, 22);
            this.notaMenuAdd.Text = "Notă";
            this.notaMenuAdd.Click += new System.EventHandler(this.notaMenuAdd_Click);
            // 
            // restantieriMenuAfisare
            // 
            this.restantieriMenuAfisare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restantieriMenuDisplay,
            this.raportStudentMenuAfisare,
            this.raportDetaliatMenuAfisare,
            this.promovabilitateStudentMenuAfisare,
            this.restanteConsecutiveMenuAfisare,
            this.prezentariExamenMenuAfisare});
            this.restantieriMenuAfisare.Name = "restantieriMenuAfisare";
            this.restantieriMenuAfisare.Size = new System.Drawing.Size(55, 20);
            this.restantieriMenuAfisare.Text = "Afișare";
            // 
            // restantieriMenuDisplay
            // 
            this.restantieriMenuDisplay.Name = "restantieriMenuDisplay";
            this.restantieriMenuDisplay.Size = new System.Drawing.Size(214, 22);
            this.restantieriMenuDisplay.Text = "Restanțieri";
            this.restantieriMenuDisplay.Click += new System.EventHandler(this.restantieriMenuDisplay_Click);
            // 
            // raportStudentMenuAfisare
            // 
            this.raportStudentMenuAfisare.Name = "raportStudentMenuAfisare";
            this.raportStudentMenuAfisare.Size = new System.Drawing.Size(214, 22);
            this.raportStudentMenuAfisare.Text = "Raport-student";
            this.raportStudentMenuAfisare.Click += new System.EventHandler(this.raportStudentMenuAfisare_Click);
            // 
            // raportDetaliatMenuAfisare
            // 
            this.raportDetaliatMenuAfisare.Name = "raportDetaliatMenuAfisare";
            this.raportDetaliatMenuAfisare.Size = new System.Drawing.Size(214, 22);
            this.raportDetaliatMenuAfisare.Text = "Raport-detaliat student";
            this.raportDetaliatMenuAfisare.Click += new System.EventHandler(this.raportDetaliatMenuAfisare_Click);
            // 
            // promovabilitateStudentMenuAfisare
            // 
            this.promovabilitateStudentMenuAfisare.Name = "promovabilitateStudentMenuAfisare";
            this.promovabilitateStudentMenuAfisare.Size = new System.Drawing.Size(214, 22);
            this.promovabilitateStudentMenuAfisare.Text = "Promovabilitate materie";
            this.promovabilitateStudentMenuAfisare.Click += new System.EventHandler(this.promovabilitateStudentMenuAfisare_Click);
            // 
            // restanteConsecutiveMenuAfisare
            // 
            this.restanteConsecutiveMenuAfisare.Name = "restanteConsecutiveMenuAfisare";
            this.restanteConsecutiveMenuAfisare.Size = new System.Drawing.Size(214, 22);
            this.restanteConsecutiveMenuAfisare.Text = "Restanțe consecutive";
            this.restanteConsecutiveMenuAfisare.Click += new System.EventHandler(this.restanteConsecutiveMenuAfisare_Click);
            // 
            // prezentariExamenMenuAfisare
            // 
            this.prezentariExamenMenuAfisare.Name = "prezentariExamenMenuAfisare";
            this.prezentariExamenMenuAfisare.Size = new System.Drawing.Size(214, 22);
            this.prezentariExamenMenuAfisare.Text = "Prezentări examen student";
            this.prezentariExamenMenuAfisare.Click += new System.EventHandler(this.prezentariExamenMenuAfisare_Click);
            // 
            // iesireMenu
            // 
            this.iesireMenu.Name = "iesireMenu";
            this.iesireMenu.Size = new System.Drawing.Size(46, 20);
            this.iesireMenu.Text = "Ieșire";
            this.iesireMenu.Click += new System.EventHandler(this.iesireMenu_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restantieriMenuAfisare;
        private System.Windows.Forms.ToolStripMenuItem restantieriMenuDisplay;
        private System.Windows.Forms.ToolStripMenuItem raportStudentMenuAfisare;
        private System.Windows.Forms.ToolStripMenuItem raportDetaliatMenuAfisare;
        private System.Windows.Forms.ToolStripMenuItem promovabilitateStudentMenuAfisare;
        private System.Windows.Forms.ToolStripMenuItem restanteConsecutiveMenuAfisare;
        private System.Windows.Forms.ToolStripMenuItem prezentariExamenMenuAfisare;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem notaMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem iesireMenu;
    }
}

