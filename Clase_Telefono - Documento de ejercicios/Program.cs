using System;

class telefono
{
    string modelo;
    string fabricante;
    float precio;
    string propietario;
    string bateriaModelo;
    float tiempoInactivo;
    float horasConversacion;
    float pantallaTamano;
    float pantallaColores;

    public telefono()
    {
        Console.WriteLine("Introduzca el modelo del telefono movil");
        modelo = Console.ReadLine();
        Console.WriteLine("Fabricante");
        fabricante = Console.ReadLine();
        Console.WriteLine("Precio");
        precio = float.Parse(Console.ReadLine());
        Console.WriteLine("Propietario");
        propietario = Console.ReadLine();
        Console.WriteLine("Modelo de la bateria");
        bateriaModelo = Console.ReadLine();
        Console.WriteLine("Introduzca el tiempo de inactividad");
        tiempoInactivo = float.Parse(Console.ReadLine());
        Console.WriteLine("Horas de conversacion");
        horasConversacion = float.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el tamano de la pantalla");
        pantallaTamano = float.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca la cantidad de colores de la pantalla");
        pantallaColores = float.Parse(Console.ReadLine());
    }
}
class program
{
    static void Main()
    {
        telefono telefonoobj = new telefono();
    }
}