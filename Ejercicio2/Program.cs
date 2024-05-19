// See https://aka.ms/new-console-template for more information
using System;

char respuesta;
do
{
    //menu de operaciones
    Console.WriteLine("\n***Menu de operaciones***\n");
    Console.WriteLine("Ingrese una opcion:");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    //convirtiendo la opcion a un entero
    int opcion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nIngrese un numero");
    int numero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese otro numero");
    int numero2 = Convert.ToInt32(Console.ReadLine());
    //llamada de la funcion
    Operaciones(numero1,numero2,opcion); 
    //solicitando una nueva operacion
    Console.WriteLine("\nDesea hacer otro calculo (s/n)?");
    respuesta = (char)Console.Read();
    Console.ReadLine();
 
} while(respuesta == 's' || respuesta == 'S');





static void Operaciones(int numero1, int numero2, int opcion)
{
    switch (opcion)
    {
        case 1: Console.WriteLine("La suma es: " + (numero1 + numero2));
            break;
        case 2: Console.WriteLine("La resta es: " + (numero1 - numero2));
            break;
        case 3: Console.WriteLine("La multiplicacion es: " + (numero1 * numero2));
            break;
        case 4: double resultado = (double)numero1/numero2;
                Console.WriteLine("La division es: " + resultado);
            break;
        default:  Console.WriteLine("Operacion incorrecta");
            break;
    }
}