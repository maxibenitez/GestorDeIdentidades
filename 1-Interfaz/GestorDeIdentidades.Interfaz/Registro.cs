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

            List<Aplicativo> aplicativos = _registroLogic.GetAplicativos();

            foreach (Aplicativo aplicativo in aplicativos)
            {
                InputAplicativo.Items.Add($"{aplicativo.App_id}. {aplicativo.NombreApp}");
            }

            List<RolNegocio> roles = _registroLogic.GetRolesNegocio();

            foreach (RolNegocio rol in roles)
            {
                InputRol.Items.Add($"{rol.Rol_neg_id}. {rol.Descripcion_rol_neg}");
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
            string[] aplicativo = InputAplicativo.Text.Split(new char[] { '.' });
            int appId = Int32.Parse(aplicativo[0]);
            string[] rol = InputRol.Text.Split(new char[] { '.' });
            int rolId = Int32.Parse(rol[0]);

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
                    Respuesta = respuesta,
                    App_id = appId,
                    Rol_neg_id = rolId
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
