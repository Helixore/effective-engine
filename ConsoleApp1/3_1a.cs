using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string FirstName;
        public string firstName { get => FirstName; set { FirstName = firstName; } } //3_1e
        private string LastName;
        public string lastName { get => LastName; set { LastName = lastName; } } //3_1e
        private int wiek;
        public int _wiek { get => wiek; set { wiek = _wiek; } } //3_1e
        public Person(string v1, string v2, int v3) { 
            this.FirstName = v1;
            this.LastName = v2;
            this.wiek = v3;
        }
        public virtual /*3_1d*/ string View()
        {
            return $"First name: - {FirstName} \n Last name: - {LastName} \n Wiek: - {wiek.ToString()}";
        }
    }
    
}
