using System;

class persona
{
    long cedula;
    string nombre;
    int  edad;
    char sexo;
    public persona()//Constructor para inicializar las propiedades
    {
        while (cedula < 1) {
            try
            {
                Console.WriteLine("Digite la cédula de la persona");
                cedula = long.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Introducir un numero válido");
                Console.WriteLine("");
            }
        }        
        Console.WriteLine("Digite el nombre de la persona");
        nombre = Console.ReadLine();
        while(edad < 1 || edad > 110)
        {
            try
            {
                Console.WriteLine("Digite la edad de la persona");
                edad = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite una edad válida");
                Console.WriteLine("");
            }
        }
        while (sexo != 'M' || sexo != 'F')
        {
            try
            {
                Console.WriteLine("Digite el sexo de la persona (M - Masculino & F - Femenino)");
                sexo = char.Parse(Console.ReadLine());
                if(sexo == 'M' || sexo == 'F')
                {
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Debe digitar el sexo en el formato que se especifica");
                Console.WriteLine("");
            }
        }
    }
    public void mostrar()//Método para desplegar los datos (mostrar)
    {
        Console.WriteLine("Cédula: " + cedula);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Sexo: " + sexo);
    }
    public void esMayorEdad()//Método para devolver si es mayor de edad o no 
    {
        if(edad > 17)
        {
            Console.WriteLine("La persona es mayor de edad");
        } else
        {
            Console.WriteLine("La persona es menor de edad");
        }
    }
}
class program
{
    static void Main()
    {
        persona personaobj = new persona();
        Console.WriteLine("");
        personaobj.mostrar();
        Console.WriteLine("");
        personaobj.esMayorEdad();
    }
}