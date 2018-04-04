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
    public partial class RegPeliculasForm : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        private Actores search = new Actores();
        private Generos buscar = new Generos();
        private List<GenAct> LGActs = new List<GenAct>();

        public RegPeliculasForm()
        {
            InitializeComponent();
        }

        private void RegPeliculasForm_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Llene el campo Nombre.");
                return false;
            }

            if (PrecioNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(PrecioNumericUpDown, "Llene el campo Precio.");
                return false;
            }

            if (string.IsNullOrEmpty(SipnosisTextBox.Text))
            {
                errorProvider1.SetError(SipnosisTextBox, "Llene el campo sipnosis.");
                return false;
            }

            return true;
        }

        public Peli LlenarClase()
        {
            var lleno = new Peli();

            lleno.PeliculaId = (int)PeliculaIdNumericUpDown.Value;
            lleno.Nombre = NombreTextBox.Text;
            lleno.Precio = PrecioNumericUpDown.Value;
            lleno.FechaSalida = FechaSalDateTimePicker.Value;
            lleno.Sipnosis = SipnosisTextBox.Text;
            lleno.LGA = LGActs;

            return lleno;
        }

        public void Limpiar()
        {
            PeliculaIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            PrecioNumericUpDown.Value = 0;
            FechaSalDateTimePicker.Value = DateTime.Now;
            PelDataGridView.DataSource = null;
            SipnosisTextBox.Clear();
        }

        public void LlenarCombo()
        {
            List<Actores> lista = BLL.ActorBLL.GetListTodo();
            ActoresComboBox.DataSource = lista;
            ActoresComboBox.DisplayMember = "Nombre";
            ActoresComboBox.ValueMember = "ActorID";

            if (ActoresComboBox.Items.Count > 0)
                ActoresComboBox.SelectedIndex = -1;

            List<Generos> list = BLL.GenerosBLL.GetListTodo();
            GenerosComboBox.DataSource = list;
            GenerosComboBox.DisplayMember = "Nombre";
            GenerosComboBox.ValueMember = "GeneroID";

            if (GenerosComboBox.Items.Count > 0)
                GenerosComboBox.SelectedIndex = -1;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Peli guardo = BLL.PeliculasBLL.Buscar((int)PeliculaIdNumericUpDown.Value);

            if (!Validar())
            {
                MessageBox.Show("Llene los campos.");
            }
            else
            {
                guardo = LlenarClase();
                if (guardo.PeliculaId != 0)
                {
                    BLL.PeliculasBLL.Modificar(guardo);
                    MessageBox.Show("Se ha modificado la pelicula.");

                }
                else
                {
                    BLL.PeliculasBLL.Guardar(guardo);
                    MessageBox.Show("Se ha guardado la pelicula.");
                }
                Limpiar();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BLL.PeliculasBLL.Eliminar((int)PeliculaIdNumericUpDown.Value))
                MessageBox.Show("Se elimino la pelicula.");
            else
                MessageBox.Show("No se pudo eliminar la pelicula.");

            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Peli busca = BLL.PeliculasBLL.Buscar((int)PeliculaIdNumericUpDown.Value);

            if (busca != null)
            {
                NombreTextBox.Text = busca.Nombre;
                PrecioNumericUpDown.Value = busca.Precio;
                FechaSalDateTimePicker.Value = busca.FechaSalida;
                SipnosisTextBox.Text = busca.Sipnosis;

                PelDataGridView.DataSource = null;
                PelDataGridView.DataSource = busca.LGA.ToList();
                PelDataGridView.Columns["GAId"].Visible = false;
                PelDataGridView.Columns["ActorId"].Visible = false;
                PelDataGridView.Columns["GeneroId"].Visible = false;

                MessageBox.Show("Se encontro el cliente.");
            }
            else
            {
                MessageBox.Show("El cliente no existe.");
                PeliculaIdNumericUpDown.Value = 0;
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            string Act = ActoresComboBox.SelectedValue.ToString();
            search = BLL.ActorBLL.Buscar(int.Parse(Act));
            string Gen = GenerosComboBox.SelectedValue.ToString();
            buscar = BLL.GenerosBLL.Buscar(int.Parse(Gen));

            LGActs.Add(new GenAct(
                 0,
                 search.ActorID,
                 buscar.GeneroId,
                 search.Nombre,
                 buscar.Nombre
                 ));

            PelDataGridView.DataSource = null;
            PelDataGridView.DataSource = LGActs.ToList();
            PelDataGridView.Columns["GAId"].Visible = false;
            PelDataGridView.Columns["ActorId"].Visible = false;
            PelDataGridView.Columns["GeneroId"].Visible = false;
        }
    }
}
