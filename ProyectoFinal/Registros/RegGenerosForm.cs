using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.Registros
{
    public partial class RegGenerosForm : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();

        public RegGenerosForm()
        {
            InitializeComponent();
        }

        private void RegGenerosForm_Load(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Llene el campo Nombre.");
                return false;
            }

            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                errorProvider1.SetError(DescripcionTextBox, "Llene el campo descripcion.");
                return false;
            }

            return true;
        }

        public Generos LlenarClase()
        {
            var lleno = new Generos();

            lleno.GeneroId = (int)GeneroIdNumericUpDown.Value;
            lleno.Nombre = NombreTextBox.Text;
            lleno.Fecha = DateTime.Now;
            lleno.Descripcion = DescripcionTextBox.Text;

            return lleno;
        }

        public void Limpiar()
        {
            GeneroIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Generos guardo = BLL.GenerosBLL.Buscar((int)GeneroIdNumericUpDown.Value);

            if (!Validar())
            {
                MessageBox.Show("Llene los campos.");
            }
            else
            {
                guardo = LlenarClase();
                if (guardo.GeneroId != 0)
                {
                    BLL.GenerosBLL.Modificar(guardo);
                    MessageBox.Show("Se ha modificado el genero.");

                }
                else
                {
                    BLL.GenerosBLL.Guardar(guardo);
                    MessageBox.Show("Se ha guardado el genero.");
                }
                Limpiar();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BLL.GenerosBLL.Eliminar((int)GeneroIdNumericUpDown.Value))
                MessageBox.Show("Se elimino el genero.");
            else
                MessageBox.Show("No se pudo eliminar el genero.");

            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Generos busca = BLL.GenerosBLL.Buscar((int)GeneroIdNumericUpDown.Value);

            if (busca != null)
            {
                NombreTextBox.Text = busca.Nombre;
                DescripcionTextBox.Text = busca.Descripcion;

                MessageBox.Show("Se encontro el genero.");
            }
            else
            {
                MessageBox.Show("El genero no existe.");
                GeneroIdNumericUpDown.Value = 0;
            }
        }
    }
}
