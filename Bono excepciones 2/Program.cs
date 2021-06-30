using System;

class Cita
{
    string diaSemana;
    int hora;
    int minuto;
    string descripcion;
    public Cita(string diaSemana, int hora, int minuto, string descripcion)
    {
        try
        {
            if (diaSemana == "lunes" || diaSemana == "martes" || diaSemana == "miercoles" || diaSemana == "jueves" || diaSemana == "viernes" ||
                diaSemana == "sabado" || diaSemana == "domingo")
            {
                this.diaSemana = diaSemana;
            }
            else
            {
                this.diaSemana = "Vacio";
                throw new ArgumentException("El dia de la semana introducido no es válido\n");
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            if (hora < 0 || hora > 23)
            {
                this.hora = 0;
                throw new ArgumentException("La hora introducida no es válida\n");
            }
            else
            {
                this.hora = hora;
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            if (minuto < 0 || minuto > 59)
            {
                this.minuto = 0;
                throw new ArgumentException("El minuto introducida no es válido\n");
            }
            else
            {
                this.minuto = minuto;
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            if (string.IsNullOrEmpty(descripcion) == true)
            {
                this.descripcion = "Vacío";
                throw new ArgumentException("La descripcion introducida no es válida\n");
            }
            else
            {
                this.descripcion = descripcion;
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

    }
    public void DesplegarDatos()
    {
        Console.WriteLine("Datos de la cita\n\nDía de la semana: {0}\nHora: {1}\nMinuto: {2}\nDescripción de la cita: {3}",
            diaSemana, hora, minuto, descripcion);
    }
}
class Program
{
    static void Main()
    {
        Cita citaobj = new Cita("vierne", 14, 30, "Chequeo de prostata");
        citaobj.DesplegarDatos();
    }
}