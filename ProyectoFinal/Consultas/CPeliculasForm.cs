﻿using ProyectoFinal.BLL;
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
    public partial class CPeliculasForm : Form
    {
        Expression<Func<Peli, bool>> filter = x => true;

        public CPeliculasForm()
        {
            InitializeComponent();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            switch (CFiltrarComboBox.SelectedIndex)
            {
                case 0:
                    int id = int.Parse(CriterioBusquedaTextBox.Text);
                    filter = (x => x.PeliculaId == id && ((x.FechaSalida >= DesdeDateTimePicker.Value) && (x.FechaSalida <= HastaDateTimePicker.Value)));
                    break;
                case 1:
                    filter = x => x.Nombre.Contains(CriterioBusquedaTextBox.Text) && ((x.FechaSalida >= DesdeDateTimePicker.Value) && (x.FechaSalida <= HastaDateTimePicker.Value));
                    break;
                case 2:
                    DateTime date = DateTime.Parse(CriterioBusquedaTextBox.Text);
                    filter = x => DateTime.Compare(x.FechaSalida, date) == 0 && ((x.FechaSalida >= DesdeDateTimePicker.Value) && (x.FechaSalida <= HastaDateTimePicker.Value));
                    break;
            }
            ConsultaDataGridView.DataSource = PeliculasBLL.GetList(filter);
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            new PelReportesForm(PeliculasBLL.GetList(filter)).Show();
        }
    }
}
