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
    public partial class EscaneoResultado : Form
    {
        public EscaneoResultado()
        {
            InitializeComponent();
        }

        private void EscaneoResultado_Load(object sender, EventArgs e)
        {
            escaneando.Text = "Escaneando vehiculo...";
            int contador;
            List<int> serviceRealizados = new List<int>();
            int cinturones = 1000;
            int baterias = 2000;
            int propulsion = 1000;
            int navegacionKm = 2500;
            int navegacionHs = 500;
            int traccion = 3000;
            int motor = 3000;

            if (Program.kilometrajeEscaneo >= cinturones)
            {
                contador =+ 1;
                serviceRealizados.Add(1);
                serviceRealizados.Add(2);
            }
            
            realizados.Text = $"Se realizaron {contador=1} services";
            test_realizados.Text = "Test realizados:";
            foreach (int item in serviceRealizados)
            {
                test_realizados.Text = test_realizados.Text + " (" + item.ToString() +"),";
            }
        }
    }
}
