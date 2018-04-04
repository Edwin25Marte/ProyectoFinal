namespace ProyectoFinal.Reportes
{
    partial class ClientesReporteForm
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
            this.CCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CCrystalReportViewer
            // 
            this.CCrystalReportViewer.ActiveViewIndex = -1;
            this.CCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CCrystalReportViewer.Name = "CCrystalReportViewer";
            this.CCrystalReportViewer.Size = new System.Drawing.Size(401, 313);
            this.CCrystalReportViewer.TabIndex = 0;
            this.CCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ClientesReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 313);
            this.Controls.Add(this.CCrystalReportViewer);
            this.Name = "ClientesReporteForm";
            this.Text = "Reporte clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CCrystalReportViewer;
    }
}