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
            this.CenterToScreen();
        }

        private void MasViejo_Load(object sender, EventArgs e)
            // muestra el elemento mas viejo
        {
            int hayTesla = Program.vehiculos.Count(vehiculo => vehiculo is Tesla);
            string masViejoDuenio = "";
            bool iniciado = false;
            int anio = 0;
            foreach (Vehiculo vehiculo in Program.vehiculos)
                // recorre la lista vehiculos y comprueba la clase 
            {
                if (vehiculo is Tesla)
                {
                    // obtiene el anio y compara con los valores de la lista
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
