namespace LAB8FirsovaAlekseeva
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person person = new Person();
            //person.Name = "Ivan";
            //string personName = person.Name;
            //Console.WriteLine(personName);
            //Console.WriteLine(person.Age);
            //person.Age = 37;
            //Console.WriteLine(person.Age);
            //person.Age = -23;
            //Console.WriteLine(person.Age);
            //Console.WriteLine(person.Name);
            //person.Age = 37;
            //person.Print();
            //var apple = new Product { Name = "Яблоко", Price = 10.5m, Quantity = 5 };
            //var banana = new Product { Name = "Банан", Price = 7.2m, Quantity = -2 };
            //Console.WriteLine($"{apple.Name} x {apple.Quantity} = {apple.TotalPrice} Руб.");
            //Console.WriteLine($" {banana.Name} x {banana.Quantity} = {banana.TotalPrice} Руб.");
            //Hero hero = new Hero("Геральт", 120);
            //Console.WriteLine($"Имя героя: {hero.Name}\nУровень героя: {hero.Level}\nМана героя: {hero.Mana}\nСтатус: {hero.Status}");
            //hero.TakeDamage(50);
            //hero.Heal(30);
            //hero.TakeDamage(200);
            //hero.Heal(50);
            //Person timo = new Person();
            //timo.Print();

            //Person ahri = new();
            //Person brand = new("Brand");
            //Person darius = new("Darius", 25);
            //ahri.Print(); 
            //brand.Print(); 
            //darius.Print(); 

            //    int a = 5;
            //    int b = a; 
            //    b = 10;
            //    Console.WriteLine(a); 
            //    Console.WriteLine(b); 

            //    Person p1 = new Person();
            //    p1.name = "Denis";
            //    Person p2 =p1;
            //    p2.name = "Anton";
            //    Console.WriteLine(p1.name); 
            //    Console.WriteLine(p2.name);
            ////Base.Person tom = new ("Tom");
            //var p1 = new Point2D(10, 20);
            //var p2 = new Point2D(13, 24);
            //Console.WriteLine($"Расстояние: {p1.DistanceTo(p2):F2}");

            //Calculate(5);

            State state1 = new State();
            Country country1 = new Country();
        }
        struct State
        {
            public int x; public int y;
        }
        class Country
        {
            public int x; public int y;
        }
        //static void Calculate(int t)
        //  {
        //      object x = 6;
        //      int y = 7;
        //      int z = y + t;
        //  }

        //public struct Point2D
        //{
        //    public int X;
        //    public int Y;


        //    public Point2D(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //    public double DistanceTo(Point2D other)
        //    {
        //        int dx = X - other.X;
        //        int dy = Y - other.Y;
        //        return Math.Sqrt(dx * dx + dy* dy);
        //    }
        //}
    }
    namespace Base
    {


        class Company
        {
            string title;
            public Company(string title) => this.title = title;
            public void Print() => Console.WriteLine($"Компания: {title}");
        }


        //struct Person
        //{
        //{
        //    public string name;
        //    public int age;
        //   public void Print()
        //   {
        //        Console.WriteLine($"Имя:{name} Возраст: {age}");
        //   }
        //public string name = "Tom";
        //public int age = 1;
        //public Person() { }

        //public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
        //public string name; public int age;
        //public Person(string name = "Tom", int age = 1)
        //{
        //    this.name = name; this.age = age;
        //}
        //public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");

        //public string name;
        //public int age;
        //public Person()
        //{
        //    name = "Undefined";
        //    age = 18;
        //}
        //public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
        //string name;
        //public Person(string name) => this.name = name;
        //public void Print() => Console.WriteLine($"Имя: {name}");


        //}

    }




}
