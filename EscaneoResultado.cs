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
            string palabra = "palabra";
            escaneando.Text = $"Escaneando vehiculo: {palabra}";
            realizados.Text = $"Se realizaron {2} services";
            test_realizados.Text = $"Test realizados:(1), (2)";
        }
    }
}
