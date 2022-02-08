using System;

namespace Exercicio2
{
    internal class Program
    {
        /*Exercício 2:
        • Escrever um algoritmo que gera e escreve os números ímpares entre 100
        e 200.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Os numero Ímpares de 100 a 200! ");
            Console.ReadLine();
            for (int i = 100; i < 200; i++)
            {
                int impar = i % 2;
                if(impar != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
