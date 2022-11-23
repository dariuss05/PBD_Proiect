namespace PBD_Proiect.Displays
{
    partial class DisplayPromovabilitateMaterie
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
            this.tabelPromovabilitate = new System.Windows.Forms.DataGridView();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.listaMaterii = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelPromovabilitate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelPromovabilitate
            // 
            this.tabelPromovabilitate.AllowUserToAddRows = false;
            this.tabelPromovabilitate.AllowUserToDeleteRows = false;
            this.tabelPromovabilitate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelPromovabilitate.Location = new System.Drawing.Point(72, 133);
            this.tabelPromovabilitate.Name = "tabelPromovabilitate";
            this.tabelPromovabilitate.ReadOnly = true;
            this.tabelPromovabilitate.RowHeadersWidth = 51;
            this.tabelPromovabilitate.RowTemplate.Height = 24;
            this.tabelPromovabilitate.Size = new System.Drawing.Size(339, 299);
            this.tabelPromovabilitate.TabIndex = 0;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(143, 74);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(181, 42);
            this.btnCalcul.TabIndex = 2;
            this.btnCalcul.Text = "Calcul promovabilitate";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // listaMaterii
            // 
            this.listaMaterii.FormattingEnabled = true;
            this.listaMaterii.Location = new System.Drawing.Point(116, 32);
            this.listaMaterii.Name = "listaMaterii";
            this.listaMaterii.Size = new System.Drawing.Size(228, 24);
            this.listaMaterii.TabIndex = 1;
            // 
            // DisplayPromovabilitateMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 444);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.listaMaterii);
            this.Controls.Add(this.tabelPromovabilitate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayPromovabilitateMaterie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayPromovabilitateMaterie";
            this.Load += new System.EventHandler(this.DisplayPromovabilitateMaterie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelPromovabilitate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelPromovabilitate;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.ComboBox listaMaterii;
    }
}