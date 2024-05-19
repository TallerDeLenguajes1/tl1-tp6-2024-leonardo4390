using System;

Console.WriteLine("\nIngrese un numero float");
var numero = Console.ReadLine();

//remplazando . por , en caso de que ingrese asi
numero = numero.Replace(".",",");

//verificacion del si el numero es float
Console.WriteLine("------------------------------------");
if (float.TryParse(numero,out float valorFloat))
{
    //llamada de la funcion calculadorav2
    CalculadoraV2(valorFloat);
}else{
    Console.WriteLine("\nNo es un numero float");
}
//ingresando nuevos numeros
Console.WriteLine("\nIngrese un numero");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese otro numero numero");
int numero2 = Convert.ToInt32(Console.ReadLine());

//llamada funcion mayormenor
Console.WriteLine("------------------------------------");
MayorMenor(numero1,numero2);

static void CalculadoraV2(float numero)
{
    double radianes = numero * Math.PI/180.0;
    Console.WriteLine("\nEl valor absoluto es: " + Math.Abs(numero)
                    + "\nEl cuadrado es: " + (numero * numero)
                    + "\nLa raiz cuadrada es: " + Math.Sqrt(numero)
                    + "\nEl seno es: " + Math.Sin(radianes)
                    + "\nEl coseno es: " + (float)Math.Cos(radianes)
                    + "\nLa parte entera del float: " + Math.Truncate(numero));
}

static void MayorMenor(int numero1, int numero2)
{

    if (numero1 > numero2)
    {
        Console.WriteLine("\nEl maximo entre os dos ingresados es: " +
        numero1);
        Console.WriteLine("\nEl minimo entre os dos ingresados es: " +
        numero2);

    }else{
        if (numero2>numero1)
        {
            Console.WriteLine("\nEl maximo entre os dos ingresados es: "+ 
            numero2);
            Console.WriteLine("\nEl minimo entre os dos ingresados es: " +
            numero1);
        }
    }
}


