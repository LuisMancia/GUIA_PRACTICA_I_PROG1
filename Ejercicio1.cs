using System;

class Program
{
    static void Main(String[] args)

    {

        Console.WriteLine("Ingrese un numero");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese otro numero");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int numeroMayor = (numero1 - numero2) > 0 ? numero1 : numero2;

        Console.WriteLine("Entre " + (numero1) + " y " + (numero2) + " el mayor es :" + (numeroMayor));

        Console.WriteLine("Ingrese un numero");
        double numero5 = Convert.ToDouble(Console.ReadLine());
        if (numero5 > 0)
        {
            double raiz = numero5 * 1 / 3;
            Math.Round(raiz, 3);
            Console.WriteLine("la raiz cubica de " + numero5 + " es " + raiz);
        }
    }
}