﻿using System;

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
}
class libro : publicacion
{
    public int numPaginas;
    public libro()
    {
        Console.WriteLine("Digite el numero de páginas para el libro de la publicacion");
        numPaginas = int.Parse(Console.ReadLine());
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
}
class program
{
    static void Main()
    {
        libro librobj = new libro();
        cd cdobj = new cd();
        
    }
}