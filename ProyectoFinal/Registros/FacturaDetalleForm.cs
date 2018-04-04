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
    public partial class FacturaDetalleForm : Form
    {
        private List<FactDetalle> Ldetalle = new List<FactDetalle>();
        private ErrorProvider Val = new ErrorProvider();
        private FactDetalle BuscarDet = new FactDetalle();
        private Peli search = new Peli();
        private Client buscar = new Client();
        int rowIndex = -1;
        decimal Total = 0;

        public FacturaDetalleForm()
        {
            InitializeComponent();
        }

        private void FacturaDetalleForm_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(ClienteComboBox.Text))
            {
                Val.SetError(ClienteComboBox, "Seleccione un cliente.");
                return false;
            }

            if (string.IsNullOrEmpty(PeliculaComboBox.Text))
            {
                Val.SetError(PeliculaComboBox, "Seleccione una pelicula.");
                return false;
            }

            if (string.IsNullOrEmpty(ObservacionesTextBox.Text))
            {
                Val.SetError(ObservacionesTextBox, "Llene el campo observaciones.");
                return false;
            }

            if (CantidadNumericUpDown.Value == 0)
            {
                Val.SetError(CantidadNumericUpDown, "Llene el campo cantidad.");
                return false;
            }

            return true;
        }

        public void LlenarCombo()
        {
            List<Client> lista = BLL.ClientesBLL.GetListTodo();
            List<Peli> list = BLL.PeliculasBLL.GetListTodo();

            if (lista != null)
            {
                ClienteComboBox.DataSource = lista;
                ClienteComboBox.DisplayMember = "Nombres";
                ClienteComboBox.ValueMember = "ClienteId";

                if (ClienteComboBox.Items.Count > 0)
                    ClienteComboBox.SelectedIndex = -1;
            }

            if (list != null)
            {
                PeliculaComboBox.DataSource = list;
                PeliculaComboBox.DisplayMember = "Nombre";
                PeliculaComboBox.ValueMember = "PeliculaId";

                if (PeliculaComboBox.Items.Count > 0)
                    PeliculaComboBox.SelectedIndex = -1;
            }
        }

        public void Limpiar()
        {
            FactIdNumericUpDown.Value = 0;
            ClienteComboBox.SelectedIndex = -1;
            PeliculaComboBox.SelectedIndex = -1;
            FDetalleDataGridView.DataSource = null;
            ObservacionesTextBox.Clear();
            CantidadNumericUpDown.Value = 0;
            TotalTextBox.Clear();
        }

        public Fact LlenarClase()
        {
            var Entidad = new Fact();

            Entidad.ClienteId = buscar.ClienteId;
            Entidad.Fecha = FechaDateTimePicker.Value;
            Entidad.Monto = CantidadNumericUpDown.Value * search.Precio;
            Entidad.Observaciones = ObservacionesTextBox.Text;
            Entidad.LFD = Ldetalle;

            return Entidad;
        }

        public void LlenarCampos(Fact Entidad)
        {
            Ldetalle = Entidad.LFD;
            ObservacionesTextBox.Text = Entidad.Observaciones;
            FechaDateTimePicker.Value = Entidad.Fecha;
            FDetalleDataGridView.DataSource = null;
            FDetalleDataGridView.DataSource = Entidad.LFD.ToList();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Fact Fact = BLL.FacturaBLL.Buscar((int)FactIdNumericUpDown.Value);

            if (!Validar())
            {
                MessageBox.Show("Llene los campos vacios.");
            }
            else
            {
                if (Fact == null)
                {
                    if (BLL.FacturaBLL.Guardar(LlenarClase()))
                        MessageBox.Show("Se ha guardado el detalle");
                    else
                        MessageBox.Show("No se pudo guardar el detalle");

                }
                else
                {
                    if (BLL.FacturaBLL.Modificar(LlenarClase()))
                        MessageBox.Show("Se ha modificado el detalle.");
                    else
                        MessageBox.Show("No se pudo modificar el detalle.");
                }
            }
            
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BLL.FacturaBLL.Eliminar((int)FactIdNumericUpDown.Value))
                MessageBox.Show("Se ha eliminado la factura.");
            else
                MessageBox.Show("No se pudo eliminar la factura.");

            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Fact Buscar = BLL.FacturaBLL.Buscar((int)FactIdNumericUpDown.Value);

            if (Buscar != null)
            {
                LlenarCampos(Buscar);
                
                FDetalleDataGridView.Columns["FactDetalleId"].Visible = false;
                FDetalleDataGridView.Columns["FacturaId"].Visible = false;
                FDetalleDataGridView.Columns["PeliculaId"].Visible = false;

                MessageBox.Show("Se ha encotrado la factura.");
            }
            else
            {
                MessageBox.Show("La factura no existe.");
                FactIdNumericUpDown.Value = 0;
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                search = BLL.PeliculasBLL.Buscar(int.Parse(PeliculaComboBox.SelectedValue.ToString()));
                buscar = BLL.ClientesBLL.Buscar(int.Parse(ClienteComboBox.SelectedValue.ToString()));

                Ldetalle.Add(new FactDetalle(
                 0,
                 (int)FactIdNumericUpDown.Value,
                 search.PeliculaId,
                 buscar.Nombres,
                 search.Nombre,
                 (int)CantidadNumericUpDown.Value,
                 search.Precio,
                 (int)CantidadNumericUpDown.Value * search.Precio
                 ));
                Total += (int)CantidadNumericUpDown.Value * search.Precio;
                TotalTextBox.Text = Total.ToString();
            }
            else
            {
                Ldetalle[rowIndex].Cliente = ClienteComboBox.Text;
                Ldetalle[rowIndex].Pelicula = PeliculaComboBox.Text;
                Ldetalle[rowIndex].Cantidad = (int)CantidadNumericUpDown.Value;
            }

            Console.WriteLine(Ldetalle.Count);


            FDetalleDataGridView.DataSource = Ldetalle.ToList();
            FDetalleDataGridView.Columns["FactDetalleId"].Visible = false;
            FDetalleDataGridView.Columns["FacturaId"].Visible = false;
            FDetalleDataGridView.Columns["PeliculaId"].Visible = false;
        }

        private void FDetalleDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            ClienteComboBox.Text = Ldetalle[e.RowIndex].Cliente;
            PeliculaComboBox.Text = Ldetalle[e.RowIndex].Pelicula;
            CantidadNumericUpDown.Value = Ldetalle[e.RowIndex].Cantidad;

        }
    }
}
