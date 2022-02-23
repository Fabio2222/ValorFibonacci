using System;

namespace Valor_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, i, nAnt = 0, nPost = 1, x;
            
            Console.WriteLine("Digite um valor!");

            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEssa e a sequencia de Fibonacci!");
            Console.WriteLine(x = 0);
            Console.WriteLine(nPost);
            

            for (i = 0; i <= valor; i++)
            {
                x = nAnt;
                nAnt = nPost;
                nPost = x + nAnt;
                Console.WriteLine(nPost);               

            }
            Console.WriteLine("\n\nClique enter para SAIR");
        }
    }
}






//.Escreva um programa que leia um valor e imprima a sequência de Fibonacci 
//usando o valor digitado como posição de parada