using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            //Se inicializa la ventana centrada y se permite elegir una fila entera
            InitializeComponent();
            this.CenterToScreen();
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
            tabla.FullRowSelect = true;
            tabla.AllowDrop = false;
            
        }

        private void boton_seleccionar_Click(object sender, EventArgs e)
        {
            //Los valores mostrados dependen del tipo de vehiculo
            a_escanear.Show();
            tabla.Show();
            boton_a_escanear.Show();

            string gettext = selector_tipo.SelectedItem.ToString();
            bool limpia = false;
            if (gettext == "Tesla")
            {

                limpia = false;
                if (!limpia)
                {
                    tabla.Items.Clear();
                    limpia = true;
                }
                foreach (Vehiculo vehiculo in Program.vehiculos)
                {
                    if (vehiculo is Tesla)
                    {
                        Tesla tesla = (Tesla)vehiculo;
                        string[] rows = { tesla.getDuenio(), tesla.getModelo(), tesla.getKilometraje().ToString() };
                        var listViewedItem = new ListViewItem(rows);
                        tabla.Items.Add(listViewedItem);
                        
                    }
                }
            }
            else if (gettext == "SpaceX")
            {
                limpia = false;
                if (!limpia)
                {
                    tabla.Items.Clear();
                    limpia = true;
                }
                foreach (Vehiculo vehiculo in Program.vehiculos)
                {
                    if (vehiculo is SpaceX)
                    {
                        var spaceX = (SpaceX)vehiculo;
                        string[] rows = { spaceX.getEmpresa(), spaceX.getModelo(), spaceX.getHorasDeVuelo().ToString() };
                        var listViewedItem = new ListViewItem(rows);
                        tabla.Items.Add(listViewedItem);
                    }


                }

            }
            tabla.Columns[0].Width = -2;
            tabla.Columns[1].Width = -2;
            tabla.Columns[2].Width = -2;
            tabla.Width = tabla.Columns[0].Width + tabla.Columns[1].Width + tabla.Columns[2].Width;
        }

        private void Escaneo_Load(object sender, EventArgs e)
        {
            boton_seleccionar.Hide();
            a_escanear.Hide();
            tabla.Hide();
            boton_a_escanear.Hide();
        }

        private void boton_a_escanear_Click(object sender, EventArgs e)
        {
            //Se llama al form de EscaneoResultado evaluando que haya vehiculos y que se haya seleccionado uno
            int index;
            if (tabla.FocusedItem != null && tabla.FocusedItem.Index != -1)
            {
                index = tabla.FocusedItem.Index;
                Program.modeloEscaneo = selector_tipo.SelectedItem.ToString();
                Program.kilometrajeEscaneo = Convert.ToDouble(tabla.Items[index].SubItems[2].Text);               
                new EscaneoResultado().Show();
                this.Close();
            }
        }


        private void selector_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            boton_seleccionar.Show();
            tabla.Hide();
            boton_a_escanear.Hide();
            a_escanear.Hide();
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
