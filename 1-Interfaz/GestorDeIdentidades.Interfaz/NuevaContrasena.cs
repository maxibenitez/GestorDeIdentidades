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
    public partial class NuevaContrasena : Form
    {
        private readonly LoginLogic _loginLogic = new LoginLogic();
        private int id;

        public NuevaContrasena(int user_id)
        {
            InitializeComponent();
            id = user_id;
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            ActualizarContraseña();
        }

        private void ActualizarContraseña()
        {
            string nuevaContra = contraInput.Text;

            bool contraValida = _loginLogic.CheckContraseña(id, nuevaContra);

            if (contraValida)
            {
                errorMessage.Text = "La contraseña no puede ser igual a la anterior!";
            }
            else
            {
                bool resp = _loginLogic.CambiarContraseña(id, nuevaContra);

                if (resp)
                {
                    this.Hide();
                    var login = new Login();
                    login.Show();
                }
                else
                {
                    errorMessage.Text = "Ha ocurrido un error!";
                }
            }
        }
    }
}
