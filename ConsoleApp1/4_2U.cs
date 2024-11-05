using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Uczen : Osoba_
    {
        public string? Szkola;
        public bool MozeSamWracacDoDomu;
        public Uczen(string v1, string v2, string v3) : base(v1, v2, v3)
        {
            this.Imie = v1;
            this.Nazwisko = v2;
            this.Pesel = v3;
        }

        public override bool CanGoAloneToHome()
        {
            Console.WriteLine($"Can go home alone?: {MozeSamWracacDoDomu}");
            return MozeSamWracacDoDomu;
        }

        public override int GetAge()
        {
            int birthDate = Int32.Parse("20"+Pesel.Substring(0,2));
            DateTime time = DateTime.Now;
            return time.Year - birthDate;
        }

        public void SetSchool(string v)
        {
            Szkola = v;
        }
        public void ChangeSchool(string v)
        {
            if(Szkola != v)
            {
                Szkola = v;
            }
            else
            {
                return;
            }
        }
        public void SetCanGoHomeAlone(bool v)
        {
            MozeSamWracacDoDomu = v;
        }

        public override void GetEducationInfo()
        {
            Console.WriteLine($"Studies in {Szkola}");
        }

        public override void GetFullName()
        {
            Console.WriteLine($"Full name: {Imie} {Nazwisko}");
        }

        public override void GetGender()
        {
            int x = Int32.Parse(Pesel.Substring(9, 1));
            if (x % 2 == 0) { Console.WriteLine("I am a woman."); }
            else { Console.WriteLine("I am a man."); }

        }
    }
}
