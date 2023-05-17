using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorouMenorque18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            while (idade <= 0)
            {
                //ForeGroundColor muda a cor das letras.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade inválida,digite uma idade real:");
                Console.ForegroundColor = ConsoleColor.White;
                idade = int.Parse(Console.ReadLine());
            }
            //Caso a idade da pessoa seja menor que 18 não irá ter permissão
            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permissão");
            }
            //Caso contrário (seja maior que 18) terá permissão.
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida");
            }
            Console.ReadKey();
        }
    }
}
