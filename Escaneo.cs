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
    /// <summary>
    /// Clase que representa la ventana de escaneo de vehículos.
    /// </summary>
    public partial class Escaneo : Form
    {
        /// <summary>
        /// Constructor de la clase Escaneo.
        /// </summary>
        public Escaneo()
        {
            // Inicialización de la ventana
            InitializeComponent();
            this.CenterToScreen();
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
            tabla.FullRowSelect = true;
            tabla.AllowDrop = false;

        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Seleccionar".
        /// Muestra la lista de vehículos disponibles para escanear.
        /// </summary>
        private void boton_seleccionar_Click(object sender, EventArgs e)
        {
            // Mostrar valores dependiendo del tipo de vehículo seleccionado
            a_escanear.Show();
            tabla.Show();
            boton_a_escanear.Show();

            string gettext = selector_tipo.SelectedItem.ToString();
            if (gettext == "Tesla")
            {
                // Mostrar vehículos Tesla en la tabla
                tabla.Items.Clear();
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
                if (tabla.Items.Count > 0)
                {
                    tabla.Items[0].Selected = true;
                    tabla.FocusedItem = tabla.Items[0];
                }
            }
            else if (gettext == "SpaceX")
            {
                // Mostrar vehículos SpaceX en la tabla
                tabla.Items.Clear();
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
                if (tabla.Items.Count > 0)
                {
                    tabla.Items[0].Selected = true;
                    tabla.FocusedItem = tabla.Items[0];
                }

            }
            tabla.Columns[0].Width = -2;
            tabla.Columns[1].Width = -2;
            tabla.Columns[2].Width = -2;
            tabla.Width = tabla.Columns[0].Width + tabla.Columns[1].Width + tabla.Columns[2].Width;
        }

        /// <summary>
        /// Evento que se dispara al cargar la ventana.
        /// Oculta elementos de la interfaz.
        /// </summary>
        private void Escaneo_Load(object sender, EventArgs e)
        {
            boton_seleccionar.Hide();
            a_escanear.Hide();
            tabla.Hide();
            boton_a_escanear.Hide();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "A Escanear".
        /// Abre la ventana de resultados de escaneo si se selecciona un vehículo.
        /// </summary>
        private void boton_a_escanear_Click(object sender, EventArgs e)
        {
            //Se llama al formulario de EscaneoResultado evaluando que haya vehiculos y que se haya seleccionado uno
            try
            {
                if (tabla.Items.Count > 0)
                {
                    // Obtener el índice del vehículo seleccionado en la tabla
                    int index;
                    index = tabla.FocusedItem.Index;

                    // Establecer el modelo y el kilometraje del vehículo a escanear en la clase Program
                    Program.modeloEscaneo = selector_tipo.SelectedItem.ToString();
                    Program.kilometrajeEscaneo = Convert.ToDouble(tabla.Items[index].SubItems[2].Text);

                    // Abrir la ventana de resultados de escaneo y cerrar la ventana actual
                    new EscaneoResultado().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No selecciono ningun vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento que se dispara al cambiar la selección del tipo de vehículo.
        /// Actualiza la interfaz según el tipo de vehículo seleccionado.
        /// </summary>
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
