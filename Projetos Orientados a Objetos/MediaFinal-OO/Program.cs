namespace MediaFinal_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disciplina sociologia = new Disciplina();
            Console.WriteLine("Digite sua nota do 1ºBimestre: ");
            decimal nota1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite sua nota do 2º Bimestre: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nSua média é:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sociologia.MostrarMedia(nota1, nota2));


            Console.ReadKey();
        }
    }
}