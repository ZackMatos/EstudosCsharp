using System.Reflection.Metadata.Ecma335;

namespace Par_ou_impar_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correto = 0;
           //Aprendendo a tratar exceções com try, catch, finally...
           while (correto == 0) { 
            try 
            {
                Console.WriteLine("Digite um número: ");
                int numero_digitado = Convert.ToInt32(Console.ReadLine());
                Par_ou_Impar par_ou_impar = new Par_ou_Impar();
                par_ou_impar.Verificar(numero_digitado);
                correto += 1;
            }
       
            catch (FormatException)
            {
                
                Console.WriteLine("Você não digitou um número inteiro...");
                continue;
            }
            
         





            Console.ReadKey();
            }
        }
    }
}