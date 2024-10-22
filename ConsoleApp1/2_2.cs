using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccount
    { 
        public decimal Saldo { get; private set; }
        public string Wlasciciel;
        public BankAccount(string v1, decimal v2)
        {
            Wlasciciel = v1;
            Saldo = v2;
        }
        public void Wplata(decimal kwota)
        {
            Saldo += kwota;
        }
        public void Wyplata(decimal kwota)
        {
            if (kwota < Saldo)
            {
                Saldo -= kwota;
            }
            else
            {
                return;
            }
        }
    }
}
