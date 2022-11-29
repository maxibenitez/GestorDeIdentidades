using GestorDeIdentidades.Logic;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeIdentidades.Interfaz
{
    public partial class EditarPermiso : Form
    {
        private readonly GestorLogic _gestorLogic = new GestorLogic();
        public int user_id;
        public int app_id;

        public EditarPermiso(Permiso permiso)
        {
            InitializeComponent();
            user_id = permiso.User_id;
            nombre.Text = permiso.NombrePersona;
            this.app_id = permiso.App_id;
            aplicativo.Text = permiso.NombreApp;
            rolNegocio.Text = permiso.Descripcion_rol_neg;
            fecha.Text = permiso.Fecha_solicitud.ToShortDateString();
            estados.Text = permiso.Estado;
            estados.Items.Add("Pendiente");
            estados.Items.Add("Activo");
            estados.Items.Add("Denegado");
        }

        private void actualizarPermiso_Click(object sender, EventArgs e)
        {
            ActualizarPermiso();
        }

        private void ActualizarPermiso()
        {
            
            string estado = estados.Text;

            bool result = _gestorLogic.EditarPermiso(this.user_id, this.app_id, estado);

            if (result)
            {
                var myForm = new GestorPermisos();
                myForm.Show();
                this.Hide();
            }
            else
            {
                errorMessage.Text = "Ha ocurrido un problema!";
            }
        }

        private void estados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
