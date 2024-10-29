using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Reviewer : Reader
    {
        public Reviewer(string v1, string v2, int v3) : base (v1, v2, v3)
        {
            this.firstName = v1;
            this.lastName = v2;
            this._wiek = v3;
        }
        public virtual string Wypisz()
        {
            Random rnd = new Random();
            string str = "";
            if (books.Count > 0)
            {
                foreach (var boo in books)
                {
                    str += boo.Title + ": " + Math.Round((rnd.NextDouble() * 10), 2).ToString() + "\n";
                }
                return str;
            }
            else
            {
                return "No books reviewed";
            }
            
        }
    }
}
