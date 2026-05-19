Console.WriteLine("Hello, World!");

// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("Valor de a: "+a);
// Console.WriteLine("Valor de b: "+b);

//Ejercicio 1
Console.WriteLine("Ingrese numero mayor a 0: "); 
string? texto = Console.ReadLine();

int numero;

if(int.TryParse(texto, out numero))
{
    if(numero > 0)
    {
        Console.WriteLine("Numero antes de ser invertido: "+ numero);
        Console.WriteLine("Numero invertido: ");

        while(numero > 0)
        {
            int aux = numero % 10;
            Console.Write(aux);
            numero = numero / 10;
        }
    }
    else
    {
        Console.WriteLine("El numero no es mayor a 0.");
    }
}
else
{
    Console.WriteLine("Lo que ingresaste no es un numero");
}
