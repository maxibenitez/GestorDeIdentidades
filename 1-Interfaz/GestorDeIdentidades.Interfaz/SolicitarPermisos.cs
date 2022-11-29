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
    public partial class SolicitarPermisos : Form
    {
        private readonly RegistroLogic _registroLogic = new RegistroLogic();
        private readonly PermisosLogic _permisosLogic = new PermisosLogic();
        private int user_id;
        public SolicitarPermisos(int user_id)
        {
            InitializeComponent();
            this.user_id= user_id;

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

        private void botonSolicitar_Click(object sender, EventArgs e)
        {
            string[] aplicativo = InputAplicativo.Text.Split('.');
            int appId = Int32.Parse(aplicativo[0]);
            string[] rol = InputRol.Text.Split('.');
            int rolId = Int32.Parse(rol[0]);

            if(_permisosLogic.SolicitarPermiso(this.user_id, appId, rolId))
            {
                this.Hide();
                var myForm = new Login();
                myForm.Show();
            }
            else
            {

            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new UserMenu(this.user_id);
            myForm.Show();
        }
    }
}
