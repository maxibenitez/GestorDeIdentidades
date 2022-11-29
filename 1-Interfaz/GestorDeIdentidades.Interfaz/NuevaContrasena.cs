using GestorDeIdentidades.Logic;
using GestorDeIdentidades.Models;
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

            errorCampos.Text = "";
            errorContra.Text = "";
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            ActualizarContraseña();
        }

        private void ActualizarContraseña()
        {
            errorCampos.Text = "";
            errorContra.Text = "";

            string nuevaContra = contraInput.Text;

            bool contraValida = _loginLogic.CheckContraseña(id, nuevaContra);

            if (nuevaContra == "")
            {
                errorCampos.Text = "Debe ingresar una contraseña!";
            }
            else
            {
                if (contraValida)
                {
                    errorContra.Text = "La contraseña no puede ser igual a la anterior!";
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
                        errorContra.Text = "Ha ocurrido un error!";
                    }
                }
            }
        }
    }
}
