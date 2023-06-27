using System;

/// <summary>
/// Representa un vehículo con atributos de año y color.
/// </summary>
public class Vehiculo
{
    int anio;
    string color;

    /// <summary>
    /// Inicializa una nueva instancia de la clase Vehiculo con el año y color especificados.
    /// </summary>
    /// <param name="anio">El año del vehículo.</param>
    /// <param name="color">El color del vehículo.</param>
    public Vehiculo(int anio, string color)
    {
        this.anio = anio;
        this.color = color;
    }

    /// <summary>
    /// Obtiene el año del vehículo.
    /// </summary>
    /// <returns>El año del vehículo.</returns>
    public int getAnio()
    {
        return anio;
    }

    /// <summary>
    /// Obtiene el color del vehículo.
    /// </summary>
    /// <returns>El color del vehículo.</returns>
    public string getColor()
    {
        return color;
    }

}
