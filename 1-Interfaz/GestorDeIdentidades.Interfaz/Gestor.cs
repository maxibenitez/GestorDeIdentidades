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
    public partial class Gestor : Form
    {
        public Gestor()
        {
            InitializeComponent();
        }

        private void bAplicativos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gestorPermisos = new GestorPermisos();
            gestorPermisos.Show();
        }

        private void bPermisos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gestorAplicativos = new GestorAplicativos();
            gestorAplicativos.Show();
        }
    }
}
