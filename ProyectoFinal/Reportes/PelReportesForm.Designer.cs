namespace ProyectoFinal.Reportes
{
    partial class PelReportesForm
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
            this.PelCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PelCrystalReportViewer
            // 
            this.PelCrystalReportViewer.ActiveViewIndex = -1;
            this.PelCrystalReportViewer.AutoSize = true;
            this.PelCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PelCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PelCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PelCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PelCrystalReportViewer.Name = "PelCrystalReportViewer";
            this.PelCrystalReportViewer.Size = new System.Drawing.Size(390, 300);
            this.PelCrystalReportViewer.TabIndex = 0;
            this.PelCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // PelReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 300);
            this.Controls.Add(this.PelCrystalReportViewer);
            this.Name = "PelReportesForm";
            this.Text = "Pelicula Reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PelCrystalReportViewer;
    }
}