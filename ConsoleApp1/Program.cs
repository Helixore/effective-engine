using ConsoleApp1;

internal class Program
{
    public void PreviousLabs()
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
        for (int i = 0; i < 20; i++)
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
    private static void Main(string[] args)
    {
        A a1 = new A();
        A a2 = new A();
        B b1 = new B();
        B b2 = new B();
        C c1 = new C();
        C c2 = new C();
        List<A> As = new List<A>();
        List<B> Bs = new List<B>();
        List<C> Cs = new List<C>();
        //Do listy A możemy dodać wszystkie klasy, ponieważ wszystkie dziedziczą z A, czyli B dziedziczy z A, a C dziedziczy z B, więc dziedziczy z A.
        As.Add(a1); As.Add(a2);
        As.Add(b1); As.Add(b2);
        As.Add(c1); As.Add(c2);
        //Do listy B nie dodamy klasy A, ponieważ nie jest ona klasą B ani z niej nie dziedziczy.
        //Bs.Add(a1); Bs.Add(a2);
        Bs.Add(b1); Bs.Add(b2);
        Bs.Add(c1); Bs.Add(c2);
        //Do listy C nie dodamy ani klasy A ani B, ponieważ nie są one klasami C ani z niej nie dziedziczą.
        //Cs.Add(a1); Cs.Add(a2);
        //Cs.Add(b1); Cs.Add(b2);
        Cs.Add(c1); Cs.Add(c2);
        Console.WriteLine("Lista A:");
        foreach (A a in As)
        {
            a.SayHello();
            Console.WriteLine(a.ThisTime());
        }
        //W pętli listy A dało się wykonać obie metody
        Console.WriteLine("Lista B:");
        foreach (B b in Bs)
        {
            b.SayHello();
            Console.WriteLine(b.ThisTime());
        }
        //W pętli listy B również dało sie wykonać obie metody
        Console.WriteLine("Lista C:");
        foreach (C c in Cs)
        {
            c.SayHello();
            Console.WriteLine(c.ThisTime());
        }
        //W pętli listy C również udało się wykonać obie metody
        //W każdej pętli udało sie wykonać obie metody, ponieważ każda klasa dziedziczyła metody z poprzedniej (ThisTime()) lub przesilała metodę z pierwszej klasy czyli A (SayHello())        
        Point p1 = new Point(1, 2);
        Point p2 = new Point(23, 51);
        Point p3 = new Point(321, 51784);
        Triangle_ t1 = new Triangle_(1,3,1325,3452,12315,734523,"Jeff");
        Triangle_ t2 = new Triangle_(1, 3, 346, 1672, 12315, 712341, "Geoff");
        Console.WriteLine(t1.ToString());
        bool bb2;
        Triangle_ bb1;
        bb1 = t1 > t2;
        bb2 = t1.Equals(t2);
        Console.WriteLine(bb1.ToString());
        Console.WriteLine(bb2.ToString());
    }
}