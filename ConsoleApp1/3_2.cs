using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        string imie, nazwisko;
        List<int> oceny = new List<int>();
        public decimal SredniaOcen { get
            {
                return (decimal)oceny.Average();
            }
        }
        public Student(string v1, string v2)
        {
            imie = v1;
            nazwisko = v2;
        }
        public void DodajOcene(int ocena)
        {
            this.oceny.Add(ocena);
        }
        

    }
}
