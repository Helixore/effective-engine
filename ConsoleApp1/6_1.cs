using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Maths
    {
        Add = 0,
        Subtract = 1,
        Divide = 2,
        Multiply = 3
    };
    internal class Kalkulator
    {
        List<double> previousResults = new List<double>();
        public double x;
        public double y;
        int choice;
        Maths mathOperation;
        void SetX()
        {
            while (true)
            {
                try
                {
                    Console.Write("Podaj X: ");
                    x = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowa wartość liczbowa");
                }
            }
        }
        void SetY()
        {
            while (true)
            {
                try
                {
                    Console.Write("Podaj Y: ");
                    y = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowa wartość liczbowa");
                }
            }
        }
        double DoMath()
        {
            double result;
            switch (mathOperation)
            {
                case Maths.Add:
                    result = x + y;
                    previousResults.Add(result);
                    return result;
                case Maths.Subtract:
                    result = x - y;
                    previousResults.Add(result);
                    return result;
                case Maths.Multiply:
                    result = x * y;
                    previousResults.Add(result);
                    return result;
                case Maths.Divide:
                    try
                    {
                        result = (double)((decimal)x / (decimal)y);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Nie wolno dzielić przez 0");
                        return 0;
                    }
                    previousResults.Add(result);
                    return result;
                default:
                    throw new Exception("Incorrect math operation");
            }

        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Wybierz działanie: \n 1: Dodawanie \n 2: Odejmowanie \n 3: Dzielenie \n 4: Mnożenie");
                try
                {
                    choice = int.Parse(Console.ReadLine()) - 1;
                    SetX();
                    SetY();
                    mathOperation = (Maths)choice;
                    Console.WriteLine($"X={x}, Y={y} \n Math Operation = {mathOperation} \n Result: {DoMath()}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy wybór");
                }
            
            }
        }
    }
}
