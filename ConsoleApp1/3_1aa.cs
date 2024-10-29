using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        protected string title;
        public string Title { get => title; set {  title = value; } } //3_1g
        protected Person author;
        public Person Author { get => author; set { author = value; } } //3_1g
        protected DateTime data_wydania;
        public DateTime Data_wydania { get => data_wydania; set { data_wydania = value; } } //3_1g
        public Book(string v1, Person v2, DateTime v3)
        {
            this.title = v1;
            this.author = v2;
            this.data_wydania = v3;
        }
        public virtual string View()
        {
            return $"Book title: - {title} \n Author info: \n {author.View()} \n Data wydania: - {data_wydania}";
        }
    }
}
