using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Osoba
    {
        string imie;
        string nazwisko;
        int wiek;
        public Osoba(string v1, string v2, int v3)
        {
            if (v1.Length >= 2)
            {
                imie = v1;
            }
            else
            {
                return;
            }
            if (v2.Length >= 2)
            {
                nazwisko = v2;
            }
            else
            {
                return;
            }
            if (v3 > 0)
            {
                wiek = v3;
            }
            else
            {
                return;
            }
        }
        public string WyswietlInformacje()
        {
            string result = $"Imie: {imie} \n Nazwisko: {nazwisko} \n Wiek: {wiek.ToString()}";
            return result;
        }
    }
}
