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
    public partial class Dummy : Form
    {
        private readonly DummyLogic _dummyLogic = new DummyLogic();
        private int id;

        public Dummy(int user_id)
        {
            InitializeComponent();
            id = user_id;

            List<Aplicativo> aplicativos = _dummyLogic.GetAplicativosDummy(user_id);

            foreach (Aplicativo aplicativo in aplicativos)
            {
                InputAplicativos.Items.Add($"{aplicativo.App_id}. {aplicativo.NombreApp}");
            }
        }

        private void InputAplicativos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] aplicativo = InputAplicativos.Text.Split('.');
            int app_id = Convert.ToInt32(aplicativo[0]);

            List<Menus> menus = _dummyLogic.GetMenuDummy(id, app_id);

            foreach (Menus menu in menus)
            {
                listaMenu.Items.Add($"{menu.Menu_id}. {menu.Descripcion_menu}");
            }
        }
    }
}
