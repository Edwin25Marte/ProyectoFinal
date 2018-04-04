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

namespace ProyectoFinal.Login
{
    public partial class LogInForm : Form
    {
        ErrorProvider Val = new ErrorProvider();
        public LogInForm()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if(string.IsNullOrWhiteSpace(NombreUsuarioTextBox.Text))
            {
                Val.SetError(NombreUsuarioTextBox, "Llene el campo Nombre de usuario.");
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(PassTextBox.Text))
            {
                Val.SetError(PassTextBox, "Llene el campo contraseña.");
                return false;
            }

            return true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            foreach (Us user in UsuariosBLL.GetListTodo())
            {
                if (user.NombreUsuario.Equals(NombreUsuarioTextBox.Text) &&
                    user.Pass.Equals(PassTextBox.Text))
                {
                    this.Close();
                    new MenuForm().Show();
                    return;
                }
            }

            MessageBox.Show("Este usuario no existe");

        }
    }
}
