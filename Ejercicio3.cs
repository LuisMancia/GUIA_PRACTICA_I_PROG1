int num = 0;
string resultado = string.Empty;
char opcion = 's';

    try
    {
        Console.WriteLine("Ingrese un numero: ");
        num = int.Parse(Console.ReadLine());
        resultado = num > 0 ? "Es positivo" : num < 0 ? "Es negativo" : num == 0 ? "Es nulo" : "";
        Console.WriteLine(resultado);
    }
    catch
    {
        Console.WriteLine("Error");
    }

Console.ReadKey();

