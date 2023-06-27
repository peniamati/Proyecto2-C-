using System;
using System.Text;

/// <summary>
/// Representa un objeto que muestra los atributos en una representación de cadena.
/// </summary>
public class PrintAttributes
{   
    private readonly Dictionary<string, object> attributes = new Dictionary<string, object>();

    /// <summary>
    /// Inicializa una nueva instancia de la clase PrintAttributes con los atributos proporcionados.
    /// </summary>
    /// <param name="args">Los atributos a agregar.</param>
    public PrintAttributes(params object[] args)
    {
        foreach (var arg in args)
        {
            attributes.Add(arg.GetType().Name, arg);
        }
    }

    /// <summary>
    /// Genera una representación de cadena de los atributos almacenados en el objeto PrintAttributes.
    /// </summary>
    /// <returns>Una representación de cadena de los atributos.</returns>
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        foreach (var kvp in attributes)
        {
            builder.Append($"{kvp.Key}: {kvp.Value}\n");
        }
        return builder.ToString();
    }

    /// <summary>
    /// Crea una instancia de PrintAttributes a partir de una lista de objetos.
    /// </summary>
    /// <param name="list">La lista de objetos.</param>
    /// <returns>Una nueva instancia de PrintAttributes creada a partir de la lista de objetos.</returns>
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