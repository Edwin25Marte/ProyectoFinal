namespace ProyectoFinal.Reportes
{
    partial class ActorReporteForm
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
            this.ActCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ActCrystalReportViewer
            // 
            this.ActCrystalReportViewer.ActiveViewIndex = -1;
            this.ActCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ActCrystalReportViewer.Name = "ActCrystalReportViewer";
            this.ActCrystalReportViewer.Size = new System.Drawing.Size(386, 299);
            this.ActCrystalReportViewer.TabIndex = 0;
            this.ActCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ActorReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 299);
            this.Controls.Add(this.ActCrystalReportViewer);
            this.Name = "ActorReporteForm";
            this.Text = "Actor Reporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ActCrystalReportViewer;
    }
}