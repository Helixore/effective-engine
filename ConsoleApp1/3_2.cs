using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Samochod
    {
        public string marka;
        public string model;
        public string nadwozie;
        public string kolor;
        public int rok_produkcji;
        public int przebieg { get => przebieg; set { if (value > 0) { przebieg = value; } }
    }
}
