using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Proyecto2
{
    
    internal static class Program
    {
        public static double kilometrajeEscaneo;
        public static string modeloEscaneo;
        public static Tesla aRemoverTesla;
        public static SpaceX aRemoverSpaceX;
        public static List<Vehiculo> vehiculos = new List<Vehiculo>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());

        }
    }
   

   

   

}