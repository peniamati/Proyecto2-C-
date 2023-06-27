using System;

/// <summary>
/// Clase SpaceX
/// </summary>
public class SpaceX : Vehiculo
{ 
    int autonomia;
    int service;
    double horasDeVuelo;
    string empresa;
    string modelo;
    const int autonomiaStarship = 500;
    const int serviceStarship = 1000;
    const int autonomiaFalcon9 = 200;
    const int serviceFalcon9 = 400;

    /// <summary>
    /// Constructor de la clase SpaceX.
    /// </summary>
    /// <param name="anio">Año del vehículo(Debe ser mayor al año de creacion del modelo)</param>
    /// <param name="color">Color del vehículo</param>
    /// <param name="horasDeVuelo">Horas de vuelo del vehículo</param>
    /// <param name="empresa">Empresa del vehículo</param>
    /// <param name="modelo">Modelo del vehículo</param>
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

    /// <summary>
    /// Obtiene la autonomía del vehículo SpaceX.
    /// </summary>
    /// <returns>Autonomía del vehículo</returns>
    public int getAutonomia()
    {
        return this.autonomia;
    }

    /// <summary>
    /// Obtiene el servicio del vehículo SpaceX.
    /// </summary>
    /// <returns>Servicio del vehículo</returns>
    public int getService()
    {
        return this.service;
    }

    /// <summary>
    /// Obtiene las horas de vuelo del vehículo SpaceX.
    /// </summary>
    /// <returns>Horas de vuelo del vehículo</returns>
    public double getHorasDeVuelo()
    {
        return this.horasDeVuelo;
    }

    /// <summary>
    /// Obtiene la empresa del vehículo SpaceX.
    /// </summary>
    /// <returns>Empresa del vehículo</returns>
    public string getEmpresa()
    {
        return this.empresa;
    }

    /// <summary>
    /// Obtiene el modelo del vehículo SpaceX.
    /// </summary>
    /// <returns>Modelo del vehículo</returns>
    public string getModelo()
    {
        return this.modelo;
    }

    /// <summary>
    /// Calcula la cantidad de veces que la batería ha sido recargada por completo.
    /// </summary>
    /// <returns>Número entero de la batería</returns>
    public double calcularEnteroCombustible()
    {
        return Math.Truncate(Convert.ToDouble(horasDeVuelo / autonomia));
    }

    /// <summary>
    /// Calcula el porcentaje del tanque del vehículo SpaceX.
    /// </summary>
    /// <returns>Porcentaje del combustible</returns>
    public double calcularPorcentajeCombustible()
    {
        double numero = Math.Round(Convert.ToDouble(horasDeVuelo / autonomia) - Math.Truncate(Convert.ToDouble(horasDeVuelo / autonomia)), 2);
        return Math.Round(numero * 100, 2);
    }
}