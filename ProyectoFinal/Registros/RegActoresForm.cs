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
    public partial class RegActoresForm : Form
    {
        private ErrorProvider Val = new ErrorProvider();

        public RegActoresForm()
        {
            InitializeComponent();
        }

        private void RegActoresForm_Load(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                Val.SetError(NombreTextBox, "Llene el campo Nombre.");
                return false;
            }
            return true;
        }

        public Actores LlenarClase()
        {
            var Entidad = new Actores();

            Entidad.ActorID = (int)ActorIdNumericUpDown.Value;
            Entidad.Nombre = NombreTextBox.Text;
            Entidad.FechaDebut = FechaDebutDateTimePicker.Value;
            Entidad.FechaNacimiento = NacimientoDateTimePicker.Value;

            return Entidad;
        }

        public void LlenarCampos(Actores Entidad)
        {
            NombreTextBox.Text = Entidad.Nombre;
            FechaDebutDateTimePicker.Value = Entidad.FechaDebut;
            NacimientoDateTimePicker.Value = Entidad.FechaNacimiento;
        }

        public void Limpiar()
        {
            ActorIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            FechaDebutDateTimePicker.Value = DateTime.Now;
            NacimientoDateTimePicker.Value = DateTime.Now;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Actores guardo = BLL.ActorBLL.Buscar((int)ActorIdNumericUpDown.Value);

            if (!Validar())
            {
                MessageBox.Show("Llene los campos vacios.");
            }
            else
            {
                guardo = LlenarClase();
                if (guardo.ActorID != 0)
                {
                    BLL.ActorBLL.Modificar(guardo);
                    MessageBox.Show("Se ha modificado el actor.");

                }
                else
                {
                    BLL.ActorBLL.Guardar(guardo);
                    MessageBox.Show("Se ha guardado el actor.");
                }
                Limpiar();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BLL.ActorBLL.Eliminar((int)ActorIdNumericUpDown.Value))
                MessageBox.Show("Se elimino el actor.");
            else
                MessageBox.Show("No se pudo eliminar el actor.");

            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Actores Buscar = BLL.ActorBLL.Buscar((int)ActorIdNumericUpDown.Value);

            if (Buscar != null)
            {
                LlenarCampos(Buscar);
                MessageBox.Show("Se encontro el actor.");
            }
            else
            {
                MessageBox.Show("El actor no existe.");
                ActorIdNumericUpDown.Value = 0;
            }
        }
    }
}
