using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class C : B
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello, user using class C!");
            base.SayHello(); //Ten skrawek kodu sprawi że zostanie również wywołana metoda z klasy z której dziedziczy C czyli B.
        }
    }
}
