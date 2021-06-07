﻿using System;

class fecha
{
    int mes, dia, anno; 
    public fecha(int mes, int dia, int anno)//Constructor para inicializar las tres piezas de info
    {
        this.mes = mes;
        if(mes > 12 || mes < 1)
        {
            this.mes = 1;
        }
        this.dia = dia;
        this.anno = anno;
    }
    public void obtenerDatos()//Método para obtener los datos de la fecha
    {
        Console.WriteLine("Digite el mes");
        mes = int.Parse(Console.ReadLine());
        if (mes > 12 || mes < 1)
        {
            mes = 1;
        }
        Console.WriteLine("Digite el dia");
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite el año");
        anno = int.Parse(Console.ReadLine());
    }
    public void desplegarDatos()//Método para desplegar los datos de la fecha
    {
        Console.WriteLine(mes + ", " + dia + ", " + anno);
    }
}
class program
{
    static void Main()
    {
        fecha fechaobj = new fecha(13, 1, 2002);
        fechaobj.desplegarDatos();
    }
}