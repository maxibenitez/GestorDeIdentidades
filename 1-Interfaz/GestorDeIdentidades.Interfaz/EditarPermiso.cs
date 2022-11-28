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
        private int userId;

        public EditarPermiso(Permiso permiso)
        {
            InitializeComponent();
            userId = permiso.User_id;
            nombre.Text = permiso.NombrePersona;
            aplicativo.Text = permiso.NombreApp;
            rolNegocio.Text = permiso.DescripcionRolNeg;
            fecha.Text = permiso.Fecha_solicitud.ToShortDateString();
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

            bool result = _gestorLogic.EditarPermiso(userId, estado);

            if (result)
            {
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
