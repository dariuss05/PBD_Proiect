namespace PBD_Proiect.Displays
{
    partial class DisplayRestanteConsecutive
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
            this.tabelRestanteCons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelRestanteCons)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelRestanteCons
            // 
            this.tabelRestanteCons.AllowUserToAddRows = false;
            this.tabelRestanteCons.AllowUserToDeleteRows = false;
            this.tabelRestanteCons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelRestanteCons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelRestanteCons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabelRestanteCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelRestanteCons.Location = new System.Drawing.Point(13, 34);
            this.tabelRestanteCons.Name = "tabelRestanteCons";
            this.tabelRestanteCons.Size = new System.Drawing.Size(775, 404);
            this.tabelRestanteCons.TabIndex = 0;
            // 
            // DisplayRestanteConsecutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabelRestanteCons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayRestanteConsecutive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayRestanteConsecutive";
            this.Load += new System.EventHandler(this.DisplayRestanteConsecutive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelRestanteCons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelRestanteCons;
    }
}