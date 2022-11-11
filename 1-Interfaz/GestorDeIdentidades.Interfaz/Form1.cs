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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.GetPreguntas();
            this.GetPermisos();
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
    }
}
