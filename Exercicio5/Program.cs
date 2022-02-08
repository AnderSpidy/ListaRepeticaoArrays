using System;

namespace Exercicio5
{
    internal class Program
    {
        /*Exercício 5:
            • Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
            valores do cálculo de A! e o seu resultado.
            Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
            • Pesquise sobre “fatorial"*/

        static void Main(string[] args)
        {
            Console.WriteLine("FATORIAL!");
            Console.WriteLine("Digite o numero do fatorial que deseja:");
            int nFatorial = Convert.ToInt32(Console.ReadLine());
            int resultado = nFatorial;
            Console.WriteLine("====================");
            Console.Write(nFatorial + "! = ");
            
            for (int count = nFatorial-1; count != 0 ; --count)
            {
                if (count > 1)
                {
                    resultado = resultado * count;
                    Console.Write(count + " X ");
                }
                else
                {
                    Console.Write(count + " = ");
                }
            }
            Console.Write(resultado);
            Console.WriteLine("\n====================");
            Console.ReadLine();
        }
    }
}
