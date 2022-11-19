namespace PBD_Proiect.Displays
{
    partial class DisplayPrezentariExamenStudent
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
            this.tabelStudentNrPrezentari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelStudentNrPrezentari)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelStudentNrPrezentari
            // 
            this.tabelStudentNrPrezentari.AllowUserToAddRows = false;
            this.tabelStudentNrPrezentari.AllowUserToDeleteRows = false;
            this.tabelStudentNrPrezentari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelStudentNrPrezentari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelStudentNrPrezentari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabelStudentNrPrezentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelStudentNrPrezentari.Location = new System.Drawing.Point(13, 26);
            this.tabelStudentNrPrezentari.Name = "tabelStudentNrPrezentari";
            this.tabelStudentNrPrezentari.ReadOnly = true;
            this.tabelStudentNrPrezentari.Size = new System.Drawing.Size(890, 429);
            this.tabelStudentNrPrezentari.TabIndex = 0;
            // 
            // DisplayPrezentariExamenStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 467);
            this.Controls.Add(this.tabelStudentNrPrezentari);
            this.Name = "DisplayPrezentariExamenStudent";
            this.Text = "DisplayPrezentariExamenStudent";
            this.Load += new System.EventHandler(this.DisplayPrezentariExamenStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelStudentNrPrezentari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelStudentNrPrezentari;
    }
}