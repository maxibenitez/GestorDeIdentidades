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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            errorCampos.Text = "";

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
            string[] rol = InputRol.Text.Split('.');
            
            errorCampos.Text = "";

            if (aplicativo[0].Equals("") || rol[0].Equals(""))
            {
                errorCampos.Text = "Debe completar todos los campos!";
            }
            else
            {
                int appId = Int32.Parse(aplicativo[0]);
                int rolId = Int32.Parse(rol[0]);

                if (_permisosLogic.SolicitarPermiso(this.user_id, appId, rolId))
                {
                    this.Hide();
                    var menu = new UserMenu(this.user_id);
                    menu.Show();
                }
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new UserMenu(this.user_id);
            menu.Show();
        }
    }
}
