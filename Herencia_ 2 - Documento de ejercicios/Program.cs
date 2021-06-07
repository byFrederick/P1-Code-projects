using System;

class autos
{
    public string numSerieMotor;
    public string marca;
    public int anno;
    public float precio;
    public autos()
    {
        Console.WriteLine("Digite el numero de serie del motor");
        numSerieMotor = Console.ReadLine();
        Console.WriteLine("Marca del auto");
        marca = Console.ReadLine();
        Console.WriteLine("Año del vehiculo");
        anno = int.Parse(Console.ReadLine());
        Console.WriteLine("Precio del auto");
        precio = float.Parse(Console.ReadLine());
    }
}
class autos_vagonetas : autos
{
    public string cantPasajeros;
    public autos_vagonetas()
    {
        Console.WriteLine("Digite la cantidad de pasajeros");
        cantPasajeros = Console.ReadLine();
    }
}
class camionetas : autos
{
    public int cantCarga;
    public int cantEjes;
    public int rodado;
    public camionetas()
    {
        Console.WriteLine("Digite la capacidad de carga en Kg");
        cantCarga = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la cantidad de ejes de su vehiculo");
        cantEjes = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite el rodado de los neumáticos ");
        rodado = int.Parse(Console.ReadLine());
    }
}
class program
{
    static void Main()
    {
        autos_vagonetas auto_vagonetasobj = new autos_vagonetas();
        Console.WriteLine("");
        camionetas camionetasobj = new camionetas();
    }
}
