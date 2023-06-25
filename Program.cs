using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Proyecto2
    
{
    
    internal static class Program
    {
        public static double kilometrajeEscaneo;
        public static string modeloEscaneo;
        public static List<Vehiculo> aRemoverVehiculo = new List<Vehiculo>();
        public static List<Vehiculo> vehiculos = new List<Vehiculo>();



        [STAThread]


        static void Main()
        {
            
            
            // inicio de aplicacion
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());

        }
    }
   

   

   

}