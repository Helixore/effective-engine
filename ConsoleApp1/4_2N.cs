using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nauczyciel : Uczen
    {
        public string? TytulNaukowy;
        public List<Uczen> PodwladniUczniowie;
        public Nauczyciel(string v1, string v2, string v3) : base(v1, v2, v3)
        {
            this.Imie = v1;
            this.Nazwisko = v2;
            this.Pesel = v3;
            PodwladniUczniowie = new List<Uczen>();
        }
        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            foreach(Uczen uczen in PodwladniUczniowie)
            {
                if(uczen.GetAge() >= 12 || uczen.CanGoAloneToHome()) {
                    uczen.GetFullName();
                }
            }
        }
        public override void GetEducationInfo()
        {
            Console.WriteLine($"Education title: {TytulNaukowy}");
        }

    }
}
