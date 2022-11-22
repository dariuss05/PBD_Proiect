namespace PBD_Proiect.MainApps
{
    partial class AddNote
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxNrLegim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxNrPrezentare = new System.Windows.Forms.TextBox();
            this.txtBoxAnStudiu = new System.Windows.Forms.TextBox();
            this.txtBoxDisciplina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxNota = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.datePickerData = new System.Windows.Forms.DateTimePicker();
            this.btnValidare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxNrLegim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informatii personale";
            // 
            // txtBoxNrLegim
            // 
            this.txtBoxNrLegim.Location = new System.Drawing.Point(133, 32);
            this.txtBoxNrLegim.Name = "txtBoxNrLegim";
            this.txtBoxNrLegim.Size = new System.Drawing.Size(293, 22);
            this.txtBoxNrLegim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numar legitimatie: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datePickerData);
            this.groupBox2.Controls.Add(this.txtBoxNota);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxNrPrezentare);
            this.groupBox2.Controls.Add(this.txtBoxAnStudiu);
            this.groupBox2.Controls.Add(this.txtBoxDisciplina);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 274);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informatii despre nota";
            // 
            // txtBoxNrPrezentare
            // 
            this.txtBoxNrPrezentare.Location = new System.Drawing.Point(153, 131);
            this.txtBoxNrPrezentare.Name = "txtBoxNrPrezentare";
            this.txtBoxNrPrezentare.Size = new System.Drawing.Size(268, 22);
            this.txtBoxNrPrezentare.TabIndex = 5;
            // 
            // txtBoxAnStudiu
            // 
            this.txtBoxAnStudiu.Location = new System.Drawing.Point(195, 81);
            this.txtBoxAnStudiu.Name = "txtBoxAnStudiu";
            this.txtBoxAnStudiu.Size = new System.Drawing.Size(226, 22);
            this.txtBoxAnStudiu.TabIndex = 4;
            // 
            // txtBoxDisciplina
            // 
            this.txtBoxDisciplina.Location = new System.Drawing.Point(94, 33);
            this.txtBoxDisciplina.Name = "txtBoxDisciplina";
            this.txtBoxDisciplina.Size = new System.Drawing.Size(327, 22);
            this.txtBoxDisciplina.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anul de studiu al disciplinei:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numarul prezentarii: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data prezentarii: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nota obtinuta:";
            // 
            // txtBoxNota
            // 
            this.txtBoxNota.Location = new System.Drawing.Point(114, 221);
            this.txtBoxNota.Name = "txtBoxNota";
            this.txtBoxNota.Size = new System.Drawing.Size(268, 22);
            this.txtBoxNota.TabIndex = 8;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(15, 553);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(145, 47);
            this.btnAdaugare.TabIndex = 10;
            this.btnAdaugare.Text = "Adaugare nota";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(376, 553);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(145, 47);
            this.btnAnulare.TabIndex = 11;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // datePickerData
            // 
            this.datePickerData.Location = new System.Drawing.Point(132, 177);
            this.datePickerData.Name = "datePickerData";
            this.datePickerData.Size = new System.Drawing.Size(250, 22);
            this.datePickerData.TabIndex = 9;
            // 
            // btnValidare
            // 
            this.btnValidare.Location = new System.Drawing.Point(202, 146);
            this.btnValidare.Name = "btnValidare";
            this.btnValidare.Size = new System.Drawing.Size(97, 35);
            this.btnValidare.TabIndex = 12;
            this.btnValidare.Text = "Validare";
            this.btnValidare.UseVisualStyleBackColor = true;
            this.btnValidare.Click += new System.EventHandler(this.btnValidare_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 612);
            this.Controls.Add(this.btnValidare);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNote";
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxNrLegim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxNrPrezentare;
        private System.Windows.Forms.TextBox txtBoxAnStudiu;
        private System.Windows.Forms.TextBox txtBoxDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.DateTimePicker datePickerData;
        private System.Windows.Forms.Button btnValidare;
    }
}