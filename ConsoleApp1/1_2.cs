using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Osoba
    {
        string imie
        { get => imie; set { if(value.Length >= 2) imie = value; } }
        string nazwisko
        { get => nazwisko; set { if (value.Length >= 2) nazwisko = value; } }
        int wiek
        { get => wiek; set { if(value > 0)  wiek = value; } }
        public Osoba(string v1, string v2, int v3)
        {
            imie = v1;
            nazwisko = v2;
            wiek = v3;
        }
        public string WyswietlInformacje()
        {
            string result = $"Imie: {imie} \n Nazwisko: {nazwisko} \n Wiek: {wiek.ToString()}";
            return result;
        }
    }
}
