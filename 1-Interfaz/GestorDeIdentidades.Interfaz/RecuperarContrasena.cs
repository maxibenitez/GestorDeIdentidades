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
    

    public partial class RecuperarContrasena : Form
    {
        private readonly LoginLogic _loginLogic = new LoginLogic();

        public RecuperarContrasena()
        {
            InitializeComponent();

            errorCampos.Text = "";
            errorRespuesta.Text = "";
            errorUsuario.Text = "";

            List<Preguntas> preguntas = _loginLogic.GetPreguntas();

            foreach (Preguntas pregunta in preguntas)
            {
                InputPregunta.Items.Add($"{pregunta.Preg_id}. {pregunta.Pregunta}");
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = usuarioInput.Text;
            string respuesta = respuestaInput.Text;
            string[] pregunta = InputPregunta.Text.Split(new char[] { '.' });

            errorCampos.Text = "";
            errorRespuesta.Text = "";
            errorUsuario.Text = "";

            if ( usuario == "" || pregunta.Length == 0 || respuesta == "")
            {
                errorCampos.Text = "Debe completar todos los campos!";
            }
            else
            {
                int pregId = Int32.Parse(pregunta[0]);
                int user_id = _loginLogic.GetPersonaId(usuario);

                if(user_id != 0)
                {
                    if (_loginLogic.CheckPersonaPregunta(user_id, pregId, respuesta))
                    {
                        this.Hide();
                        var nuevaContrasena = new NuevaContrasena(user_id);
                        nuevaContrasena.Show();
                    }
                    else
                    {
                        errorRespuesta.Text = "Respuesta incorrecta!";
                    }
                }
                else
                {
                    errorUsuario.Text = "Usuario incorrecto!";
                }
                
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }
    }
}
