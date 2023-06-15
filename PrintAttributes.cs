using System;
using System.Text;

public class PrintAttributes
{
    private readonly Dictionary<string, object> attributes = new Dictionary<string, object>();

    public PrintAttributes(params object[] args)
    {
        foreach (var arg in args)
        {
            attributes.Add(arg.GetType().Name, arg);
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        foreach (var kvp in attributes)
        {
            builder.Append($"{kvp.Key}: {kvp.Value}\n");
        }
        return builder.ToString();
    }

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