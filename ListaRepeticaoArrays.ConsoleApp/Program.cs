using System;

namespace ListaRepeticaoArrays.ConsoleApp
{
    internal class Program
    {
        /*Exercício 1:
            • Desenvolver um algoritmo que leia a altura de 15 pessoas.Este
              programa deverá calcular e mostrar:
                a.A menor altura do grupo;
                b.A maior altura do grupo;*/
        static void Main(string[] args)
        {
            string[] historicoAlturas = new string[15];
            float[] floatHistoricoAlturas = new float[15];
            float maior = 0;
            float menor = 100;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite a sua altura pessoa numero: " + i);
                
                floatHistoricoAlturas[i] = Convert.ToSingle(Console.ReadLine());
                if (floatHistoricoAlturas[i] > maior)
                {
                    maior = floatHistoricoAlturas[i];
                }
                if(floatHistoricoAlturas[i] < menor)
                {
                    menor = floatHistoricoAlturas[i];
                }
            }
           
            Console.WriteLine("A Maior altura do grupo é: " + maior);
            Console.WriteLine("A Menor altura do grupo é: " + menor);
            Console.ReadLine();

        }
    }
}
