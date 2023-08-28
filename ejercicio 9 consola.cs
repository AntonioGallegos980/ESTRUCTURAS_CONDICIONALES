// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el primer número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número: ");
int numero3 = int.Parse(Console.ReadLine());
int mayor = numero1;

if (numero2>mayor)
{
    mayor= numero2;
}
if (numero3 > mayor)
{
    mayor = numero3;
}
Console.WriteLine("el numero mayor es "+mayor);
