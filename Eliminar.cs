using Proyecto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            selector_tipo.Items.Add("Tesla");
            selector_tipo.Items.Add("SpaceX");
            tabla.FullRowSelect = true;
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
                        Program.aRemoverTesla = tesla;
                    }
                }
                else if (vehiculo is SpaceX)
                {
                    SpaceX spaceX = (SpaceX)vehiculo;
                    if (itemToRemove.Contains(spaceX.getHorasDeVuelo().ToString()) && itemToRemove.Contains(spaceX.getEmpresa()) && itemToRemove.Contains(spaceX.getModelo()))
                    {
                        Program.aRemoverSpaceX = spaceX;
                    }
                }

            }
            DialogResult Result;
            Result = MessageBox.Show("Seguro que desea eliminar el vehiculo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Result == DialogResult.Yes)
            { 
                if (Program.aRemoverTesla is not null) { 
                    Program.vehiculos.Remove(Program.aRemoverTesla);
                }
                else if(Program.aRemoverSpaceX is not null)
                {
                    Program.vehiculos.Remove(Program.aRemoverSpaceX);
                }
                else
                {
                    MessageBox.Show("No hay vehiculos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }

        }

        private void selector_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            boton_seleccionar.Show();
            tabla.Hide();
            boton_eliminar.Hide();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            boton_eliminar.Hide();
            tabla.Hide();
            boton_seleccionar.Hide();
        }

        private void boton_seleccionar_Click(object sender, EventArgs e)
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
                    if(vehiculo is Tesla)
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
                    if( vehiculo is SpaceX)
                    {
                        SpaceX spaceX = (SpaceX)vehiculo;
                        string[] rows = { spaceX.getEmpresa(), spaceX.getModelo(), spaceX.getHorasDeVuelo().ToString() };
                        var listViewedItem = new ListViewItem(rows);
                        tabla.Items.Add(listViewedItem);
                    }

                }
            }

        }
    }
}


