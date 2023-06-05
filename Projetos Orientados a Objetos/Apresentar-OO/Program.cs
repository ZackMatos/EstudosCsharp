// See https://aka.ms/new-console-template for more information

using Apresentar_OO;
string nome;
string idade;

Pessoa pessoa = new Pessoa();

Console.WriteLine("Digite o seu nome: ");

nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");

idade = Console.ReadLine();

pessoa.Apresentar_se(nome,idade);

Console.ReadKey();


