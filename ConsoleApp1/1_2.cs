using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Osoba
    {
        string _imie;
        public string imie
        { get => _imie; set { if(value.Length >= 2) _imie = value; } }
        string _nazwisko;
        public string nazwisko
        { get => _nazwisko; set { if (value.Length >= 2) _nazwisko = value; } }
        int _wiek;
        public int wiek
        { get => _wiek; set { if(value > 0)  _wiek = value; } }
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
