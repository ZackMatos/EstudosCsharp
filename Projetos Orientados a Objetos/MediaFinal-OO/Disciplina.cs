using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaFinal_OO
{
    internal class Disciplina
    {
        private decimal Nota_01;
        private decimal Nota_02;

        private decimal CalcularMedia()
        {
         return (Nota_01 + Nota_02) / 2;
        }
        public decimal MostrarMedia(decimal nota_01, decimal nota_02)
        {
            Nota_01 = nota_01;
            Nota_02 = nota_02;
            return CalcularMedia();
        }
    }
}
