try
{

    Console.WriteLine("Ingrese un numero");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese un numero");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese una   clave: +,-,*,/,R,E");
    string clave = Console.ReadLine();

    switch (clave)
    {
        case "+":
            double suma = num1 + num2;
            Console.WriteLine($"La suma es: {suma}");
            break;

        case "-":
            double resta = num1 - num2;
            Console.WriteLine($"La resta es: {resta}");
            break;

        case "*":
            double multiplicacion = num1 * num2;
            Console.WriteLine($"La multiplicacion es:{multiplicacion}");
            break;

        case "/":

            if (num2 != 0)
            {
                double division = num1 / num2;
                Console.WriteLine($"La division es: {division}");
            }
            else
            {
                Console.WriteLine("No se puede realizar la division ");
            }
            break;

        case "R":
            double raizcuadrada = Math.Sqrt(num1 * num2);
            Console.WriteLine($"la raiz cuadrada de {(num1 * num2)} es: {raizcuadrada}");
            break;

        case "E":
            double exponente = Math.Pow(num1, num2);
            Console.WriteLine($"El resultado del expnete {num1} a {num2} es: {exponente:f3}");
            break;


    }
}
   catch (FormatException)
{
    Console.WriteLine("Error: ingrese numeros validos ");
}

 
