using GestorDeIdentidades.Logic;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeIdentidades.Interfaz
{
    public partial class Dummy : Form
    {
        private readonly DummyLogic _dummyLogic = new DummyLogic();
        private int user_id;

        public Dummy(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;

            InputAplicativos.Hide();
            listaMenu.Hide();
            label9.Hide();
            label1.Hide();
            permisoMessage.Hide();

            List<Aplicativo> aplicativosOriginal = _dummyLogic.GetAplicativosDummy(user_id);
            List<string> appStrings = new List<String>();

            if(aplicativosOriginal.Count() == 0)
            {
                permisoMessage.Show();
            }
            else
            {
                InputAplicativos.Show();
                listaMenu.Show();
                label9.Show();
                label1.Show();

                foreach (Aplicativo aplicativo in aplicativosOriginal)
                {
                    appStrings.Add($"{aplicativo.App_id}. {aplicativo.NombreApp}");
                }

                List<string> appsstrings = appStrings.Distinct().ToList();

                foreach (string app in appsstrings)
                {
                    InputAplicativos.Items.Add(app);
                }
            }
        }

        private void InputAplicativos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] aplicativo = InputAplicativos.Text.Split('.');
            int app_id = Convert.ToInt32(aplicativo[0]);

            listaMenu.Items.Clear();

            List<Menus> menus = _dummyLogic.GetMenuDummy(this.user_id, app_id);

            foreach (Menus menu in menus)
            {
                listaMenu.Items.Add($"{menu.Menu_id}. {menu.Descripcion_menu}");
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
