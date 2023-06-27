using System;

/// <summary>
/// Clase Tesla
/// </summary>
public class Tesla : Vehiculo
{  
    double kilometraje;
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

    /// <summary>
    /// Constructor de la clase Tesla.
    /// </summary>
    /// <param name="anio">Año del vehículo (debe ser mayor al año de creación del modelo)</param>
    /// <param name="color">Color del vehículo</param>
    /// <param name="kilometraje">Kilometraje del vehículo</param>
    /// <param name="duenio">Dueño del vehículo</param>
    /// <param name="modelo">Modelo del vehículo</param>

    public Tesla(int anio, string color, double kilometraje, string duenio, string modelo) : base(anio, color)
    { 
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

    /// <summary>
    /// Obtiene el kilometraje del vehículo Tesla.
    /// </summary>
    /// <returns>Kilometraje del vehículo</returns>
    public double getKilometraje()
    {
        return this.kilometraje;
    }

    /// <summary>
    /// Obtiene la autonomía del vehículo Tesla.
    /// </summary>
    /// <returns>Autonomía del vehículo</returns>
    public int getAutonomia()
    {
        return this.autonomia;
    }

    /// <summary>
    /// Obtiene el dueño del vehículo Tesla.
    /// </summary>
    /// <returns>Dueño del vehículo</returns>
    public string getDuenio()
    {
        return this.duenio;
    }

    /// <summary>
    /// Obtiene el modelo del vehículo Tesla.
    /// </summary>
    /// <returns>Modelo del vehículo</returns>
    public string getModelo()
    {
        return this.modelo;
    }

    /// <summary>
    /// Obtiene la cantidad de asientos del vehículo Tesla.
    /// </summary>
    /// <returns>Cantidad de asientos del vehículo</returns>
    public int getAsientos()
    {
        return this.asientos;
    }

    /// <summary>
    /// Obtiene el servicio del vehículo Tesla.
    /// </summary>
    /// <returns>Servicio del vehículo</returns>
    public int getService()
    {
        return this.service;
    }

    /// <summary>
    /// Calcula la cantidad de veces que la batería ha sido recargada por completo.
    /// </summary>
    /// <returns>Número de veces de recarga completa de la batería</returns>
    public double calcularEnteroBateria()
    {      
        return Math.Truncate(Convert.ToDouble(kilometraje / autonomia));
    }
    /// <summary>
    /// Calcula el porcentaje de carga de la batería del vehículo Tesla.
    /// </summary>
    /// <returns>Porcentaje de carga de la batería</returns>
    public double calcularPorcentajeBateria()
    {   
        double numero = Math.Round(Convert.ToDouble(kilometraje / autonomia) - Math.Truncate(Convert.ToDouble(kilometraje / autonomia)), 2, MidpointRounding.ToEven);
        
        return Math.Round(numero * 100,2);
    }
}