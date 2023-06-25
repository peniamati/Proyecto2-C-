using System;

public class Vehiculo
    // clase vehiculo agrega anio, color al clase tesla, space x
{
    int anio;
    string color;
    public Vehiculo(int anio, string color)
    {
        this.anio = anio;
        this.color = color;
    }

    // gets de la clase Vehiculo
    public int getAnio()
    {
        return anio;
    }
    public string getColor()
    {
        return color;
    }

}
