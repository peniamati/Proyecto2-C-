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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
            this.CenterToScreen();
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
            tabla.FullRowSelect = true;
        }
        private void Eliminar_Load(object sender, EventArgs e)
        {   // Muestra de botones y tabla
            Program.aRemoverVehiculo.Clear();
            boton_eliminar.Hide();
            tabla.Hide();
            boton_seleccionar.Hide();
        }
        private void selector_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {   // Muestra de botones y tabla
            boton_seleccionar.Show();
            tabla.Hide();
            boton_eliminar.Hide();
        }

        private void boton_seleccionar_Click(object sender, EventArgs e)
            // Limpieza de la tabla despues de eliminar
        {
            boton_eliminar.Show();
            tabla.Show();
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
                        ListViewItem listViewedItem = new ListViewItem(rows);
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
                        SpaceX spaceX = (SpaceX)vehiculo;
                        string[] rows = { spaceX.getEmpresa(), spaceX.getModelo(), spaceX.getHorasDeVuelo().ToString() };
                        ListViewItem listViewedItem = new ListViewItem(rows);
                        tabla.Items.Add(listViewedItem);
                    }
                }
            }
            tabla.Columns[0].Width = -2;
            tabla.Columns[1].Width = -2;
            tabla.Columns[2].Width = -2;
            tabla.Width = tabla.Columns[0].Width + tabla.Columns[1].Width + tabla.Columns[2].Width;

        }
        private void boton_eliminar_Click(object sender, EventArgs e)
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
                        Program.aRemoverVehiculo.Add(tesla);
                        itemToRemove.Clear();
                    }
                }
                if (vehiculo is SpaceX)
                {
                    SpaceX spaceX = (SpaceX)vehiculo;
                    if (itemToRemove.Contains(spaceX.getHorasDeVuelo().ToString()) && itemToRemove.Contains(spaceX.getEmpresa()) && itemToRemove.Contains(spaceX.getModelo()))
                    {
                        Program.aRemoverVehiculo.Add(spaceX);
                        itemToRemove.Clear();
                    }
                }

            }
            DialogResult Result;
            // Mensaje de confirmacion de eliminacion del vehiculo
            Result = MessageBox.Show("Seguro que desea eliminar el vehiculo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Result == DialogResult.Yes)
            {
                DialogResult Resultado;
                // Notificacion de eliminacion 
                // Si el valor no es nulo se elimina el vehiculo
                if (Program.aRemoverVehiculo[0] is Tesla)
                {
                    Program.vehiculos.Remove(Program.aRemoverVehiculo[0]);
                    Resultado = MessageBox.Show("Tesla eliminado con exito. \nDesea eliminar otro vehiculo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Resultado == DialogResult.Yes)
                    {
                        this.Close();
                        new Eliminar().Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if (Program.aRemoverVehiculo[0] is SpaceX)
                {
                    Program.vehiculos.Remove(Program.aRemoverVehiculo[0]);
                    Resultado = MessageBox.Show("SpaceX eliminado con exito. \nDesea eliminar otro vehiculo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Resultado == DialogResult.Yes)
                    {
                        this.Close();
                        new Eliminar().Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                // Si no se desea eliminar otro vehiculo se cierra la ventana 

            }

        }
    }
}


