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
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto2
{
    public partial class Escaneo : Form
    {
        
        public Escaneo()
        {
            InitializeComponent();
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
            tabla.FullRowSelect = true;      
        }

        private void boton_seleccionar_Click(object sender, EventArgs e)
        {
            a_escanear.Show();
            tabla.Show();
            boton_a_escanear.Show();
            string gettext = selector_tipo.SelectedItem.ToString();
            foreach (Vehiculo vehiculo in Program.vehiculos)
            {
                if (gettext == "Tesla")
                {
                    tabla.Items.Clear();
                    if (vehiculo is Tesla)
                    {
                        var tesla = (Tesla)vehiculo;
                        string[] rows = { tesla.getDuenio(), tesla.getModelo(), tesla.getKilometraje().ToString() };
                        var listViewedItem = new ListViewItem(rows);
                        tabla.Items.Add(listViewedItem);
                    }
                }
                else if (gettext == "SpaceX")
                {
                    tabla.Items.Clear();
                    if (vehiculo is SpaceX)
                    {
                        var spaceX = (SpaceX)vehiculo;
                        string[] rows = { spaceX.getEmpresa(), spaceX.getModelo(), spaceX.getHorasDeVuelo().ToString() };
                        var listViewedItem = new ListViewItem(rows);
                        tabla.Items.Add(listViewedItem);
                    }
                }

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
            Program.modeloEscaneo = selector_tipo.SelectedItem.ToString();
            int index = tabla.FocusedItem.Index;
            Program.kilometrajeEscaneo = Convert.ToDouble(tabla.Items[index].SubItems[2].Text);
            new EscaneoResultado().Show();
        }


        private void selector_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gettext = selector_tipo.SelectedItem.ToString();
            if (gettext == "Tesla")
            {
                tabla.Items.Clear();
                duenio.Text = "Dueño";
                kilometraje.Text = "Kilometraje";
            }
            else if (gettext == "SpaceX")
            {
                tabla.Items.Clear();
                duenio.Text = "Empresa";
                kilometraje.Text = "Horas de Vuelo";
            }

        }


    }


}
