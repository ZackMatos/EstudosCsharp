using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo");
            Console.WriteLine("Digite um número:");
            int numeroDigitado = int.Parse(Console.ReadLine());
            while (numeroDigitado < 0)
            {
                Console.WriteLine("Por favor, digite um número maior que 0");
                Console.WriteLine("Digite um número:");
                numeroDigitado = int.Parse(Console.ReadLine());
            }
            if (numeroDigitado % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
           
            Console.ReadKey();
            
            
        }
    }
}
