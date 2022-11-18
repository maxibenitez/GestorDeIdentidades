using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeIdentidades.Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click al boton de Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginAction();
        }

        /// <summary>
        /// Click al boton de registro, aparece el Form de registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new Registro();
            myForm.Show();
        }

        /// <summary>
        /// Logica del Login
        /// </summary>
        private void LoginAction()
        {
            string usuario = InputUsuario.Text;
            string password = InputContrasena.Text;
        }

        private void contrasenaOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new RecuperarContrasena();
            myForm.Show();
        }
    }
}
