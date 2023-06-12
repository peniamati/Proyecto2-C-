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
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
            foreach (var vehiculo in Program.vehiculos)
            {
                if (vehiculo is Tesla)
                {
                    var tesla = (Tesla)vehiculo;
                    string[] rows = { tesla.getDuenio(), tesla.getModelo(), $"{(tesla.calcularBateria()).ToString()}%" };
                    var listViewedItem = new ListViewItem(rows);
                    lista_mostrada.Items.Add(listViewedItem);
                }
                else if (vehiculo is SpaceX)
                {
                    var spaceX = (SpaceX)vehiculo;
                    string[] rows = { spaceX.getEmpresa(), spaceX.getModelo(), $"{(spaceX.calcularBateria()).ToString()}%" };
                    var listViewedItem = new ListViewItem(rows);
                    lista_mostrada.Items.Add(listViewedItem);
                }

            }


        }



    }
}
