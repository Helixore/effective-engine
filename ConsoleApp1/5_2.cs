using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sumator
    {
        private List<int> Liczby = new List<int>();
        public Sumator() { }

        public int Suma()
        {
            return Liczby.Sum();
        }
        public int SumaPodziel2()
        {
            return Liczby.Where(x => x % 2 == 0).Sum();
        }
        public int IleElementow()
        {
            return Liczby.Count();
        }
        public int[] liczby()
        {
            return Liczby.ToArray();
        }
        public int[] BetweenIndexes(int lowIndex, int highIndex)
        {
            return Liczby.Skip(lowIndex).Take(highIndex - lowIndex).ToArray();
        }
    }
}
