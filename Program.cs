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
        /// Kilometraje del veh�culo escaneado.
        /// </summary>
        public static double kilometrajeEscaneo;

        /// <summary>
        /// Modelo del veh�culo escaneado.
        /// </summary>
        public static string modeloEscaneo;

        /// <summary>
        /// Lista de veh�culos a remover.
        /// </summary>
        public static List<Vehiculo> aRemoverVehiculo = new List<Vehiculo>();

        /// <summary>
        /// Lista de veh�culos.
        /// </summary>
        public static List<Vehiculo> vehiculos = new List<Vehiculo>();

        /// <summary>
        /// Punto de entrada del programa.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicio de la aplicaci�n
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}
