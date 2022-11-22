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
            this.tabelStudenti = new System.Windows.Forms.DataGridView();
            this.tabelNote = new System.Windows.Forms.DataGridView();
            this.lblTabelNote = new System.Windows.Forms.Label();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelNote)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.restantieriMenuAfisare,
            this.iesireMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentMenuAdd,
            this.notaMenuAdd});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.fileToolStripMenuItem.Text = "Adaugă";
            // 
            // studentMenuAdd
            // 
            this.studentMenuAdd.Name = "studentMenuAdd";
            this.studentMenuAdd.Size = new System.Drawing.Size(143, 26);
            this.studentMenuAdd.Text = "Student";
            this.studentMenuAdd.Click += new System.EventHandler(this.studentMenuAdd_Click);
            // 
            // notaMenuAdd
            // 
            this.notaMenuAdd.Name = "notaMenuAdd";
            this.notaMenuAdd.Size = new System.Drawing.Size(143, 26);
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
            this.restantieriMenuAfisare.Size = new System.Drawing.Size(69, 24);
            this.restantieriMenuAfisare.Text = "Afișare";
            // 
            // restantieriMenuDisplay
            // 
            this.restantieriMenuDisplay.Name = "restantieriMenuDisplay";
            this.restantieriMenuDisplay.Size = new System.Drawing.Size(267, 26);
            this.restantieriMenuDisplay.Text = "Restanțieri";
            this.restantieriMenuDisplay.Click += new System.EventHandler(this.restantieriMenuDisplay_Click);
            // 
            // raportStudentMenuAfisare
            // 
            this.raportStudentMenuAfisare.Name = "raportStudentMenuAfisare";
            this.raportStudentMenuAfisare.Size = new System.Drawing.Size(267, 26);
            this.raportStudentMenuAfisare.Text = "Raport-student";
            this.raportStudentMenuAfisare.Click += new System.EventHandler(this.raportStudentMenuAfisare_Click);
            // 
            // raportDetaliatMenuAfisare
            // 
            this.raportDetaliatMenuAfisare.Name = "raportDetaliatMenuAfisare";
            this.raportDetaliatMenuAfisare.Size = new System.Drawing.Size(267, 26);
            this.raportDetaliatMenuAfisare.Text = "Raport-detaliat student";
            this.raportDetaliatMenuAfisare.Click += new System.EventHandler(this.raportDetaliatMenuAfisare_Click);
            // 
            // promovabilitateStudentMenuAfisare
            // 
            this.promovabilitateStudentMenuAfisare.Name = "promovabilitateStudentMenuAfisare";
            this.promovabilitateStudentMenuAfisare.Size = new System.Drawing.Size(267, 26);
            this.promovabilitateStudentMenuAfisare.Text = "Promovabilitate materie";
            this.promovabilitateStudentMenuAfisare.Click += new System.EventHandler(this.promovabilitateStudentMenuAfisare_Click);
            // 
            // restanteConsecutiveMenuAfisare
            // 
            this.restanteConsecutiveMenuAfisare.Name = "restanteConsecutiveMenuAfisare";
            this.restanteConsecutiveMenuAfisare.Size = new System.Drawing.Size(267, 26);
            this.restanteConsecutiveMenuAfisare.Text = "Restanțe consecutive";
            this.restanteConsecutiveMenuAfisare.Click += new System.EventHandler(this.restanteConsecutiveMenuAfisare_Click);
            // 
            // prezentariExamenMenuAfisare
            // 
            this.prezentariExamenMenuAfisare.Name = "prezentariExamenMenuAfisare";
            this.prezentariExamenMenuAfisare.Size = new System.Drawing.Size(267, 26);
            this.prezentariExamenMenuAfisare.Text = "Prezentări examen student";
            this.prezentariExamenMenuAfisare.Click += new System.EventHandler(this.prezentariExamenMenuAfisare_Click);
            // 
            // iesireMenu
            // 
            this.iesireMenu.Name = "iesireMenu";
            this.iesireMenu.Size = new System.Drawing.Size(58, 24);
            this.iesireMenu.Text = "Ieșire";
            this.iesireMenu.Click += new System.EventHandler(this.iesireMenu_Click);
            // 
            // tabelStudenti
            // 
            this.tabelStudenti.AllowUserToAddRows = false;
            this.tabelStudenti.AllowUserToDeleteRows = false;
            this.tabelStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelStudenti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabelStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelStudenti.Location = new System.Drawing.Point(39, 76);
            this.tabelStudenti.Margin = new System.Windows.Forms.Padding(4);
            this.tabelStudenti.Name = "tabelStudenti";
            this.tabelStudenti.ReadOnly = true;
            this.tabelStudenti.RowHeadersWidth = 51;
            this.tabelStudenti.Size = new System.Drawing.Size(1145, 307);
            this.tabelStudenti.TabIndex = 1;
            // 
            // tabelNote
            // 
            this.tabelNote.AllowUserToAddRows = false;
            this.tabelNote.AllowUserToDeleteRows = false;
            this.tabelNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelNote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabelNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelNote.Location = new System.Drawing.Point(42, 450);
            this.tabelNote.Margin = new System.Windows.Forms.Padding(4);
            this.tabelNote.Name = "tabelNote";
            this.tabelNote.ReadOnly = true;
            this.tabelNote.RowHeadersWidth = 51;
            this.tabelNote.Size = new System.Drawing.Size(1142, 325);
            this.tabelNote.TabIndex = 2;
            // 
            // lblTabelNote
            // 
            this.lblTabelNote.AutoSize = true;
            this.lblTabelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTabelNote.Location = new System.Drawing.Point(566, 422);
            this.lblTabelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabelNote.Name = "lblTabelNote";
            this.lblTabelNote.Size = new System.Drawing.Size(108, 24);
            this.lblTabelNote.TabIndex = 3;
            this.lblTabelNote.Text = "Tabel Note:";
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblStudenti.Location = new System.Drawing.Point(555, 48);
            this.lblStudenti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(136, 24);
            this.lblStudenti.TabIndex = 4;
            this.lblStudenti.Text = "Tabel Studenti:";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1228, 961);
            this.Controls.Add(this.lblStudenti);
            this.Controls.Add(this.lblTabelNote);
            this.Controls.Add(this.tabelNote);
            this.Controls.Add(this.tabelStudenti);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelNote)).EndInit();
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
        private System.Windows.Forms.DataGridView tabelStudenti;
        private System.Windows.Forms.DataGridView tabelNote;
        private System.Windows.Forms.Label lblTabelNote;
        private System.Windows.Forms.Label lblStudenti;
    }
}

