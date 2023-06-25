using System;
public class Tesla : Vehiculo
{  // Instancia los vehiculos tesla, comprueba el modelo y da caracteristicas unicas 
    double kilometraje;
    int asientos;
    int autonomia;
    int service;
    string modelo; 
    string duenio;
    // anio debe ser mayor a la crecion de Tesla
    const int autonomiaX = 560;
    const int asientosX = 7;
    const int serviceX = 1000;
    const int autonomiaS = 650;
    const int asientosS = 5;
    const int serviceS = 2000;
    const int autonomiaCybertruck = 800;
    const int asientosCybertruck = 6;
    const int serviceCybertruck = 3000;

    public Tesla(int anio, string color, double kilometraje, string duenio, string modelo) : base(anio, color)
    { // Constructor en base al modelo, se agregan los atributos autonomia, asientos, service
        this.kilometraje = kilometraje;
        this.duenio = duenio;
        this.modelo = modelo;
        if (this.modelo == "Modelo X")
        {
            this.autonomia = autonomiaX;
            this.asientos = asientosX;
            this.service = serviceX;
        }
        else if (this.modelo == "Modelo S")
        {
            this.autonomia = autonomiaS;
            this.asientos = asientosS;
            this.service = serviceS;
        }
        else if (this.modelo == "Cybertruck")
        {
            this.autonomia = autonomiaCybertruck;
            this.asientos = asientosCybertruck;
            this.service = serviceCybertruck;
        }
    }
    // Gets de la clase
    public double getKilometraje()
    {
        return this.kilometraje;
    }
    public int getAutonomia()
    {
        return this.autonomia;
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

    // Metodos de la clase Tesla
    public double calcularEnteroBateria()
    {      // Calculo de rendimiento de bateria
        return Math.Truncate(Convert.ToDouble(kilometraje / autonomia));
    }
    public double calcularPorcentajeBateria()
    {    // Calcular la cantidad de bateria 
        double numero = Math.Round(Convert.ToDouble(kilometraje / autonomia) - Math.Truncate(Convert.ToDouble(kilometraje / autonomia)), 2, MidpointRounding.ToEven);
        
        return Math.Round(numero * 100,2);
    }


}