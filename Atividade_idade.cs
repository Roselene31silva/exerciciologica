using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaixaEtariaDeIdadeRevisada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            bool entradaValida = false;

            do
            {
                Console.Write("\nDigite a idade da pessoa: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out idade) && idade >= 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.Write("Entrada invalida. Tente novamente!\n");
                }
            } while (entradaValida);


            if (idade <= 12)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Essa pessoa é uma criança.");
            }
            else if (idade <= 17)
                Console.WriteLine("Essa pessoa é um Adolescente.");
            else if (idade <= 59)
                Console.WriteLine("Essa pessoa é um Adulto.");
            else
                Console.WriteLine("Essa pessoa é um Idoso.");

            {
                Console.WriteLine("Por favor, insira uma idade  válida (um número inteiro maior ou igual a zero).");
            }
            Console.ReadLine();

        }
    }
}

