using ProyectoFinal.Consultas;
using ProyectoFinal.Registros;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegClientesForm().Show();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegActoresForm().Show();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegGenerosForm().Show();
        }

        private void películasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegPeliculasForm().Show();
        }

        private void FacturaDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FacturaDetalleForm().Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegUsuariosForm().Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CUsuariosForm().Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CClientesForm().Show();
        }

        private void actoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CActoresForm().Show();
        }

        private void generosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CGenerosForm().Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CPeliculasForm().Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CFacturaForm().Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
