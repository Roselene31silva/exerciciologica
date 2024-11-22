using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a idade da pessoa: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int idade) && idade >= 0)
            {

                if (idade <= 12)
                    Console.WriteLine("Essa é uma criança. ");
                else if (idade <= 17)
                    Console.WriteLine("Essa pessoa é um adolescente. ");
                else if (idade <= 59)
                    Console.WriteLine("essa pessoa é um adulto");
                else
                    Console.WriteLine("Essa pesso é um idoso. ");
            }
            else
            {
                Console.WriteLine("Por favor, insira uma idade válida (um numero inteiro)");
            }
            Console.ReadLine();
        }
    }
}
