using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[100];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = i + 1;
        }

        int somaPares = 0;
        for (int i = 0; i < vetor.Length; i += 2)
        {
            somaPares += vetor[i];
        }

        Console.WriteLine($"A soma dos valores das posições pares do vetor é: {somaPares}");
    }
}
