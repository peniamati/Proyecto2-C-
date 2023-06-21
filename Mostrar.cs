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

namespace Proyecto2
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
            this.CenterToScreen();
            foreach (var vehiculo in Program.vehiculos)
            {
                if (vehiculo is Tesla)
                {
                    var tesla = (Tesla)vehiculo;
                    string[] rows = { tesla.getDuenio(), tesla.getModelo(), $"{(tesla.calcularEnteroBateria()).ToString()} baterias y un {(tesla.calcularPorcentajeBateria()).ToString()}% de la actual" };
                    var listViewedItem = new ListViewItem(rows);
                    lista_mostrada.Items.Add(listViewedItem);
                    lista_mostrada.Columns[0].Width = -2;
                    lista_mostrada.Columns[1].Width = -2;
                    lista_mostrada.Columns[2].Width = -2;
                }
                else if (vehiculo is SpaceX)
                {
                    var spaceX = (SpaceX)vehiculo;
                    string[] rows = { spaceX.getEmpresa(), spaceX.getModelo(), $"{spaceX.calcularEnteroBateria().ToString()} cargas de combustible y un {spaceX.calcularPorcentajeBateria().ToString()}% de la actual" };
                    var listViewedItem = new ListViewItem(rows);
                    lista_mostrada.Items.Add(listViewedItem);
                    lista_mostrada.Columns[0].Width = -2;
                    lista_mostrada.Columns[1].Width = -2;
                    lista_mostrada.Columns[2].Width = -2;
                }


            }



        }



    }
}
