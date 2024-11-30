using System.Diagnostics.CodeAnalysis;

namespace _10_Interfaces
{
    interface IWorker
    {
        string Name { get; set; }
        string WOrk();
        event EventHandler WorkEnded;
    }

    abstract class Human //: Object
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public override string ToString()
        {
            return $"{Surname}  {Name}. Birthday : {Birthdate.ToShortDateString()}";
        }
    }
    abstract class Employee :Human
    {
        public double Salary { get; set; }
        public string Position { get; set; }
        public override string ToString()
        {
            return base.ToString()+ $"\nSalary : {Salary}$. Position : {Position}";
        }
    }
    interface IWorkable
    {
        bool IsWorking { get; }
        string Work();
    }
    interface IManager
    {
        List<IWorkable> ListOfWorker { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }
    class Director : Employee, IManager//implementation(realize)
    {
        public List<IWorkable> ListOfWorker { get ; set ; }

        public void Control()
        {
            Console.WriteLine("Controlling work.....");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I count money....");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work");
        }
    }
    class Seller : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string Work()
        {
            return "Selling product!";
        }
    }
    class Cashier : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string Work()
        {
            return "Getting pay for product!!! ";
        }
    }
    class Administrator : Employee, IManager, IWorkable
    {
        public bool IsWorking => true;

        public List<IWorkable> ListOfWorker { get ; set ; }

        public void Control()
        {
            Console.WriteLine("Xaxaxaxaaxa. I am a bossss!!!");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I have so much money");
        }

        public void Organize()
        {
            Console.WriteLine("I must do your work!!!!!!!");
        }

        public string Work()
        {
            return "I do my boring work((((( ";
        }
    }

    interface IPerson
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IManager director = new Director()
            {
                 Name = "Bob",
                 Surname = "Tomson",
                 Birthdate = new DateTime(1990,12,5),
                 Position = "Director",
                 Salary = 4000
            };
            director.Organize();
            director.MakeBudget();
            director.Control();
            Console.WriteLine(director);
            Console.WriteLine();
            

            //Seller seller = new Seller() {
            IWorkable seller = new Seller() {
                Name = "Olga",
                Surname = "Ivanchuk",
                Birthdate = new DateTime(2000, 12, 5),
                Position = "Seller",
                Salary = 250
            };
            //seller.Salary = 2500;
            seller.Work();
            Console.WriteLine(seller);
            
            if (seller is Employee)
            {
                Console.WriteLine($"Seller salary : { (seller as Employee)!.Salary}");
            }


            director.ListOfWorker = new List<IWorkable>
            {
                seller,
                new Cashier
                {
                    Name = "Ivanka",
                    Surname = "Petruc",
                    Birthdate = new DateTime(1999, 10, 21),
                    Position = "Cashier",
                    Salary = 12000
                },
                new Seller
                {
                     Name = "Kolya",
                    Surname = "Oliunuk",
                    Birthdate = new DateTime(1998, 10, 21),
                    Position = "Seller",
                    Salary = 14000
                }
            };

            foreach (var item in director.ListOfWorker)
            {
                Console.WriteLine(item.Work()); ;

                if(item is Cashier)
                {
                    Console.WriteLine("He is cashier");
                }
            }
            //Multiple Interfaces
            Administrator admin = new Administrator();

            IManager manager = admin;
            manager.Organize();

            IWorkable worker = admin;
            worker.Work();

        }
    }
}
