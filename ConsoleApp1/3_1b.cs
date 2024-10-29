using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Reader : Person
    {
        public List<Book> books = new List<Book>();

        public Reader(string v1, string v2, int v3) : base(v1, v2, v3)
        {
            this.firstName = v1; //3_1e
            this.lastName = v2; //3_1e
            this._wiek = v3; //3_1e
        }

        public string ViewBook()
        {
            if (this.books.Count > 0)
            {
                string tmp = "\n";
                foreach (var boo in books)
                {
                    tmp += " - "+ boo.Title + " \n";
                }
                return tmp;
            }
            else { return "No read books."; }
        }
        public override /*3_1d*/ string View() //3_1c
        {
            return $"First name: - {firstName} \n Last name: - {lastName} \n Wiek: - {_wiek.ToString()} \n Read books: {this.ViewBook()} \n";
        }

    }
}
