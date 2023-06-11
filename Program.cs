using System.Reflection;
using System.Runtime.CompilerServices;

namespace Proyecto2
{
    
    internal static class Program
    {
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
   
    public class Vehiculo
    {
        int anio;
        string color;
        public Vehiculo(int anio, string color)
        {
            this.anio = anio;
            this.color = color;
        }
        public int getAnio()
        {
            return anio;
        }
        public string getColor()
        {
            return color;
        }
        
    }

    public class Tesla : Vehiculo
    {
        int kilometraje;  
        int asientos;
        int autonomia;
        int service;
        string duenio;
        
        const int autonomiaX = 560;
        const int asientosX = 7;
        const int serviceX = 1000;
        const int autonomiaS = 650;
        const int asientosS = 5;
        const int serviceS = 2000;
        const int autonomiaCybertruck = 800;
        const int asientosCybertruck = 6;
        const int serviceCybertruck = 3000;

        public Tesla(int anio, string color, int kilometraje, string duenio, string modelo) : base(anio, color)
        {
            this.kilometraje = kilometraje;
            this.duenio = duenio;  
            if (modelo == "X")
            {
                autonomia = autonomiaX;
                asientos = asientosX;
                service = serviceX;
            }
            else if (modelo == "S")
            {
                autonomia = autonomiaS;
                asientos = asientosS;
                service = serviceS;
            }
            else if (modelo == "Cybertruck")
            {
                autonomia = autonomiaCybertruck;
                asientos = asientosCybertruck;
                service = serviceCybertruck;
            }
        }

    }

    public class SpaceX : Vehiculo
    {
        int autonomia;
        int service;
        int horasDeVuelo;
        string empresa;
        const int autonomiaStarship = 500;
        const int serviceStarship = 1000;
        const int autonomiaFalcon9 = 200;
        const int serviceFalcon9 = 400;
        public SpaceX(int anio, string color, int horasDeVuelo, string empresa, string modelo) : base(anio, color)
        {
            this.horasDeVuelo = horasDeVuelo;
            this.empresa = empresa;
            if (modelo == "Starship")
            {
                autonomia = autonomiaStarship;
                service = serviceStarship;
            }
            else if (modelo == "Falcon 9")
            {
                autonomia = autonomiaFalcon9;
                service = serviceFalcon9;
            }
        }
    }
}