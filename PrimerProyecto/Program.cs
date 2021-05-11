using System;

/*namespace PrimerProyecto
{
    class casa
    {
        string color = "Marrón";
        static void Main(string[] args)
        {
            casa micasa = new casa();
            Console.WriteLine(micasa.color);
        }
    }
}
public class casa
{
    public string color = "Blanco";
    public double precio = 25.00;
}
public class program
{
    public static void Main()
    {
        casa micasa = new casa();
        Console.WriteLine("Color: " + micasa.color);
        Console.WriteLine("Precio: " + micasa.precio);
}
}*/
public class cuenta
{
    public string nombre = "Candelier";
    public int cedula = 00007550822;
    public string banco = "Reservas";
    public string tipo_cuenta = "Ahorro";
    public int num_cuenta = 6021345;
    public int pin = 0000;

}
public class empleado
{
    public string nombre = "Candelier";
    public int cedula = 00007550822;
    public string empresa = "bugatti";
    public  string funcion = "seller";
    public double sueldo= 105000;
    public int num_cuenta = 6021345;
    

}
public class program
{
    public static void Main()
    {
        //Despliegue de datos de clase cuenta de banco
        cuenta micuenta = new cuenta();
        Console.WriteLine("Clase cuenta bancaria");
        Console.WriteLine("Nombre: " + micuenta.nombre);
        Console.WriteLine("Cedula: " + micuenta.cedula);
        Console.WriteLine("Banco: " + micuenta.banco);
        Console.WriteLine("Tipo de cuenta: " + micuenta.tipo_cuenta);
        Console.WriteLine("Numero de cuenta: " + micuenta.num_cuenta);
        Console.WriteLine("PIN: " + micuenta.pin);
        

        empleado miempleado = new empleado();
        Console.WriteLine("Clase empleado");
        Console.WriteLine("Nombre: " + miempleado.nombre);
        Console.WriteLine("Empresa: " + miempleado.empresa);
        Console.WriteLine("Funcion: " + miempleado.funcion);
        Console.WriteLine("Sueldo: " + miempleado.sueldo);
        Console.WriteLine("Numero de cuenta: " + miempleado.num_cuenta);

    }
}