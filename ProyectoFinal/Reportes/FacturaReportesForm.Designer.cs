namespace ProyectoFinal.Reportes
{
    partial class FacturaReportesForm
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
            this.FactCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FactCrystalReportViewer
            // 
            this.FactCrystalReportViewer.ActiveViewIndex = -1;
            this.FactCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FactCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FactCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FactCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.FactCrystalReportViewer.Name = "FactCrystalReportViewer";
            this.FactCrystalReportViewer.Size = new System.Drawing.Size(425, 301);
            this.FactCrystalReportViewer.TabIndex = 0;
            this.FactCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FacturaReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 301);
            this.Controls.Add(this.FactCrystalReportViewer);
            this.Name = "FacturaReportesForm";
            this.Text = "Factura Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FactCrystalReportViewer;
    }
}