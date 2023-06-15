using System;

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
