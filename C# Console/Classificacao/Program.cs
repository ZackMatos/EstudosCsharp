using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classificacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Programa no qual mostra sua classificação no "time" 
              a partir de seu nome e idade*/

            // Adicionando um título
            Console.Title = "Classificação dos Atletas";

            Console.WriteLine("Digite seu nome:");

            Console.ForegroundColor = ConsoleColor.Blue;

            string nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Digite sua idade:");

            Console.ForegroundColor = ConsoleColor.Yellow;

            int idade = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;

            while(idade < 0 || idade > 110)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor digite uma idade real:");
                Console.ForegroundColor = ConsoleColor.White;
                idade = int.Parse(Console.ReadLine());
            }

            if (idade < 11 && idade > 4)
            {
                Console.WriteLine($"{nome} tem {idade} e está na classificação " +
                    $"Infantil");
            }

            if (idade > 10 && idade < 16)
            {
                Console.WriteLine($"{nome} tem {idade} e está na classificação " +
                   $"Juvenil");
            }

            if (idade > 15 && idade < 21)
            {
                Console.WriteLine($"{nome} tem {idade} e está na classificação " +
                   $"Junior");
            }

            if (idade > 20 && idade < 26 )
            {
                Console.WriteLine($"{nome} tem {idade} e está na classificação " +
                   $"Profissional");
            }

            Console.ReadKey();
        }
    }
}
