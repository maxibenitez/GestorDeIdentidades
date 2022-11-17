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
        public Registro()
        {
            InitializeComponent();
        }

        private void BotonRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse();
        }

        private void Registrarse()
        {
            string usuario = InputUsuario.Text;
            string contrasena = InputContrasena.Text;
            string nombre = InputNombre.Text;
            string apellido = InputApellido.Text;
            string direccion = InputDireccion.Text;
            string ciudad = InputCiudad.Text;
            string departamento = InputDepartamento.Text;
            string respuesta = InputRespuesta.Text;

            if (usuario == "" || contrasena == "" || nombre == "" || apellido == "" || direccion == "" || ciudad == "" || departamento == "" || respuesta == "")
            {
                label10.Text = "error";
            }
            else
            {
                label10.Text = "cheto";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
