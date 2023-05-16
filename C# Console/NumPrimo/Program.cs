using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numeroDigitado = int.Parse(Console.ReadLine());
            int div = 0;
            int numeroAleatorio = numeroDigitado;
            while (numeroDigitado <= 0)
            {
                Console.WriteLine("Por favor, digite um número maior que 0:");
                numeroDigitado = int.Parse(Console.ReadLine());
                numeroAleatorio = numeroDigitado;
            }
            if (numeroDigitado == 1)
            {
                Console.WriteLine("O número 1 não é primo");
            }
            while (numeroAleatorio != 0)
            {
               if (numeroDigitado % numeroAleatorio == 0)
                {
                    div++;
                    numeroAleatorio--;
                }
               else
                {
                    numeroAleatorio--;
                }
                if (div == 2 && numeroAleatorio == 0)
                {
                    Console.WriteLine($"O número {numeroDigitado} é primo");
                }
                if (div > 2 && numeroAleatorio == 0)
                {
                    Console.WriteLine($"O número {numeroDigitado} não é primo");
                }
            }
            Console.ReadKey();
            
            
        }
    }
}
