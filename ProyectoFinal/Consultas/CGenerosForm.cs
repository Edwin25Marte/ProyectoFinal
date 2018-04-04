using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
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
    public partial class CGenerosForm : Form
    {
        Expression<Func<Generos, bool>> filter = x => true;

        public CGenerosForm()
        {
            InitializeComponent();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            switch (CFiltrarComboBox.SelectedIndex)
            {
                case 0:
                    int id = int.Parse(CriterioBusquedaTextBox.Text);
                    filter = (x => x.GeneroId == id && ((x.Fecha >= DesdeDateTimePicker.Value) && (x.Fecha <= HastaDateTimePicker.Value)));
                    break;
                case 1:
                    filter = x => x.Nombre.Contains(CriterioBusquedaTextBox.Text) && ((x.Fecha >= DesdeDateTimePicker.Value) && (x.Fecha <= HastaDateTimePicker.Value));
                    break;
                case 2:
                    DateTime date = DateTime.Parse(CriterioBusquedaTextBox.Text);
                    filter = x => DateTime.Compare(x.Fecha, date) == 0 && ((x.Fecha >= DesdeDateTimePicker.Value) && (x.Fecha <= HastaDateTimePicker.Value));
                    break;
            }
            ConsultaDataGridView.DataSource = GenerosBLL.GetList(filter);
        }
    }
}
