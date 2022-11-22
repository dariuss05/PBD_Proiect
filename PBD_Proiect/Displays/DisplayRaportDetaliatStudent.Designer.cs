namespace PBD_Proiect.Displays
{
    partial class DisplayRaportDetaliatStudent
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
            this.listaDetaliataStudent = new System.Windows.Forms.DataGridView();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblOrdine = new System.Windows.Forms.Label();
            this.btnNume = new System.Windows.Forms.RadioButton();
            this.btnPrenume = new System.Windows.Forms.RadioButton();
            this.btnAnStudiu = new System.Windows.Forms.RadioButton();
            this.btnDisciplina = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaDetaliataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // listaDetaliataStudent
            // 
            this.listaDetaliataStudent.AllowUserToAddRows = false;
            this.listaDetaliataStudent.AllowUserToDeleteRows = false;
            this.listaDetaliataStudent.AllowUserToOrderColumns = true;
            this.listaDetaliataStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaDetaliataStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaDetaliataStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaDetaliataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDetaliataStudent.Location = new System.Drawing.Point(56, 81);
            this.listaDetaliataStudent.Margin = new System.Windows.Forms.Padding(4);
            this.listaDetaliataStudent.Name = "listaDetaliataStudent";
            this.listaDetaliataStudent.ReadOnly = true;
            this.listaDetaliataStudent.RowHeadersWidth = 51;
            this.listaDetaliataStudent.Size = new System.Drawing.Size(1065, 574);
            this.listaDetaliataStudent.TabIndex = 1;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(556, 43);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(215, 16);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Raport Detaliat Studenti Promovati:";
            // 
            // lblOrdine
            // 
            this.lblOrdine.AutoSize = true;
            this.lblOrdine.Location = new System.Drawing.Point(1173, 266);
            this.lblOrdine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdine.Name = "lblOrdine";
            this.lblOrdine.Size = new System.Drawing.Size(113, 16);
            this.lblOrdine.TabIndex = 3;
            this.lblOrdine.Text = "Selectati Ordinea:";
            // 
            // btnNume
            // 
            this.btnNume.AutoSize = true;
            this.btnNume.Location = new System.Drawing.Point(1177, 299);
            this.btnNume.Margin = new System.Windows.Forms.Padding(4);
            this.btnNume.Name = "btnNume";
            this.btnNume.Size = new System.Drawing.Size(64, 20);
            this.btnNume.TabIndex = 4;
            this.btnNume.TabStop = true;
            this.btnNume.Text = "Nume";
            this.btnNume.UseVisualStyleBackColor = true;
            this.btnNume.CheckedChanged += new System.EventHandler(this.btnNume_CheckedChanged);
            // 
            // btnPrenume
            // 
            this.btnPrenume.AutoSize = true;
            this.btnPrenume.Location = new System.Drawing.Point(1177, 327);
            this.btnPrenume.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrenume.Name = "btnPrenume";
            this.btnPrenume.Size = new System.Drawing.Size(82, 20);
            this.btnPrenume.TabIndex = 5;
            this.btnPrenume.TabStop = true;
            this.btnPrenume.Text = "Prenume";
            this.btnPrenume.UseVisualStyleBackColor = true;
            this.btnPrenume.CheckedChanged += new System.EventHandler(this.btnPrenume_CheckedChanged);
            // 
            // btnAnStudiu
            // 
            this.btnAnStudiu.AutoSize = true;
            this.btnAnStudiu.Location = new System.Drawing.Point(1177, 356);
            this.btnAnStudiu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnStudiu.Name = "btnAnStudiu";
            this.btnAnStudiu.Size = new System.Drawing.Size(88, 20);
            this.btnAnStudiu.TabIndex = 6;
            this.btnAnStudiu.TabStop = true;
            this.btnAnStudiu.Text = "An_Studiu";
            this.btnAnStudiu.UseVisualStyleBackColor = true;
            this.btnAnStudiu.CheckedChanged += new System.EventHandler(this.btnAnStudiu_CheckedChanged);
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.AutoSize = true;
            this.btnDisciplina.Location = new System.Drawing.Point(1177, 384);
            this.btnDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(87, 20);
            this.btnDisciplina.TabIndex = 7;
            this.btnDisciplina.TabStop = true;
            this.btnDisciplina.Text = "Disciplina";
            this.btnDisciplina.UseVisualStyleBackColor = true;
            this.btnDisciplina.CheckedChanged += new System.EventHandler(this.btnDisciplina_CheckedChanged);
            // 
            // DisplayRaportDetaliatStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 670);
            this.Controls.Add(this.btnDisciplina);
            this.Controls.Add(this.btnAnStudiu);
            this.Controls.Add(this.btnPrenume);
            this.Controls.Add(this.btnNume);
            this.Controls.Add(this.lblOrdine);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.listaDetaliataStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayRaportDetaliatStudent";
            this.Text = "DisplayRaportDetaliatStudent";
            ((System.ComponentModel.ISupportInitialize)(this.listaDetaliataStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listaDetaliataStudent;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblOrdine;
        private System.Windows.Forms.RadioButton btnNume;
        private System.Windows.Forms.RadioButton btnPrenume;
        private System.Windows.Forms.RadioButton btnAnStudiu;
        private System.Windows.Forms.RadioButton btnDisciplina;
    }
}