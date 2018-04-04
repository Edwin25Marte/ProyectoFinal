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
    public partial class CClientesForm : Form
    {
        Expression<Func<Client, bool>> filter = x => true;

        public CClientesForm()
        {
            InitializeComponent();
        }

        private void CClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            switch (CFiltrarComboBox.SelectedIndex)
            {
                case 0:
                    int id = int.Parse(CriterioBusquedaTextBox.Text);
                    filter = (x => x.ClienteId == id && ((x.FechaReg >= DesdeDateTimePicker.Value) && (x.FechaReg <= HastaDateTimePicker.Value)));
                    break;
                case 1:
                    filter = x => x.Nombres.Contains(CriterioBusquedaTextBox.Text) && ((x.FechaReg >= DesdeDateTimePicker.Value) && (x.FechaReg <= HastaDateTimePicker.Value));
                    break;
                case 2:
                    DateTime date = DateTime.Parse(CriterioBusquedaTextBox.Text);
                    filter = x => DateTime.Compare(x.FechaReg, date) == 0 && ((x.FechaReg >= DesdeDateTimePicker.Value) && (x.FechaReg <= HastaDateTimePicker.Value));
                    break;
            }
            ConsultaDataGridView.DataSource = ClientesBLL.GetList(filter);
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            new ClientesReporteForm(ClientesBLL.GetList(filter)).Show();
        }
    }
}
