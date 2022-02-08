using System;

namespace Exercicio3
{
    internal class Program
    {
        /*Exercício 3:
            • Desenvolver um algoritmo que efetue a soma de todos os números
            ímpares que são múltiplos de três e que se encontram no conjunto dos
            números de 1 até 500.*/
        static void Main(string[] args)
        {
            Console.WriteLine("a soma dos Multiplos de três de 1 até 500 ");
            Console.ReadLine();
            int soma = 0;
            for (int i = 1; i < 500; i++)
            {
                int impar = i % 2;
                if (impar != 0)
                {
                    int multi = i;
                    int multiPor3 = i % 3;
                    if (multiPor3 ==0)
                    {
                        Console.WriteLine(i);
                        soma = soma + i;
                    }
                }
            }
            Console.WriteLine("A SOMA DESTES NUMEROS É: " + soma);
            Console.ReadLine();
        }
    }
}
