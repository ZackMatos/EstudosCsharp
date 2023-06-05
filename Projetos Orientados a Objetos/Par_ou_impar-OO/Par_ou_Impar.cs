using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_impar_OO
{
    public class Par_ou_Impar
    {
       
        public int Verificar(int x)
        {
            if (x % 2 == 0) 
            {
                Console.WriteLine($"O número {x} É PAR!!!");
            }
            else
            {
                Console.WriteLine($"O número {x} É ÍMPAR!!!");
            }
            return x;
        }

     
    }
}
