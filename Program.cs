Console.WriteLine("Hello, World!");

// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("Valor de a: "+a);
// Console.WriteLine("Valor de b: "+b);

//Ejercicio 1
/*Console.WriteLine("Ingrese numero mayor a 0: "); 
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
}*/


//Ejercicio 4
//punto a
Console.WriteLine("Ingrese un texto: "); 
string cadena1 = Console.ReadLine();

Console.WriteLine("La longitud de la cadena es: " + cadena1.Length);

//punto b
Console.WriteLine("Ingrese otro texto para comparar: "); 
string cadena2 = Console.ReadLine();

string resultado = string.Concat(cadena1, cadena2);
Console.WriteLine("Cadenas concatenadas: " + resultado); 

//punto c
Console.WriteLine("Subcadena desde la posicion 0 hasta 3:");

if (cadena1.Length >= 3)
{
    string subcadena = cadena1.Substring(0, 3);
    Console.WriteLine(subcadena);
}
else
{
    Console.WriteLine("La cadena es muy corta para sacar una subcadena de 3 letras");
}

//punto d
Console.WriteLine("Ingrese primer numero:");
string texto1 = Console.ReadLine()!;

Console.WriteLine("Ingrese segundo numero:");
string texto2 = Console.ReadLine()!;

double num1;
double num2;

if (double.TryParse(texto1, out num1) && double.TryParse(texto2, out num2))
{
    double suma = num1 + num2;
    double resta = num1 - num2;
    double multiplicacion = num1 * num2;

    Console.WriteLine("La suma de " + num1 + " y de " + num2 + " es igual a: " + suma);
    Console.WriteLine("La resta de " + num1 + " y de " + num2 + " es igual a: " + resta);
    Console.WriteLine("La multiplicacion de " + num1 + " y de " + num2 + " es igual a: " + multiplicacion);

    if (num2 != 0)
    {
        double division = num1 / num2;
        Console.WriteLine("La division de " + num1 + " y de " + num2 + " es igual a: " + division);
    }
    else
    {
        Console.WriteLine("No se puede dividir por cero");
    }
}
else
{
    Console.WriteLine("Alguno de los datos ingresados no es un numero");
}

//punto e
Console.WriteLine("Caracteres de la cadena:");

foreach (char letra in cadena1)
{
    Console.WriteLine(letra);
}

//punto f
Console.WriteLine("Ingrese una palabra para buscar en la cadena:");
string palabra = Console.ReadLine()!;

if (cadena1.Contains(palabra))
{
    Console.WriteLine("La palabra aparece en la cadena");
}
else
{
    Console.WriteLine("La palabra no aparece en la cadena");
}

//punto g
Console.WriteLine("Cadena en mayusculas: " + cadena1.ToUpper());
Console.WriteLine("Cadena en minusculas: " + cadena1.ToLower());

//punto h
Console.WriteLine("Ingrese una cadena separada por comas. Ejemplo: rojo,azul,verde");
string cadenaSeparada = Console.ReadLine()!;

string[] partes = cadenaSeparada.Split(',');

Console.WriteLine("Partes separadas:");

foreach (string parte in partes)
{
    Console.WriteLine(parte);
}

//punto i
Console.WriteLine("Ingrese una suma simple. Ejemplo: 582+2");
string ecuacion = Console.ReadLine()!;

string[] numeros = ecuacion.Split('+');

if (numeros.Length == 2)
{
    double n1;
    double n2;

    if (double.TryParse(numeros[0], out n1) && double.TryParse(numeros[1], out n2))
    {
        double total = n1 + n2;
        Console.WriteLine("El resultado de " + ecuacion + " es: " + total);
    }
    else
    {
        Console.WriteLine("La ecuacion no tiene numeros validos");
    }
}
else
{
    Console.WriteLine("Por ahora solo se acepta una suma con el signo +");
}