namespace Proyecto2
{
    internal static class Program
    {
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

    public class Tesla
    {
        int anio;
        int kilometraje;
        string color;
        string duenio;
        int autonomia;
        int asientos;
        int service;
        const int autonomiaX = 560;
        const int asientosX = 7;
        const int serviceX = 1000;
        const int autonomiaS = 650;
        const int asientosS = 5;
        const int serviceS = 2000;
        const int autonomiaCybertruck = 800;
        const int asientosCybertruck = 6;
        const int serviceCybertruck = 3000;
        public Tesla(int anio, int kilometraje, string color, string duenio, string modelo)
        {
            this.anio = anio;
            this.kilometraje = kilometraje;
            this.color = color;
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

    public class SpaceX
    {
        int anio;
        int horasDeVuelo;
        string color;
        string empresa;
        int autonomia;
        int service;
        const int autonomiaStarship = 500;
        const int serviceStarship = 1000;
        const int autonomiaFalcon9 = 200;
        const int serviceFalcon9 = 400;
        public SpaceX(int anio, int horasDeVuelo, string color, string empresa, string modelo)
        {
            this.anio = anio;
            this.horasDeVuelo = horasDeVuelo;
            this.color = color;
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