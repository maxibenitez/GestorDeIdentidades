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
    public partial class GestorPermisos : Form
    {
        public List<Permiso> permisos = new PermisosLogic().GetPermisos();

        public GestorPermisos()
        {
            InitializeComponent();

            this.tablaPermisos.DataSource = permisos;
        }

        private void bTodos_Click(object sender, EventArgs e)
        {
            List<Permiso> permisosTodos = new PermisosLogic().GetPermisos();
            this.tablaPermisos.DataSource = permisosTodos;
        }

        private void bActivos_Click(object sender, EventArgs e)
        {
            List<Permiso> permisosActivos = new PermisosLogic().GetPermisosActivos();
            this.tablaPermisos.DataSource = permisosActivos;
        }

        private void bDenegados_Click(object sender, EventArgs e)
        {
            List<Permiso> permisosDenegados = new PermisosLogic().GetPermisosDenegados();
            this.tablaPermisos.DataSource = permisosDenegados;
        }

        private void bPendientes_Click(object sender, EventArgs e)
        {
            List<Permiso> permisosPendientes = new PermisosLogic().GetPermisosPendientes();
            this.tablaPermisos.DataSource = permisosPendientes;
        }

        private void tablaPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tablaPermisos.CurrentRow.Selected = true;

            Permiso permiso = new Permiso()
            {
                User_id = Convert.ToInt32(this.tablaPermisos.Rows[e.RowIndex].Cells["user_id"].Value),
                NombrePersona = this.tablaPermisos.Rows[e.RowIndex].Cells["nombrePersona"].Value.ToString(),
                App_id = Convert.ToInt32(this.tablaPermisos.Rows[e.RowIndex].Cells["app_id"].Value),
                NombreApp = this.tablaPermisos.Rows[e.RowIndex].Cells["nombreapp"].Value.ToString(),
                Rol_neg_id = Convert.ToInt32(this.tablaPermisos.Rows[e.RowIndex].Cells["rol_neg_id"].Value),
                Descripcion_rol_neg = this.tablaPermisos.Rows[e.RowIndex].Cells["descripcion_rol_neg"].Value.ToString(),
                Fecha_solicitud = Convert.ToDateTime(this.tablaPermisos.Rows[e.RowIndex].Cells["fecha_solicitud"].Value),
                Estado = this.tablaPermisos.Rows[e.RowIndex].Cells["estado"].Value.ToString()
        };

            this.Hide();
            var myFrom = new EditarPermiso(permiso);
            myFrom.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Gestor();
            myForm.Show();
        }
    }
}