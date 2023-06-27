using Proyecto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Proyecto2
{
    /// <summary>
    /// Clase del formulario Eliminar.
    /// </summary>
    public partial class Eliminar : Form
    {
        /// <summary>
        /// Constructor de la clase Eliminar.
        /// </summary>
        public Eliminar()
        {
            InitializeComponent();
            this.CenterToScreen();
            selector_tipo.Items.Add("Tesla"); // Agrega "Tesla" al selector_tipo
            selector_tipo.Items.Add("SpaceX"); // Agrega "SpaceX" al selector_tipo
            tabla.FullRowSelect = true; // Establece FullRowSelect en true para seleccionar filas completas en la tabla
        }
        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        private void CloseForm()
        {
            this.Close();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga el formulario Eliminar.
        /// </summary>
        private void Eliminar_Load(object sender, EventArgs e)
        {
            Program.aRemoverVehiculo.Clear(); // Limpia la lista aRemoverVehiculo
            boton_eliminar.Hide(); // Oculta el botón eliminar
            tabla.Hide(); // Oculta la tabla
            boton_seleccionar.Hide(); // Oculta el botón seleccionar
        }

        /// <summary>
        /// Evento que se ejecuta cuando se selecciona un elemento en el selector_tipo.
        /// </summary>
        private void selector_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {   
            boton_seleccionar.Show(); // Muestra el botón seleccionar
            tabla.Hide(); // Oculta la tabla
            boton_eliminar.Hide(); // Oculta el botón eliminar
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón seleccionar.
        /// </summary>
        private void boton_seleccionar_Click(object sender, EventArgs e)
        {
            boton_eliminar.Show(); // Muestra el botón eliminar
            tabla.Show();          // Muestra la tabla
            string gettext = selector_tipo.SelectedItem.ToString(); // Obtiene el elemento seleccionado del selector_tipo
            if (gettext == "Tesla")
            {
                tabla.Items.Clear();     // Limpia los elementos de la tabla
                foreach (Vehiculo vehiculo in Program.vehiculos)
                {

                    if (vehiculo is Tesla)
                    {
                        Tesla tesla = (Tesla)vehiculo;
                        string[] rows = { tesla.getDuenio(), tesla.getModelo(), tesla.getKilometraje().ToString() };
                        ListViewItem listViewedItem = new ListViewItem(rows);
                        tabla.Items.Add(listViewedItem); // Agrega el elemento a la tabla
                    }
                }
                if (tabla.Items.Count > 0)
                {
                    tabla.Items[0].Selected = true;    // Selecciona el primer elemento de la tabla
                    tabla.FocusedItem = tabla.Items[0];
                }
            }


            else if (gettext == "SpaceX")
            {
                tabla.Items.Clear(); // Limpia los elementos de la tabla
                foreach (Vehiculo vehiculo in Program.vehiculos)
                {
                    if (vehiculo is SpaceX)
                    {
                        SpaceX spaceX = (SpaceX)vehiculo;
                        string[] rows = { spaceX.getEmpresa(), spaceX.getModelo(), spaceX.getHorasDeVuelo().ToString() };
                        ListViewItem listViewedItem = new ListViewItem(rows);
                        tabla.Items.Add(listViewedItem);  // Agrega el elemento a la tabla
                    }
                }
                if (tabla.Items.Count > 0)
                {
                    tabla.Items[0].Selected = true;   // Selecciona el primer elemento de la tabla
                    tabla.FocusedItem = tabla.Items[0];
                }
            }
            tabla.Columns[0].Width = -2;
            tabla.Columns[1].Width = -2;
            tabla.Columns[2].Width = -2;
            tabla.Width = tabla.Columns[0].Width + tabla.Columns[1].Width + tabla.Columns[2].Width;

        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón eliminar.
        /// </summary>
        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.Items.Count > 0)
                {
                    int index = tabla.FocusedItem.Index;
                    string kilometrajeEliminar = tabla.Items[index].SubItems[2].Text;
                    string duenioEliminar = tabla.Items[index].SubItems[0].Text;
                    string modeloEliminar = tabla.Items[index].SubItems[1].Text;
                    List<string> itemToRemove = new List<string> { kilometrajeEliminar, duenioEliminar, modeloEliminar };
                    foreach (Vehiculo vehiculo in Program.vehiculos)
                    {
                        if (vehiculo is Tesla)
                        {
                            Tesla tesla = (Tesla)vehiculo;
                            if (itemToRemove.Contains(tesla.getKilometraje().ToString()) && itemToRemove.Contains(tesla.getDuenio()) && itemToRemove.Contains(tesla.getModelo()))
                            {
                                Program.aRemoverVehiculo.Add(tesla); // Agrega el vehículo a la lista aRemoverVehiculo
                                itemToRemove.Clear(); // Limpia la lista itemToRemove
                            }
                        }
                        if (vehiculo is SpaceX)
                        {
                            SpaceX spaceX = (SpaceX)vehiculo;
                            if (itemToRemove.Contains(spaceX.getHorasDeVuelo().ToString()) && itemToRemove.Contains(spaceX.getEmpresa()) && itemToRemove.Contains(spaceX.getModelo()))
                            {
                                Program.aRemoverVehiculo.Add(spaceX); // Agrega el vehículo a la lista aRemoverVehiculo
                                itemToRemove.Clear(); // Limpia la lista itemToRemove
                            }
                        }

                    }
                    DialogResult Result;

                    // Muestra un cuadro de diálogo de confirmación para eliminar el vehículo
                    Result = MessageBox.Show("Seguro que desea eliminar el vehiculo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Result == DialogResult.Yes)
                    {
                        DialogResult Resultado;
                        // Notificacion de eliminacion 
                        // Si el valor no es nulo se elimina el vehiculo
                        if (Program.aRemoverVehiculo[0] is Tesla)
                        {
                            Program.vehiculos.Remove(Program.aRemoverVehiculo[0]); // Elimina el vehículo de la lista Program.vehiculos

                            Resultado = MessageBox.Show("Tesla eliminado con exito. \nDesea eliminar otro vehiculo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (Resultado == DialogResult.Yes && Program.vehiculos.Count > 0)
                            {
                                this.Close();
                                new Eliminar().Show();
                            }
                            else if (Resultado == DialogResult.Yes && Program.vehiculos.Count == 0)
                            {
                                MessageBox.Show("No hay vehiculos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                                CloseForm();
                            }
                        }
                        else if (Program.aRemoverVehiculo[0] is SpaceX)
                        {
                            Program.vehiculos.Remove(Program.aRemoverVehiculo[0]);  // Elimina el vehículo de la lista Program.vehiculos
                            Resultado = MessageBox.Show("SpaceX eliminado con exito. \nDesea eliminar otro vehiculo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (Resultado == DialogResult.Yes && Program.vehiculos.Count > 0)
                            {
                                this.Close();
                                new Eliminar().Show();
                            }
                            else if (Resultado == DialogResult.Yes && Program.vehiculos.Count == 0)
                            {
                                MessageBox.Show("No hay vehiculos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                                CloseForm();
                            }
                        }
                        // Si no se desea eliminar otro vehiculo se cierra la ventana 

                    }

                }
                else
                {
                    throw new Exception("No selecciono ningun valor a eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}