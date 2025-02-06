using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        // Pedir al usuario que ingrese 10 números
        Console.WriteLine("Por favor, ingresa 10 números desordenados:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingresa el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar el arreglo de números
        Array.Sort(numeros);

        // Mostrar los números ordenados
        Console.WriteLine("Los números ordenados son:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
