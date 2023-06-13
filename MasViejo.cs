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
    public partial class MasViejo : Form
    {
        public MasViejo()
        {
            InitializeComponent();
        }

        private void MasViejo_Load(object sender, EventArgs e)
        {
            string masViejoDuenio = "";
            int anio = Program.vehiculos[0].getAnio();
            Tesla inicial = (Tesla)Program.vehiculos.First();

            foreach (Vehiculo vehiculo in Program.vehiculos)
            {
                if (vehiculo is Tesla)
                {
                    Tesla tesla = (Tesla)vehiculo;
                    if (tesla.getAnio() < anio)
                    {
                        anio = tesla.getAnio();
                        masViejoDuenio = $"Dueño: {tesla.getDuenio()} \nModelo: {tesla.getModelo()} \nAño: {tesla.getAnio()}";
                    }
                    else
                    {
                        masViejoDuenio = $"Dueño: {inicial.getDuenio()} \nModelo: {inicial.getModelo()} \nAño: {inicial.getAnio()}";
                    }
                }
            }
            mas_viejo_duenio.Text = masViejoDuenio;
        }
    }
}
