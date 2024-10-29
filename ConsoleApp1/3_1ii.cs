using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DocumentaryBook : Book
    {
        public int howBoring;
        public DocumentaryBook(string v1, Person v2, DateTime v3) : base(v1, v2, v3)
        {
            this.Title = v1;
            this.Author = v2;
            this.Data_wydania = v3;
        }
        public override string View()
        {
            return $"Book title: - {title} \n Author info: \n {author.View()} \n Data wydania: - {data_wydania} \n How boring: {howBoring.ToString()} \n";
        }
    }
}
