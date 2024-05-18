// See https://aka.ms/new-console-template for more information
/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.*/

Console.WriteLine("Ingrese un numero entero mayor a cero");

int numero = Convert.ToInt32(Console.ReadLine());
int digit = 0;
int invertido=0;
int numero2 = numero;

//verificacion si el numero es mayor a cero
if (numero > 0)
{
    //inversion del numero
    while (numero != 0)
    {
        digit = numero % 10;
        numero = numero /10;
        invertido = (invertido * 10) + digit;
    }
}else{
    Console.WriteLine("No se puede hacer la inversion");
}

//numero invertido
Console.WriteLine(invertido.ToString("D" + numero2.ToString().Length));


