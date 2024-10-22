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
        student.DodajOcene(2);
        Console.WriteLine($"Średnia: {student.SredniaOcen}");

    }
}