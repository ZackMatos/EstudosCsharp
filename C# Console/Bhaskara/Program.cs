using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de a:");

            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b:");

            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de c:");

            float c = float.Parse(Console.ReadLine());

            double valorDelta = ((Math.Pow(b, 2) - 4 * a * c));
            double bhaskara1 = (-b + Math.Sqrt(valorDelta)) / (2 * a);
            double bhaskara2 = (-b - Math.Sqrt(valorDelta)) / (2 * a);
            if (valorDelta < 0)
            {
                Console.WriteLine("Esta equação não possuí números reais");
            }
            if (valorDelta > 0)
            {
                Console.WriteLine($"Os resultados das equações são: {bhaskara1} e {bhaskara2}");
            }
            if (valorDelta == 0)
            {
                Console.WriteLine($"A equação possuí apenas um resultado real, sendo ele: {bhaskara1}");
            }
            Console.ReadKey();

        }
    }
}
