using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Osoba_
    {
        public string? Imie;
        public string? Nazwisko;
        public string? Pesel;
        public Osoba_(string v1, string v2, string v3)
        {
            Imie = v1;
            Nazwisko = v2;
            Pesel = v3;
        }
        public void SetFirstName(string v)
        {
            Imie = v;
        }
        public void SetLastName(string v)
        {
            Nazwisko = v;
        }
        public abstract int GetAge();
        public abstract void GetGender();
        public abstract void GetEducationInfo();
        public abstract void GetFullName();
        public abstract bool CanGoAloneToHome();

    }
}
