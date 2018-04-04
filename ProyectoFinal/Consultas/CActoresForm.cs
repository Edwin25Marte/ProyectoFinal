using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using ProyectoFinal.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.Consultas
{
    public partial class CActoresForm : Form
    {
        Expression<Func<Actores, bool>> filter = x => true;

        public CActoresForm()
        {
            InitializeComponent();
        }

        private void CActoresForm_Load(object sender, EventArgs e)
        {

        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            switch (CFiltrarComboBox.SelectedIndex)
            {
                case 0:
                    int id = int.Parse(CriterioBusquedaTextBox.Text);
                    filter = (x => x.ActorID == id && ((x.FechaDebut >= DesdeDateTimePicker.Value) && (x.FechaDebut <= HastaDateTimePicker.Value)));
                    break;
                case 1:
                    filter = x => x.Nombre.Contains(CriterioBusquedaTextBox.Text) && ((x.FechaDebut >= DesdeDateTimePicker.Value) && (x.FechaDebut <= HastaDateTimePicker.Value));
                    break;
                case 2:
                    DateTime date = DateTime.Parse(CriterioBusquedaTextBox.Text);
                    filter = x => DateTime.Compare(x.FechaDebut, date) == 0 && ((x.FechaDebut >= DesdeDateTimePicker.Value) && (x.FechaDebut <= HastaDateTimePicker.Value));
                    break;
            }
            ConsultaDataGridView.DataSource = ActorBLL.GetList(filter);
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            new ActorReporteForm(ActorBLL.GetList(filter)).Show();
        }
    }
}
