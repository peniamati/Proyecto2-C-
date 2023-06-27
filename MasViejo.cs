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
    /// <summary>
    /// Clase del MasViejo.
    /// </summary>
    public partial class MasViejo : Form
    {
        public MasViejo()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void MasViejo_Load(object sender, EventArgs e)
        {
            // Muestra el elemento más viejo en la interfaz del formulario
           
            int hayTesla = Program.vehiculos.Count(vehiculo => vehiculo is Tesla);
            // Cuenta el número de vehículos de tipo Tesla en la lista de vehículos
           
            string masViejoDuenio = "";
            // Almacena la información del dueño del vehículo más viejo

            bool iniciado = false;
            // Controla si se ha encontrado el primer vehículo Tesla
           
            int anio = 0;
            // Almacena el año del vehículo más viejo encontrado

            foreach (Vehiculo vehiculo in Program.vehiculos)
            {
                // Recorre la lista de vehículos
                if (vehiculo is Tesla)
                {
                    // Verifica si el vehículo actual es de tipo Tesla
                    
                    Tesla tesla = (Tesla)vehiculo;
                    // Realiza un cast del vehículo actual a tipo Tesla

                    if (!iniciado) { 
                        anio = tesla.getAnio();
                        // Obtiene el año del primer vehículo Tesla encontrado
                        Tesla inicial = tesla;
                        iniciado = true;
                        // Marca que se ha encontrado el primer vehículo Tesla
                        masViejoDuenio = $"Dueño: {inicial.getDuenio()} \nModelo: {inicial.getModelo()} \nAño: {inicial.getAnio()}";
                        // Almacena la información del primer vehículo Tesla como el más viejo hasta ahora
                    }
                    else if (tesla.getAnio() < anio)
                    {
                        anio = tesla.getAnio();
                        // Actualiza el año del vehículo más viejo encontrado hasta ahora
                        masViejoDuenio = $"Dueño: {tesla.getDuenio()} \nModelo: {tesla.getModelo()} \nAño: {tesla.getAnio()}";
                        // Actualiza la información del dueño del vehículo más viejo encontrado hasta ahora
                    }


                }
            }
            mas_viejo_duenio.Text = masViejoDuenio;
            // Muestra la información del dueño del vehículo más viejo en un control de la interfaz del formulario
        }
    }
}
