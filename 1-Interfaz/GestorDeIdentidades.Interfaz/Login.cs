using GestorDeIdentidades.Logic;
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
        private readonly LoginLogic _loginLogic = new LoginLogic();

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginAction();
            var myFrom = new GestorPermisos();
            myFrom.Show();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var myForm = new Registro();
            myForm.Show();
        }

        private void LoginAction()
        {
            string usuario = InputUsuario.Text;
            string password = InputContrasena.Text;
        }

        private void contrasenaOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var myForm = new RecuperarContrasena();
            myForm.Show();
        }
    }
}
