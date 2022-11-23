namespace PBD_Proiect.Displays
{
    partial class DisplayRestantieri
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
            this.lblRestantieri = new System.Windows.Forms.Label();
            this.tabelRestantieri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelRestantieri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestantieri
            // 
            this.lblRestantieri.AutoSize = true;
            this.lblRestantieri.Location = new System.Drawing.Point(16, 11);
            this.lblRestantieri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestantieri.Name = "lblRestantieri";
            this.lblRestantieri.Size = new System.Drawing.Size(122, 16);
            this.lblRestantieri.TabIndex = 0;
            this.lblRestantieri.Text = "Studenții restanțieri:";
            // 
            // tabelRestantieri
            // 
            this.tabelRestantieri.AllowUserToAddRows = false;
            this.tabelRestantieri.AllowUserToDeleteRows = false;
            this.tabelRestantieri.AllowUserToOrderColumns = true;
            this.tabelRestantieri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelRestantieri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelRestantieri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabelRestantieri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelRestantieri.Location = new System.Drawing.Point(20, 47);
            this.tabelRestantieri.Margin = new System.Windows.Forms.Padding(4);
            this.tabelRestantieri.Name = "tabelRestantieri";
            this.tabelRestantieri.RowHeadersWidth = 51;
            this.tabelRestantieri.Size = new System.Drawing.Size(1349, 543);
            this.tabelRestantieri.TabIndex = 1;
            // 
            // DisplayRestantieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 604);
            this.Controls.Add(this.tabelRestantieri);
            this.Controls.Add(this.lblRestantieri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayRestantieri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayRestantieri";
            this.Load += new System.EventHandler(this.DisplayRestantieri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelRestantieri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestantieri;
        private System.Windows.Forms.DataGridView tabelRestantieri;
    }
}