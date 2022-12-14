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
    public partial class GestorAplicativos : Form
    {
        private readonly GestorLogic _gestorLogic = new GestorLogic();
        
        public GestorAplicativos()
        {
            InitializeComponent();

            List<RolNegocio> rolesNegocio = _gestorLogic.GetRolesNegocio();

            foreach (RolNegocio rol in rolesNegocio)
            {
                InputRolesNegocio.Items.Add($"{rol.Rol_neg_id}. {rol.Descripcion_rol_neg}");
            }

            List<Aplicativo> aplicativos = _gestorLogic.GetAplicativos();

            foreach (Aplicativo aplicativo in aplicativos)
            {
                InputAplicativos.Items.Add($"{aplicativo.App_id}. {aplicativo.NombreApp}");
            }

        }

        private void actualizarAplicativos_Click(object sender, EventArgs e)
        {
            string[] rol = InputRolesNegocio.Text.Split('.');
            int rol_neg_id = Convert.ToInt32(rol[0]);
            string[] aplicativo = InputAplicativos.Text.Split('.');
            int app_id = Convert.ToInt32(aplicativo[0]);

            List<int> rolesAplicativosId = new List<int>();

            foreach (var item in InputRolesAplicativos.CheckedItems)
            {
                string[] items = item.ToString().Split('.');
                int rol_id = Convert.ToInt32(items[0]);
                rolesAplicativosId.Add(rol_id);
            }

            _gestorLogic.EditarAplicativos(rol_neg_id, app_id, rolesAplicativosId);

            var gestor = new Gestor();
            gestor.Show();
            this.Hide();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gestor = new Gestor();
            gestor.Show();
        }

        private void InputAplicativos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] rol = InputRolesNegocio.Text.Split('.');
            int rol_neg_id = Convert.ToInt32(rol[0]);
            string[] aplicativo = InputAplicativos.Text.Split('.');
            int app_id = Convert.ToInt32(aplicativo[0]);

            InputRolesAplicativos.Items.Clear();
            List<RolAplicativo> rolesAplicativos = _gestorLogic.GetRolesAplicativos();
            List<int> rolNegAplicativos = _gestorLogic.GetRolesNegocioAplicativos(rol_neg_id, app_id);


            foreach (RolAplicativo rolA in rolesAplicativos)
            {
                if (rolNegAplicativos.Contains(rolA.Rol_id))
                {
                    InputRolesAplicativos.Items.Add($"{rolA.Rol_id}. {rolA.Descripcion_rol}", true);
                }
                else
                {
                    InputRolesAplicativos.Items.Add($"{rolA.Rol_id}. {rolA.Descripcion_rol}", false);
                }
            }
        }
    }
}
