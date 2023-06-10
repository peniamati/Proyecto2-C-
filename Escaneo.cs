using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Escaneo : Form
    {
        public Escaneo()
        {
            InitializeComponent();
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
        }

        private void boton_seleccionar_Click(object sender, EventArgs e)
        {
            a_escanear.Show();
            tabla.Show();
            boton_a_escanear.Show();
            string gettext = selector_tipo.SelectedItem.ToString();
            if (gettext == "Tesla")
            {

            }
            else if (gettext == "SpaceX")
            {

            }
        }

        private void Escaneo_Load(object sender, EventArgs e)
        {
            a_escanear.Hide();
            tabla.Hide();
            boton_a_escanear.Hide();
        }

        private void boton_a_escanear_Click(object sender, EventArgs e)
        {
            new EscaneoResultado().Show();
        }
    }


}
