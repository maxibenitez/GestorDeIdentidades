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
    public partial class Form1 : Form
    {
        private PreguntasLogic _preguntas = new PreguntasLogic();
        private PermisosLogic _permisos = new PermisosLogic();
        private AplicativosLogic _aplicativos = new AplicativosLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.GetPreguntas();
            this.GetPermisos();
            this.GetAplicativos();
        }

        private void GetAplicativos()
        {
            List<Aplicativos> listaAplicativos = _aplicativos.GetAplicativos();

            this.dgvPermisos.DataSource = listaAplicativos;
        }

        private void GetPreguntas()
        {
            List<Preguntas> listaPreguntas = _preguntas.GetPreguntas();

            this.dgvPregunta.DataSource = listaPreguntas;
        }

        private void GetPermisos()
        {
            List<Permiso> listaPermisos = _permisos.GetPermisos();

            this.dgvPermisos.DataSource = listaPermisos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
