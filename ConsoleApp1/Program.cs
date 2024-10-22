using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BankAccount account = new BankAccount("Jan Kowalski", 1000);
        account.Wplata(500);
        account.Wyplata(200);
        Console.WriteLine($"Saldo: {account.Saldo}");
        Student student = new Student("Kacper", "Chorazak");
        student.DodajOcene(5);
        student.DodajOcene(3);
        student.DodajOcene(4);
        student.DodajOcene(0);
        Console.WriteLine($"Średnia: {student.SredniaOcen}");
        Licz v1 = new Licz(5);
        v1.Dodaj(420);
        Console.WriteLine($"Stan V1: {v1.Sprawdz()}");
        List<int> list = new List<int>();
        for(int i = 0; i<20; i++)
        {
            list.Add(i);
        }
        Sumator sum = new Sumator(list);
        Console.WriteLine($"Suma: {sum.Suma()}");
        Console.WriteLine($"Suma liczb podzielnych przez 2: {sum.SumaPodziel2()}");

    }
}