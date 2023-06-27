using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Proyecto2
{
    /// <summary>
    /// Clase principal del programa.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Kilometraje del vehículo escaneado.
        /// </summary>
        public static double kilometrajeEscaneo;

        /// <summary>
        /// Modelo del vehículo escaneado.
        /// </summary>
        public static string modeloEscaneo;

        /// <summary>
        /// Lista de vehículos a remover.
        /// </summary>
        public static List<Vehiculo> aRemoverVehiculo = new List<Vehiculo>();

        /// <summary>
        /// Lista de vehículos.
        /// </summary>
        public static List<Vehiculo> vehiculos = new List<Vehiculo>();

        /// <summary>
        /// Punto de entrada del programa.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicio de la aplicación
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}
