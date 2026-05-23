using System.Reflection;

Console.WriteLine("Hello, World!");

// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("Valor de a: "+a);
// Console.WriteLine("Valor de b: "+b);

//Ejercicio 1
// Console.WriteLine("Ingrese numero mayor a 0: "); 
// string? texto = Console.ReadLine();

// int numero;

// if(int.TryParse(texto, out numero))
// {
//     if(numero > 0)
//     {
//         Console.WriteLine("Numero antes de ser invertido: "+ numero);
//         Console.WriteLine("Numero invertido: ");

//         while(numero > 0)
//         {
//             int aux = numero % 10;
//             Console.Write(aux);
//             numero = numero / 10;
//         }
//     }
//     else
//     {
//         Console.WriteLine("El numero no es mayor a 0.");
//     }
// }
// else
// {
//     Console.WriteLine("Lo que ingresaste no es un numero");
// }


//Ejercicio 2

Console.WriteLine("Ingrese primer numero: "); 
string? texto1 = Console.ReadLine();

Console.WriteLine("Ingrese segundo numero: "); 
string? texto2 = Console.ReadLine();

double num1; 
double num2;

if(double.TryParse(texto1, out num1) && double.TryParse(texto2, out num2))
{
    Console.WriteLine("Primer Numero: "+ num1);
    Console.WriteLine("Segundo Numero: "+ num2);

    Console.WriteLine("Ingrese numero de la operacion a hacer(1-Suma 2-Restar 3-Dividir 4-Multiplicar): "); 
    string? texto3 = Console.ReadLine();
    int operacion;
    double resultado;

    if(int.TryParse(texto3, out operacion) && (operacion > 0 || operacion < 5))
    {
        switch (operacion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("Resultado de la suma: "+ resultado);
            break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine("Resultado de la resta: "+ resultado);
            break;
            case 3:
                resultado = num1 / num2;
                Console.WriteLine("Resultado de la division: "+ resultado);
            break;
            case 4:
                resultado = num1 * num2;
                Console.WriteLine("Resultado de la multiplicacion: "+ resultado);
            break;
        }
    }
    else
    {
        Console.WriteLine("El dato ingresado de la operacion no es valido");
    }
}
else
{
    Console.WriteLine("Alguno de los datos ingresados no es un numero.");
}

//Ejercicio 3
Console.WriteLine("Ingrese un numero para calcular mejoras de CalculadoraV2:");
string? texto4 = Console.ReadLine();

double numero;

if(double.TryParse(texto4, out numero))
{
    Console.WriteLine("Valor absoluto: " + Math.Abs(numero));
    Console.WriteLine("Cuadrado: " + numero * numero);

    if(numero >= 0)
    {
        Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(numero));
    }
    else
    {
        Console.WriteLine("No se puede calcular raiz cuadrada de un numero negativo");
    }

    Console.WriteLine("Seno: " + Math.Sin(numero));
    Console.WriteLine("Coseno: " + Math.Cos(numero));
    Console.WriteLine("Parte entera: " + Math.Truncate(numero));
}
else
{
    Console.WriteLine("No ingreso un numero valido");
}

Console.WriteLine("Ingrese primer numero para comparar:");
string? texto5 = Console.ReadLine();

Console.WriteLine("Ingrese segundo numero para comparar:");
string? texto6 = Console.ReadLine();

double numero1;
double numero2;

if(double.TryParse(texto5, out numero1) && double.TryParse(texto6, out numero2))
{
    Console.WriteLine("Maximo: " + Math.Max(numero1, numero2));
    Console.WriteLine("Minimo: " + Math.Min(numero1, numero2));
}
else
{
    Console.WriteLine("Alguno de los datos ingresados no es un numero");
}