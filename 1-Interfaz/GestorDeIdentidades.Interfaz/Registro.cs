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
    public partial class Registro : Form
    {
        private readonly RegistroLogic _registroLogic = new RegistroLogic();

        public Registro()
        {
            InitializeComponent();

            List<Preguntas> preguntas = _registroLogic.GetPreguntas();

            foreach (Preguntas pregunta in preguntas)
            {
                InputPregunta.Items.Add($"{pregunta.Preg_id}. {pregunta.Pregunta}");
            }
        }

        private void BotonRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse();
        }

        private void Registrarse()
        {
            string nombre = InputNombre.Text;
            string apellido = InputApellido.Text;
            string direccion = InputDireccion.Text;
            string ciudad = InputCiudad.Text;
            string departamento = InputDepartamento.Text;
            string[] pregunta = InputPregunta.Text.Split(new char[] { '.' });
            int pregId = Int32.Parse(pregunta[0]);
            string respuesta = InputRespuesta.Text;
            string contrasena = InputContrasena.Text;

            if ( contrasena == "" || nombre == "" || apellido == "" || direccion == "" || ciudad == "" || departamento == "" || respuesta == "")
            {
                errorMessage.Text = "Ha ocurrido un problema!";
            }
            else
            {
                RegistroPersona persona = new RegistroPersona()
                {
                    Nombres = nombre,
                    Apellidos = apellido,
                    Direccion = direccion,
                    Ciudad = ciudad,
                    Departamento = departamento,
                    Password = contrasena,
                    Preg_id = pregId,
                    Respuesta = respuesta
                };

                bool resp = _registroLogic.RegistrarPersona(persona);

                if (resp)
                {
                    this.Hide();
                    var login = new Login();
                    login.Show();
                }
                else
                {
                    errorMessage.Text = "Ha ocurrido un problema!";
                }
                
            }
        }
    }
}
