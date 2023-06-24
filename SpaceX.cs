using System;


public class SpaceX : Vehiculo
{ // clase que da forma a los vehiculos Space X
    int autonomia;
    int service;
    double horasDeVuelo;
    string empresa;
    string modelo;
    const int autonomiaStarship = 500;
    const int serviceStarship = 1000;
    const int autonomiaFalcon9 = 200;
    const int serviceFalcon9 = 400;
    public SpaceX(int anio, string color, double horasDeVuelo, string empresa, string modelo) : base(anio, color)
        // se comprueba el modelo de Space X y se agregan los atributos autonomia, service
    {
        this.horasDeVuelo = horasDeVuelo;
        this.empresa = empresa;
        this.modelo = modelo;
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

    // metodos gets 
    public int getAutonomia()
    {
        return this.autonomia;
    }
    public int getService()
    {
        return this.service;
    }
    public double getHorasDeVuelo()
    {
        return this.horasDeVuelo;
    }
    public string getEmpresa()
    {
        return this.empresa;
    }
    public string getModelo()
    {
        return this.modelo;
    }

    // metodos de la clase
    public double calcularEnteroBateria()
        // calculo de rendimiento de bateria
    {
        return Math.Truncate(Convert.ToDouble(horasDeVuelo / autonomia));
    }
    public double calcularPorcentajeBateria()
        // calcular la cantidad de bateria 
    {
        double numero = Math.Round(Convert.ToDouble(horasDeVuelo / autonomia) - Math.Truncate(Convert.ToDouble(horasDeVuelo / autonomia)), 2);
        return Math.Round(numero * 100, 2);
    }
}