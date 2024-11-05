using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IStudent : IOsoba
    {
        string? Uczelnia { get; set; }
        string? Kierunek { get; set; }
        string? Rok {  get; set; }
        int Semestr {  get; set; }
    }
    class StudentI : IStudent
    {
        public string? Uczelnia { get; set; }
        public string? Kierunek { get; set; }
        public string? Rok { get; set; }
        public int Semestr { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public StudentI(string v1, string v2, string v3, string v4,string v5, int v6)
        {
            Imie = v1;
            Nazwisko = v2;
            Uczelnia = v3;
            Kierunek = v4;
            Rok = v5;
            Semestr = v6;
        }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }
        public void WypiszPelnaNazweIUczelnie()
        {
            Console.WriteLine($"{ZwrocPelnaNazwe()} - {Semestr.ToString()}{Kierunek} {Rok} {Uczelnia}");
        }
    }
}
