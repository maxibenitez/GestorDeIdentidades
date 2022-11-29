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
    public partial class UserMenu : Form
    {
        private int user_id;
        public UserMenu(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void botonAplicativos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Dummy(this.user_id);
            myForm.Show();
        }

        private void botonPermisos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new SolicitarPermisos(this.user_id);
            myForm.Show();
        }

        private void botonCambiarContra_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new NuevaContrasena(this.user_id);
            myForm.Show();
        }
    }
}
