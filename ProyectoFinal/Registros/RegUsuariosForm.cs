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
    public partial class RegUsuariosForm : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        public RegUsuariosForm()
        {
            InitializeComponent();
        }

        private void RegUsuariosForm_Load(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Llene el campo Nombre.");
                return false;
            }

            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Llene el campo Contraseña.");
                return false;
            }

            if (string.IsNullOrEmpty(TelefonoTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Llene el campo telefono.");
                return false;
            }

            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Llene el campo Direccion.");
                return false;
            }

            return true;
        }

        public void Limpiar()
        {
            NombreTextBox.Clear();
            NombreUsTextBox.Clear();
            PasswordTextBox.Clear();
            TelefonoTextBox.Clear();
            DireccionTextBox.Clear();
            UsuarioIdNumericUpDown.Value = 0;
        }

        public Us LlenarClase()
        {
            var lleno = new Us();

            lleno.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
            lleno.Nombre = NombreTextBox.Text;
            lleno.NombreUsuario = NombreUsTextBox.Text;
            lleno.Pass = PasswordTextBox.Text;
            lleno.Fecha = DateTime.Now;
            lleno.Telefono = TelefonoTextBox.Text;
            lleno.Direccion = DireccionTextBox.Text;

            return lleno;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Us guardo = BLL.UsuariosBLL.Buscar((int)UsuarioIdNumericUpDown.Value);

            if (!Validar())
            {
                MessageBox.Show("Llene los campos.");
            }
            else
            {
                guardo = LlenarClase();
                if (guardo.UsuarioId != 0)
                {
                    BLL.UsuariosBLL.Modificar(guardo);
                    MessageBox.Show("Se ha modificado el usuario.");

                }
                else
                {
                    BLL.UsuariosBLL.Guardar(guardo);
                    MessageBox.Show("Se ha guardado el usuario.");
                }
                Limpiar();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BLL.UsuariosBLL.Eliminar((int)UsuarioIdNumericUpDown.Value))
                MessageBox.Show("Se elimino el usuario.");
            else
                MessageBox.Show("No se pudo eliminar el usuario.");

            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Us busca = BLL.UsuariosBLL.Buscar((int)UsuarioIdNumericUpDown.Value);

            if (busca != null)
            {
                NombreTextBox.Text = busca.Nombre;
                NombreUsTextBox.Text = busca.NombreUsuario;
                PasswordTextBox.Text = busca.Pass;
                TelefonoTextBox.Text = busca.Telefono;
                DireccionTextBox.Text = busca.Direccion;

                MessageBox.Show("Se encontro el usuario.");
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
                UsuarioIdNumericUpDown.Value = 0;
            }
        }
    }
}
