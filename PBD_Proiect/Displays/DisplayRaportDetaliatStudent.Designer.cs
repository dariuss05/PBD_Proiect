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
            this.listaDetaliataStudent.Location = new System.Drawing.Point(42, 66);
            this.listaDetaliataStudent.Name = "listaDetaliataStudent";
            this.listaDetaliataStudent.ReadOnly = true;
            this.listaDetaliataStudent.Size = new System.Drawing.Size(799, 466);
            this.listaDetaliataStudent.TabIndex = 1;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(417, 35);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(173, 13);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Raport Detaliat Studenti Promovati:";
            // 
            // lblOrdine
            // 
            this.lblOrdine.AutoSize = true;
            this.lblOrdine.Location = new System.Drawing.Point(880, 216);
            this.lblOrdine.Name = "lblOrdine";
            this.lblOrdine.Size = new System.Drawing.Size(91, 13);
            this.lblOrdine.TabIndex = 3;
            this.lblOrdine.Text = "Selectati Ordinea:";
            // 
            // btnNume
            // 
            this.btnNume.AutoSize = true;
            this.btnNume.Location = new System.Drawing.Point(883, 243);
            this.btnNume.Name = "btnNume";
            this.btnNume.Size = new System.Drawing.Size(53, 17);
            this.btnNume.TabIndex = 4;
            this.btnNume.TabStop = true;
            this.btnNume.Text = "Nume";
            this.btnNume.UseVisualStyleBackColor = true;
            this.btnNume.CheckedChanged += new System.EventHandler(this.btnNume_CheckedChanged);
            // 
            // btnPrenume
            // 
            this.btnPrenume.AutoSize = true;
            this.btnPrenume.Location = new System.Drawing.Point(883, 266);
            this.btnPrenume.Name = "btnPrenume";
            this.btnPrenume.Size = new System.Drawing.Size(67, 17);
            this.btnPrenume.TabIndex = 5;
            this.btnPrenume.TabStop = true;
            this.btnPrenume.Text = "Prenume";
            this.btnPrenume.UseVisualStyleBackColor = true;
            this.btnPrenume.CheckedChanged += new System.EventHandler(this.btnPrenume_CheckedChanged);
            // 
            // btnAnStudiu
            // 
            this.btnAnStudiu.AutoSize = true;
            this.btnAnStudiu.Location = new System.Drawing.Point(883, 289);
            this.btnAnStudiu.Name = "btnAnStudiu";
            this.btnAnStudiu.Size = new System.Drawing.Size(74, 17);
            this.btnAnStudiu.TabIndex = 6;
            this.btnAnStudiu.TabStop = true;
            this.btnAnStudiu.Text = "An_Studiu";
            this.btnAnStudiu.UseVisualStyleBackColor = true;
            this.btnAnStudiu.CheckedChanged += new System.EventHandler(this.btnAnStudiu_CheckedChanged);
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.AutoSize = true;
            this.btnDisciplina.Location = new System.Drawing.Point(883, 312);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(70, 17);
            this.btnDisciplina.TabIndex = 7;
            this.btnDisciplina.TabStop = true;
            this.btnDisciplina.Text = "Disciplina";
            this.btnDisciplina.UseVisualStyleBackColor = true;
            this.btnDisciplina.CheckedChanged += new System.EventHandler(this.btnDisciplina_CheckedChanged);
            // 
            // DisplayRaportDetaliatStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 544);
            this.Controls.Add(this.btnDisciplina);
            this.Controls.Add(this.btnAnStudiu);
            this.Controls.Add(this.btnPrenume);
            this.Controls.Add(this.btnNume);
            this.Controls.Add(this.lblOrdine);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.listaDetaliataStudent);
            this.Name = "DisplayRaportDetaliatStudent";
            this.Text = "DisplayRaportDetaliatStudent";
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