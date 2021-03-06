using System;
using System.IO;
class OnlyWhiteSpaceException : Exception
{
    public OnlyWhiteSpaceException(string str)
    {
        Console.WriteLine("Dato inválido. No se puede digitar solo espacios");
    }

}                                                                                                               
abstract class Evaluacion
{
    public string nombre, aula, instructor;
    public int creditos;
    public Evaluacion()
    {
        while(true)
        {
            try
            {
                Console.WriteLine("Digite su nombre");
                nombre = Console.ReadLine();
                if (string.IsNullOrEmpty(nombre) == true)
                {
                    throw new ArgumentNullException("Nombre", "Digita un nombre válido");
                }
                else if (string.IsNullOrWhiteSpace(nombre) == true)
                {
                    throw new OnlyWhiteSpaceException("");
                }
                break;
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch(OnlyWhiteSpaceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        while (true)
        {
            try
            {
                Console.WriteLine("Digite el aula");
                aula = Console.ReadLine();
                if (string.IsNullOrEmpty(aula) == true)
                {
                    throw new ArgumentNullException("Aula", "Digita un aula válida");
                }
                else if (string.IsNullOrWhiteSpace(aula) == true)
                {
                    throw new OnlyWhiteSpaceException("");
                }
                break;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (OnlyWhiteSpaceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        while (true)
        {
            try
            {
                Console.WriteLine("Digite el número de creditos");
                creditos = int.Parse(Console.ReadLine());
                if(creditos > 10 || creditos < 1)
                {
                    throw new ArgumentOutOfRangeException("Debes digitar un número de crédito dentro de los parámetros aceptados");
                }
                break;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        while (true)
        {
            try
            {
                Console.WriteLine("Digite el nombre de su instructor");
                instructor = Console.ReadLine();
                if (string.IsNullOrEmpty(instructor) == true)
                {
                    throw new ArgumentNullException("Instructor", "Digita un aula válida");
                }
                else if (string.IsNullOrWhiteSpace(instructor) == true)
                {
                    throw new OnlyWhiteSpaceException("");
                }
                break;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (OnlyWhiteSpaceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
    public virtual void DesplegarDatos()
    {
        Console.WriteLine("Nombre: {0}\nAula: {1}\nCréditos: {2}\nInstructor: {3}", nombre, aula, creditos, instructor);
    }
}
class Escuela : Evaluacion
{
    string NombreEscuela, file;
    public Escuela()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite el nombre de la escuela");
                NombreEscuela = Console.ReadLine();
                if (string.IsNullOrEmpty(NombreEscuela) == true)
                {
                    throw new ArgumentNullException("Nombre Escuela", "Digita un nombre válido");
                }
                else if (string.IsNullOrWhiteSpace(NombreEscuela) == true)
                {
                    throw new OnlyWhiteSpaceException("");
                }
                break;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (OnlyWhiteSpaceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (string.IsNullOrEmpty(NombreEscuela) == false && string.IsNullOrWhiteSpace(NombreEscuela) == false)
                {
                    Console.WriteLine("\nTodos los datos digitados son válidos\n");
                }
                file = ""
            }
            StreamWriter File = new StreamWriter("Texto.txt");
            File.Write("Escuela: {0}\nNombre: {1}\nAula: {2}\nCréditos: {3}\nInstructor: {4}", NombreEscuela, nombre, aula, creditos, instructor);
            File.Close();
        }
    }
    public override void DesplegarDatos()
    {
        Console.WriteLine("Escuela: " + NombreEscuela);
        base.DesplegarDatos();
    }
}
class Program
{
    static void Main()
    {
        Escuela colegioObj = new Escuela();
        colegioObj.DesplegarDatos();
    }
}