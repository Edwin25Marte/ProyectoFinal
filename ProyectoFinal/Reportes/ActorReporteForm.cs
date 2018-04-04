using CrystalDecisions.CrystalReports.Engine;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.Reportes
{
    public partial class ActorReporteForm : Form
    {
        List<Actores> lista;
        public ActorReporteForm(List<Actores> list)
        {
            InitializeComponent();
            lista = list;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:/Users/Edwin_Marte/Desktop/ProyectoFinal/ProyectoFinal/Reportes/ActorCrystalTeport.rpt");
            report.SetDataSource(lista);

            ActCrystalReportViewer.ReportSource = report;
            ActCrystalReportViewer.Refresh();
        }
    }
}
