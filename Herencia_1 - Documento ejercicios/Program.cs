using System;

class publicacion
{
    string titulo;
    float precio;
    public publicacion()
    {
        while(string.IsNullOrEmpty(titulo) == true)
        { 
            Console.WriteLine("Introduzca el titulo de la publicacion");
            titulo = Console.ReadLine();
            if(string.IsNullOrEmpty(titulo) == true)
            {
                Console.WriteLine("\nDigite un titulo valido\n");
            }
        }
        while(precio < 0.01)
        {
            try
            {
                Console.WriteLine("Precio de la publicacion");
                precio = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nDigite un precio valido\n");
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
        while(numPaginas < 1)
        {
            try
            {
                Console.WriteLine("Digite el numero de páginas para el libro de la publicacion");
                numPaginas = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nDigite un numero de paginas valido\n");
            }
            
        }
        
    }
    public void MostrarPublicacion()
    {
        Console.WriteLine("Num paginas: " + numPaginas);

    }
}
sealed class cd : publicacion
{
    public float timeLength;
    public cd()
    {
        Console.WriteLine("Digite el tiempo de reproducción para el audio-libro de la publicacion");
        timeLength = float.Parse(Console.ReadLine());
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
        libroobj.MostrarPublicacion();
        
    }
}