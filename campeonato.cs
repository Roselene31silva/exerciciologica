using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int Posicao;
            bool entradaValida = false;

            // Laço que repete até a entrada ser válida
            do
            {
                Console.WriteLine("\nDigite a Classificação do time: ");
                string imput = Console.ReadLine();


                if (int.TryParse(imput, out Posicao) && Posicao > 0 && Posicao <= 20)
                {
                    entradaValida = true; // Marca a entrada com valida para sair do laço 
                }
                else
                {
                    Console.Write("Entrada invalida. Por Favor, tente novamente!\n");
                }
            } while (!entradaValida);


            if (Posicao <= 4)
                Console.WriteLine("Copa Libertadores");
            else if (Posicao <= 6)
                Console.WriteLine("Qualificatorias Libertadores");
            else if (Posicao <= 12)
                Console.WriteLine("Copa Sul-Americana");
            else if (Posicao <= 16)
                Console.WriteLine("Zona Morta");
            else
                Console.WriteLine("Rebaixamento");


            Console.ReadLine();


        }
    }
}
