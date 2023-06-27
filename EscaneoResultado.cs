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
    /// Clase que representa la ventana de resultados de escaneo de vehículos.
    /// </summary>
    public partial class EscaneoResultado : Form
    {
        /// <summary>
        /// Constructor de la clase EscaneoResultado.
        /// </summary>
        public EscaneoResultado()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        /// Evento que se dispara cuando se carga la ventana.
        /// Realiza el escaneo del vehículo y muestra los resultados en la interfaz de usuario.
        /// </summary>
        private void EscaneoResultado_Load(object sender, EventArgs e)
        {
            // Etiqueta de escaneo en proceso
            escaneando.Text = "Escaneando vehiculo...";

            // Contador de servicios realizados
            int contador = 0;

            // Lista de servicios realizados
            List<int> serviceRealizados = new List<int>();

            // Valores de referencia para los servicios
            int cinturones = 1000;
            int baterias = 2000;
            int propulsion = 1000;
            int navegacionKm = 2500;
            int navegacionHs = 500;
            int motor = 3000;

            // Comprobación del modelo del vehículo escaneado
            if (Program.modeloEscaneo == "Tesla")
            {
                // Escaneo y servicios para vehículos Tesla

                // Comprobación del kilometraje para el servicio de cinturones
                if (Program.kilometrajeEscaneo >= cinturones)
                {
                    // Se registra el servicio de cinturones realizado
                    contador = +1;
                    int cantidad = (int)(Program.kilometrajeEscaneo / cinturones);
                    contador = contador * cantidad;
                    serviceRealizados.Add(1);

                    // Comprobación del kilometraje para otros servicios
                    if (Program.kilometrajeEscaneo >= baterias && Program.kilometrajeEscaneo < navegacionKm)
                    {
                        // Servicio de baterías realizado
                        serviceRealizados.Add(2);
                    }
                    else if (Program.kilometrajeEscaneo >= navegacionKm && Program.kilometrajeEscaneo < motor)
                    {
                        // Servicios de navegación y motor realizados
                        serviceRealizados.Add(2);
                        serviceRealizados.Add(4);
                    }
                    else if (Program.kilometrajeEscaneo >= motor)
                    {
                        // Servicios de navegación, motor y otros realizados
                        serviceRealizados.Add(2);
                        serviceRealizados.Add(4);
                        serviceRealizados.Add(5);
                        serviceRealizados.Add(6);
                    }
                }

            }
            else if (Program.modeloEscaneo == "SpaceX")
            {
                // Escaneo y servicios para vehículos SpaceX

                // Comprobación de las horas de vuelo para el servicio de navegación
                if (Program.kilometrajeEscaneo >= navegacionHs)
                {
                    // Se registra el servicio de navegación realizado
                    contador = +1;
                    int cantidad = (int)(Program.kilometrajeEscaneo / navegacionHs);
                    contador = contador * cantidad;
                    serviceRealizados.Add(4);

                    // Comprobación del kilometraje para el servicio de propulsión
                    if (Program.kilometrajeEscaneo >= propulsion)
                    {
                        // Servicio de propulsión realizado
                        serviceRealizados.Add(3);
                    }
                }

            }

            // Mostrar los servicios realizados en la interfaz de usuario

            // Etiqueta con el contador de servicios realizados
            realizados.Text = $"Se realizaron {contador} services";

            // Etiqueta con los servicios realizados
            test_realizados.Text = "Test realizados:";
            foreach (int item in serviceRealizados)
            {
                test_realizados.Text = test_realizados.Text + " (" + item.ToString() + "),";
            }
        }

        /// <summary>
        /// Evento que se dispara cuando se cierra la ventana.
        /// Muestra una ventana de confirmación para realizar otro escaneo.
        /// </summary>
        private void EscaneoResultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ventana de confirmación para realizar otro escaneo
            DialogResult Resultado;
            Resultado = MessageBox.Show("Desea escanear otro vehiculo?", "escanear", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Resultado == DialogResult.Yes)
            {
                // Abre una nueva instancia de la ventana "Escaneo"
                new Escaneo().Show();
            }
        }
    }
}
