﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        public string ThisTime()
        {
            return DateTime.Now.ToString();
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Hello, user using class A!");
        }
    }
}
