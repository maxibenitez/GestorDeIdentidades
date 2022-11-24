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
        private RecuperarContrasenaLogic _recuperarcontra = new RecuperarContrasenaLogic();
        public List<Preguntas> preguntas = new PreguntasLogic().GetPreguntas();
        public RecuperarContrasena()
        {
            InitializeComponent();
            foreach (Preguntas pregunta in preguntas)
            {
                comboPreguntas.Items.Add(pregunta.Pregunta);
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            int usuario = Convert.ToInt32(usuarioInput.Value);
            string preguntaInput = comboPreguntas.Text;
            string respuesta = respuestaInput.Text;
            int preguntaID = 0;

            if ( usuario == 0 || preguntaInput == "" || respuesta == "")
            {
                //error
            }
            else
            {
                foreach (Preguntas pregunta in preguntas)
                {
                    if (pregunta.Pregunta == preguntaInput)
                    {
                        preguntaID = pregunta.Preg_id;
                    }
                }

                if (_recuperarcontra.checkPersonaPregunta(usuario, preguntaID, respuesta))
                {
                    label6.Text = "exito";
                }
                else
                {
                    label6.Text = "error";
                }
            }
        }
    }
}
