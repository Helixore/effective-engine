using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
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

        Reader v2 = new Reader("Jan", "Kowalski", 19);
        Book b1 = new Book("The Catcher in the Rye", new Person("J.D", "Sallinger", 44), DateTime.Parse("16-07-1951"));
        Book b2 = new Book("The Outsider", new Person("H.P.", "Lovecraft", 70), DateTime.Parse("01-04-1926"));

        v2.books.Add(b1);
        Console.WriteLine(v2.View());
        Console.WriteLine(b1.View());
        //Console.WriteLine(v2.ViewBook());

        Person p = new Person("Anna", "Floryda", 69);


        Person o = new Reader("Janina", "Kowalska", 44);
        Console.WriteLine("\n" + o.View());

        Reviewer o1 = new Reviewer("Jan", "Skoczylas", 18);
        o1.books.Add(b1);
        o1.books.Add(b2);

        Reviewer o2 = new Reviewer("Stanisław", "Stanowski", 60);
        o2.books.Add(b1);
        o2.books.Add(b2);

        Console.WriteLine(o1.Wypisz());
        Console.WriteLine(o2.Wypisz());

        Console.WriteLine("------------------------------------------------------");

        people.Add(v2);
        people.Add(o1);
        people.Add(o2);
        people.Add(o);
        people.Add(p);

        foreach (Person human in people) //3_1g
        {
            Console.WriteLine(human.View());
        }


    }
}