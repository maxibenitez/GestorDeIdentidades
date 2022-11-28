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
        public String persona;
        public String app;
        public String rolneg;
        public String fechasol;
        public String estado;

        public EditarPermiso(String user_id, String persona, String app, String rolneg, String fechasol, String estado)
        {
            InitializeComponent();
            var userid = user_id;
            labelPersona.Text = persona;
            labelAplicativo.Text = app;
            labelRolNeg.Text = rolneg;
            labelFechaSol.Text = fechasol;
            estados.Text = estado;
            estados.Items.Add("Pendiente");
            estados.Items.Add("Activo");
            estados.Items.Add("Denegado");
            this.user_id = Int32.Parse(user_id);
        }

        private void actualizarPermiso_Click(object sender, EventArgs e)
        {
            ActualizarPermiso();
        }

        private void ActualizarPermiso()
        {
            
            string estado = estados.Text;

            bool result = _gestorLogic.EditarPermiso(this.user_id, estado);

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
