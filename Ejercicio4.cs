using System;

class Ejercicio
{
    static void Main(String[]args)
    {
        Console.WriteLine("Ingrese un año ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year %4 == 0 && (year % 100 != 100 || year % 400 == 0))
        {
            Console.WriteLine("Es bisiesto");
        }
        else
        {
            Console.WriteLine("No es bisiesto");
        }
    }
}