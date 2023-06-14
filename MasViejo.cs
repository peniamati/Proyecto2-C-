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
            int hayTesla = Program.vehiculos.Count(vehiculo => vehiculo is Tesla);
            string masViejoDuenio = "";
            bool iniciado = false;
            int anio = 0;
            foreach (Vehiculo vehiculo in Program.vehiculos)
            {
                if (vehiculo is Tesla)
                {
                    Tesla tesla = (Tesla)vehiculo;
                    if (!iniciado) { 
                        anio = tesla.getAnio();
                        Tesla inicial = tesla;
                        iniciado = true;
                        masViejoDuenio = $"Dueño: {inicial.getDuenio()} \nModelo: {inicial.getModelo()} \nAño: {inicial.getAnio()}";
                    }
                    else if (tesla.getAnio() < anio)
                    {
                        anio = tesla.getAnio();
                        masViejoDuenio = $"Dueño: {tesla.getDuenio()} \nModelo: {tesla.getModelo()} \nAño: {tesla.getAnio()}";
                    }
            

                }
            }
            mas_viejo_duenio.Text = masViejoDuenio;
        }
    }
}
