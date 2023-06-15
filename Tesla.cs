using System;
public class Tesla : Vehiculo
{
    double kilometraje;
    int asientos;
    int autonomia;
    int service;
    string modelo; 
    string duenio;
    double carga;
    // anio debe ser mayor a 2003
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
    public double calcularBateria()
    {
        return Math.Round(Math.Truncate(Convert.ToDouble(kilometraje / autonomia)) + (Convert.ToDouble(kilometraje / autonomia) - Math.Truncate(Convert.ToDouble(kilometraje / autonomia))), 2);
    }


}