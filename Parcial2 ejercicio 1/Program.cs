using System;

class publicacion
{
    string titulo;
    float precio;
    public publicacion()
    {
        while (string.IsNullOrEmpty(titulo) == true)
        {
            Console.WriteLine("Introduzca el titulo de la publicacion");
            titulo = Console.ReadLine();
            if (string.IsNullOrEmpty(titulo) == true)
            {
                Console.WriteLine("Digite un titulo valido\n");
            }
        }
        while (precio < 0.01)
        {
            try
            {
                Console.WriteLine("Precio de la publicacion");
                precio = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite un precio valido\n");
            }
        }

    }
    public void MostrarPublicacion()
    {
        Console.WriteLine("Titulo: " + titulo);
        Console.WriteLine("Precio: " + precio);
    }
}
sealed class libro : publicacion
{
    int numPaginas;
    public libro()
    {
        while (numPaginas < 1)
        {
            try
            {
                Console.WriteLine("Digite el numero de páginas para el libro de la publicacion");
                numPaginas = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite un numero de paginas valido\n");
            }

        }

    }
    public void MostrarLibro()
    {
        Console.WriteLine("Num paginas: " + numPaginas);

    }
}
sealed class cd : publicacion
{
    float timeLength;
    public cd()
    {
        while(timeLength < 0.01)
        {
            try
            {
                Console.WriteLine("Digite el tiempo de reproducción para el audio-libro de la publicacion");
                timeLength = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite un tiempo de duracion valido\n");
            }
        }
        
    }
    public void MostrarCD()
    {
        Console.WriteLine("Tiempo: " + timeLength);

    }
}

class program
{
    static void Main()
    {
        libro libroobj = new libro();
        
        int seguir = 1;
        while(seguir == 1)
        {
            seguir = 0;
            libroobj.MostrarPublicacion();
            libroobj.MostrarLibro();
            try
            {
                Console.WriteLine("\nIntroduzca el numero 1 para ingresar mas datos\nIntroduzca cualquier otro numero para finalizar");
                seguir = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite una opcion valida");
            }
            Console.WriteLine("\n\n");
        }
    }
}