namespace Repeticao_com_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Números Pares e Ímpares de 1 até 20
            for(int i = 1; i <= 20; i++)
            {
               if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} É PAR");
                }
                else
                {
                    Console.WriteLine($"{i} É ÍMPAR");
                }
            }
          
         

            Console.ReadKey();
        }
    }
}