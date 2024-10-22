using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Licz
    {
        private decimal value;
        public Licz(decimal v1)
        {
            value = v1;
        }
        public decimal Sprawdz()
        {
            return value;
        }
        public void Dodaj(decimal addition)
        {
            value += addition;
        }
        public void Odejmij(decimal subtraction)
        {
            value -= subtraction;
        }
    }
}
