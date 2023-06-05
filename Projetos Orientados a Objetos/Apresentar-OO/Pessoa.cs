using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Apresentar_OO
{
    public class Pessoa
    {
       
        public void Apresentar_se(string nome, string idade)
        {
            Console.WriteLine($"Olá meu nome é {nome} e tenho {idade} anos");
        }
    }
}
