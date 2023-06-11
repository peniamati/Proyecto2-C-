using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

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
    public class PrintAttributes
    {
        private readonly Dictionary<string, object> attributes = new Dictionary<string, object>();

        public PrintAttributes(params object[] args)
        {
            foreach (var arg in args)
            {
                attributes.Add(arg.GetType().Name, arg);
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var kvp in attributes)
            {
                builder.Append($"{kvp.Key}: {kvp.Value}\n");
            }
            return builder.ToString();
        }

        public static PrintAttributes FromList(List<object> list)
        {
            var args = new object[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                args[i] = list[i];
            }
            return new PrintAttributes(args);
        }

        internal static object FromList(List<Vehiculo> vehiculos)
        {
            throw new NotImplementedException();
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
        public virtual double calcularBateria()
        {
            return 1.23;
        }

    }

    public class Tesla : Vehiculo
    {
        int kilometraje;  
        int asientos;
        int autonomia;
        int service;
        string modelo;
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
            this.modelo = modelo;
            if (modelo == "X")
            {
                this.autonomia = autonomiaX;
                this.asientos = asientosX;
                this.service = serviceX;
            }
            else if (modelo == "S")
            {
                this.autonomia = autonomiaS;
                this.asientos = asientosS;
                this.service = serviceS;
            }
            else if (modelo == "Cybertruck")
            {
                this.autonomia = autonomiaCybertruck;
                this.asientos = asientosCybertruck;
                this.service = serviceCybertruck;
            }
        }
        public int getKilometraje()
        {
            return this.kilometraje;
        }
        public string getDuenio()
        {
            return this.duenio;
        }
        public string getModelo()
        {
            return this.modelo;
        }
        public int getAsientos()
        {
            return this.asientos;
        }
        public int getService()
        {
            return this.service;
        }
        public override double calcularBateria()
        {
            return ((kilometraje / autonomia) - (kilometraje / autonomia)) * 100;
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
                this.autonomia = autonomiaStarship;
                this.service = serviceStarship;
            }
            else if (modelo == "Falcon 9")
            {
                this.autonomia = autonomiaFalcon9;
                this.service = serviceFalcon9;
            }
        }
        public override double calcularBateria()
        {
            return ((horasDeVuelo / autonomia) - (horasDeVuelo / autonomia)) * 100;
        }
    }
}