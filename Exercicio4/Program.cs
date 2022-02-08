using System;

namespace Exercicio4
{
    internal class Program
    {
        /*Exercício 4:
        • Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
        calcule a tabuada de N.
        • Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
        10N.*/

        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA!");
            Console.WriteLine("Digite o numero da tabuada que deseja:");
            int nTabuada = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                
                int resultado = nTabuada * i;
                Console.WriteLine(nTabuada + " X " + i + " = " + resultado);
            }
            Console.ReadLine();
        }
    }
}
