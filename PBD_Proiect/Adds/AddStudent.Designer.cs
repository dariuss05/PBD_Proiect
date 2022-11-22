namespace PBD_Proiect.MainApps
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxNrLegim = new System.Windows.Forms.TextBox();
            this.txtBoxPrenume = new System.Windows.Forms.TextBox();
            this.txtBoxNume = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxMedieAn3 = new System.Windows.Forms.TextBox();
            this.txtBoxMedieAn2 = new System.Windows.Forms.TextBox();
            this.txtBoxMedieAn1 = new System.Windows.Forms.TextBox();
            this.txtBoxMedieGenerala = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numar legitimatie: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Media generala: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Media pe anul 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Media pe anul 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Media pe anul 3: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxNrLegim);
            this.groupBox1.Controls.Add(this.txtBoxPrenume);
            this.groupBox1.Controls.Add(this.txtBoxNume);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informatii personale";
            // 
            // txtBoxNrLegim
            // 
            this.txtBoxNrLegim.Location = new System.Drawing.Point(133, 134);
            this.txtBoxNrLegim.Name = "txtBoxNrLegim";
            this.txtBoxNrLegim.Size = new System.Drawing.Size(240, 22);
            this.txtBoxNrLegim.TabIndex = 5;
            // 
            // txtBoxPrenume
            // 
            this.txtBoxPrenume.Location = new System.Drawing.Point(92, 84);
            this.txtBoxPrenume.Name = "txtBoxPrenume";
            this.txtBoxPrenume.Size = new System.Drawing.Size(281, 22);
            this.txtBoxPrenume.TabIndex = 4;
            // 
            // txtBoxNume
            // 
            this.txtBoxNume.Location = new System.Drawing.Point(71, 36);
            this.txtBoxNume.Name = "txtBoxNume";
            this.txtBoxNume.Size = new System.Drawing.Size(302, 22);
            this.txtBoxNume.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxMedieAn3);
            this.groupBox2.Controls.Add(this.txtBoxMedieAn2);
            this.groupBox2.Controls.Add(this.txtBoxMedieAn1);
            this.groupBox2.Controls.Add(this.txtBoxMedieGenerala);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note";
            // 
            // txtBoxMedieAn3
            // 
            this.txtBoxMedieAn3.Location = new System.Drawing.Point(133, 151);
            this.txtBoxMedieAn3.Name = "txtBoxMedieAn3";
            this.txtBoxMedieAn3.Size = new System.Drawing.Size(240, 22);
            this.txtBoxMedieAn3.TabIndex = 10;
            // 
            // txtBoxMedieAn2
            // 
            this.txtBoxMedieAn2.Location = new System.Drawing.Point(133, 114);
            this.txtBoxMedieAn2.Name = "txtBoxMedieAn2";
            this.txtBoxMedieAn2.Size = new System.Drawing.Size(240, 22);
            this.txtBoxMedieAn2.TabIndex = 9;
            // 
            // txtBoxMedieAn1
            // 
            this.txtBoxMedieAn1.Location = new System.Drawing.Point(133, 75);
            this.txtBoxMedieAn1.Name = "txtBoxMedieAn1";
            this.txtBoxMedieAn1.Size = new System.Drawing.Size(240, 22);
            this.txtBoxMedieAn1.TabIndex = 8;
            // 
            // txtBoxMedieGenerala
            // 
            this.txtBoxMedieGenerala.Location = new System.Drawing.Point(133, 37);
            this.txtBoxMedieGenerala.Name = "txtBoxMedieGenerala";
            this.txtBoxMedieGenerala.Size = new System.Drawing.Size(240, 22);
            this.txtBoxMedieGenerala.TabIndex = 7;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(26, 510);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(122, 53);
            this.btnAdaugare.TabIndex = 9;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(409, 510);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(122, 53);
            this.btnAnulare.TabIndex = 10;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 603);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.TextBox txtBoxNrLegim;
        private System.Windows.Forms.TextBox txtBoxPrenume;
        private System.Windows.Forms.TextBox txtBoxNume;
        private System.Windows.Forms.TextBox txtBoxMedieAn3;
        private System.Windows.Forms.TextBox txtBoxMedieAn2;
        private System.Windows.Forms.TextBox txtBoxMedieAn1;
        private System.Windows.Forms.TextBox txtBoxMedieGenerala;
    }
}