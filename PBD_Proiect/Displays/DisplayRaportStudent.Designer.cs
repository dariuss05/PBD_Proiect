namespace PBD_Proiect.Displays
{
    partial class DisplayRaportStudent
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
            this.tabelRaportStudenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelRaportStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raport Studenti:";
            // 
            // tabelRaportStudenti
            // 
            this.tabelRaportStudenti.AllowUserToAddRows = false;
            this.tabelRaportStudenti.AllowUserToDeleteRows = false;
            this.tabelRaportStudenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelRaportStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelRaportStudenti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabelRaportStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelRaportStudenti.Location = new System.Drawing.Point(13, 42);
            this.tabelRaportStudenti.Name = "tabelRaportStudenti";
            this.tabelRaportStudenti.Size = new System.Drawing.Size(980, 489);
            this.tabelRaportStudenti.TabIndex = 1;
            // 
            // DisplayRaportStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 543);
            this.Controls.Add(this.tabelRaportStudenti);
            this.Controls.Add(this.label1);
            this.Name = "DisplayRaportStudent";
            this.Text = "DisplayRaportStudent";
            this.Load += new System.EventHandler(this.DisplayRaportStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelRaportStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabelRaportStudenti;
    }
}