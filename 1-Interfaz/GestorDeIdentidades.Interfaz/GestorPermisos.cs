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
        public String userid = "";
        public String nombrePersona = "";
        public String app_id = "";
        public String nombreapp = "";
        public String rol_neg_id = "";
        public String rol_neg = "";
        public String fecha_solicitud = "";
        public String fecha_autorizacion = "";
        public String estado = "";

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
            this.userid = this.tablaPermisos.Rows[e.RowIndex].Cells["user_id"].Value.ToString();
            this.nombrePersona = this.tablaPermisos.Rows[e.RowIndex].Cells["nombrePersona"].Value.ToString();
            this.app_id = this.tablaPermisos.Rows[e.RowIndex].Cells["app_id"].Value.ToString();
            this.nombreapp = this.tablaPermisos.Rows[e.RowIndex].Cells["nombreapp"].Value.ToString();
            this.rol_neg_id = this.tablaPermisos.Rows[e.RowIndex].Cells["rol_neg_id"].Value.ToString();
            this.rol_neg = this.tablaPermisos.Rows[e.RowIndex].Cells["descripcion_rol_neg"].Value.ToString();
            this.fecha_solicitud = this.tablaPermisos.Rows[e.RowIndex].Cells["fecha_solicitud"].Value.ToString();
            this.estado = this.tablaPermisos.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            var myFrom = new EditarPermiso(this.userid, this.nombrePersona, this.nombreapp, this.rol_neg, this.fecha_solicitud, this.estado);
            myFrom.Show();
            this.Hide();
        }

    }
}