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
        private PreguntaLogic _preguntas = new PreguntaLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.GetPreguntas();
        }

        private void GetPreguntas()
        {
            List<Preguntas> listPreguntas = _preguntas.GetPreguntas();

            this.dgvPregunta.DataSource = listPreguntas;
        }
    }
}
