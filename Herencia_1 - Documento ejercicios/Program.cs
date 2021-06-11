using System;

class publicacion
{
    public string titulo;
    public float precio;
    public publicacion()
    {
        Console.WriteLine("Introduzca el titulo de la publicacion");
        titulo = Console.ReadLine();
        Console.WriteLine("Precio de la publicacion");
        precio = float.Parse(Console.ReadLine());
    }
    public void MostrarPublicacion()
    {
        Console.WriteLine("Titulo: " + titulo);
        Console.WriteLine("Precio: " + precio);
    }
}
class libro : publicacion
{
    public int numPaginas;
    public libro()
    {
        Console.WriteLine("Digite el numero de páginas para el libro de la publicacion");
        numPaginas = int.Parse(Console.ReadLine());
    }
    public void MostrarLibro()
    {
        Console.WriteLine("Num paginas: " + numPaginas);

    }
}
class cd : publicacion
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
        Console.WriteLine("");
        libroobj.MostrarPublicacion();
        libroobj.MostrarLibro();

    }
}