using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class RegClientesForm : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        public RegClientesForm()
        {
            InitializeComponent();
        }

        private void RegClientesForm_Load(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombresTextBox.Text))
            {
                errorProvider1.SetError(NombresTextBox, "Llene el campo Nombre.");
                return false;
            }

            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                errorProvider1.SetError(DireccionTextBox, "Llene el campo direccion.");
                return false;
            }
            return true;

        }

        public Client LlenarClase()
        {
            var lleno = new Client();

            lleno.ClienteId = (int)ClienteIdNumericUpDown.Value;
            lleno.Nombres = NombresTextBox.Text;
            lleno.Apellidos = ApellidosTextBox.Text;
            lleno.Direccion = DireccionTextBox.Text;
            lleno.FechaNacimiento = NacimientoDateTimePicker.Value;
            lleno.FechaReg = DateTime.Now;
            lleno.Telefono = TelefonoTextBox.Text;
            lleno.Celular = CelularTextBox.Text;
            lleno.Email = EmailTextBox.Text;

            return lleno;
        }

        public void Limpiar()
        {
            ClienteIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            ApellidosTextBox.Clear();
            NacimientoDateTimePicker.Value = DateTime.Now;
            DireccionTextBox.Clear();
            TelefonoTextBox.Clear();
            CelularTextBox.Clear();
            EmailTextBox.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Client guardo = BLL.ClientesBLL.Buscar((int)ClienteIdNumericUpDown.Value);

            if (!Validar())
            {
                MessageBox.Show("Llene los campos.");
            }
            else
            {
                guardo = LlenarClase();
                if (guardo.ClienteId != 0)
                {
                    BLL.ClientesBLL.Modificar(guardo);
                    MessageBox.Show("Se ha modificado el cliente");

                }
                else
                {
                    BLL.ClientesBLL.Guardar(guardo);
                    MessageBox.Show("Se ha guardado el cliente.");
                }
                Limpiar();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BLL.ClientesBLL.Eliminar((int)ClienteIdNumericUpDown.Value))
                MessageBox.Show("Se elimino el cliente.");
            else
                MessageBox.Show("No se pudo eliminar el clinete.");

            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Client busca = BLL.ClientesBLL.Buscar((int)ClienteIdNumericUpDown.Value);

            if (busca != null)
            {
                NombresTextBox.Text = busca.Nombres;
                ApellidosTextBox.Text = busca.Apellidos;
                NacimientoDateTimePicker.Value = busca.FechaNacimiento;
                DireccionTextBox.Text = busca.Direccion;
                TelefonoTextBox.Text = busca.Telefono;
                CelularTextBox.Text = busca.Celular;
                EmailTextBox.Text = busca.Email;

                MessageBox.Show("Se encontro el cliente.");
            }
            else
            {
                MessageBox.Show("El cliente no existe.");
                ClienteIdNumericUpDown.Value = 0;
            }
        }
    }
}
