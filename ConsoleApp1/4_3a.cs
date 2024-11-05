using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IOsoba
    {
       string? Imie { get; set;}
       string? Nazwisko {  get; set;}
       string ZwrocPelnaNazwe();
       

    }
    class OsobaI : IOsoba
    {
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public OsobaI(string v1, string v2)
        {
            Imie = v1;
            Nazwisko = v2;
        }
        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
