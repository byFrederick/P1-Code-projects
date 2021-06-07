using System;

class persona
{
    int cedula;
    string nombre;
    long edad;
    char sexo;
    public persona() //Constructor para inicializar los datos
    {
        Console.WriteLine("Digitar numero de cedula");
        while (cedula != 99999999999 && cedula != 00000000000)
        {
            try
            {
                cedula = (int)long.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digitar numero de cedula");
                cedula = (int)long.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Digitar nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Digitar su edad");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Digitar sexo - [F] o [M]");
        sexo = char.Parse(Console.ReadLine());
    }
    public void mostrar()//Metodo para mostrar los datos en pantalla
    {
        Console.WriteLine("Cedula: " + cedula);
        Console.WriteLine("Nombre: " + cedula);
        Console.WriteLine("Edad: " + cedula);
        if(sexo == char.Parse("M"))
        {
            Console.WriteLine("Sexo: Masculino");
        } else
        {
            Console.WriteLine("Sexo: Femenino");
        }
    }
    public void esMayorDeEdad()//Metodo para devolver un valor lógico si es mayor de edad o no
    {
        if(edad >= 18)
        {
            Console.WriteLine("Es mayor de edad: " + (edad >= 18));
        } else
        {
            Console.WriteLine("Es mayor de edad: " + (edad >= 18));
        }
    }
}
class program
{
    static void Main()
    {
        persona personaobj = new persona();
        personaobj.mostrar();
        personaobj.esMayorDeEdad();
    }
}