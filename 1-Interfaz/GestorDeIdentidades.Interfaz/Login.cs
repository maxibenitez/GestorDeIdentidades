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
            InputContrasena.PasswordChar = ' ';
        }

        private void BotonLogin_Click(object sender, EventArgs e)
        {
            LoginAction();
        }

        private void LoginAction()
        {
            string usuario = InputUsuario.Text;
            string password = InputContrasena.Text;
            bool isAdmin;

            int user_id = _loginLogic.GetPersonaId(usuario);

            if (user_id != 0)
            {
                bool resp = _loginLogic.LoginPersona(user_id, password, out isAdmin);

                if (resp)
                {
                    if (isAdmin)
                    {
                        this.Hide();
                        var gestor = new Gestor();
                        gestor.Show();
                    }
                    else
                    {
                        this.Hide();
                        var usermenu = new UserMenu(user_id);
                        usermenu.Show();        
                    }
                }
                else
                {
                    errorMessage.Text = "Usuario o contraseña incorrecta!";
                }
            }
            else
            {
                errorMessage.Text = "Usuario o contraseña incorrecta!";
            }
        }

        private void contrasenaOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var myForm = new RecuperarContrasena();
            myForm.Show();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var myForm = new Registro();
            myForm.Show();
        }
    }
}
