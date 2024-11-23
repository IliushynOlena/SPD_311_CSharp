using System.Security.Cryptography.X509Certificates;

namespace _09_Inheritance
{
    abstract class Person: Object
    {
        protected string name;
        private readonly DateTime birthdate;
        public Person()
        {
            name = "No name";
            birthdate = new DateTime();   
        }
        public Person(string n, DateTime b)
        {
            name = n;
            if (b > DateTime.Now)
            {
                birthdate = new DateTime();
            }
            else
                birthdate = b;            
        }
        public abstract void DoWork();
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}. DateBirthday : {birthdate.ToLongDateString()}");
        }
        public override string ToString()
        {
            return $"Name : {name}. DateBirthday : {birthdate.ToLongDateString()}";
        }
    }
    //class Name : BaseClass, Interface1, Interface2, Interface3
    class Worker: Person //public
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { this.salary = value >= 0 ? value : 0; }
        }
        public Worker(): base() 
        {
           Salary = 0;  
        }
        public Worker(string n, DateTime b, decimal s):base(n,b)
        {
            Salary = s;
        }
        public override void DoWork()
        {
            Console.WriteLine("Doing some work..........");
        }
        //new
        public override void Print()
        {
           base.Print();
            Console.WriteLine($"Salary : {Salary}");
        }
        public override string ToString()
        {
            return base.ToString() + $"Salary : {Salary}";
        }
    }
    //sealed
    sealed class Programmer : Worker
    {
        public int CodeLines { get; private set; }
        public Programmer() : base()
        {
            CodeLines = 0;
        }
        public Programmer(string n, DateTime d, decimal s) : base(n, d, s)
        {
            CodeLines = 0;
        }
        public sealed override  void DoWork()
        {
            Console.WriteLine("Write C# code!!!!");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Code lines {CodeLines}$");
        }
        public void WriteLines()
        {
            CodeLines++;
        }
    }
    class TeamLead : Worker
    {
        public int CountProjects { get; set; }
        //public override void DoWork()
        //{
        //    Console.WriteLine("Manage team project!");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Ivan",new DateTime(2000,12,5));
            //Console.WriteLine(person);

            Worker worker = new Worker("Vova", new DateTime(2001,5,7), 20000);
            worker.DoWork();
            worker.Print();


            Person[] persons = new Person[]
            {
                new Worker("Ivan",new DateTime(2000,12,5),1000),
                worker,
                new Worker("Oleg", new DateTime(1989,5,7), 15000),
                new Programmer("Mukola",new DateTime(1999,5,7),35000)
            };

            foreach (var item in persons)
            {
                item.Print();
                Console.WriteLine();
            }

            Programmer pr = null;
            // 1 - use cast()
            try
            {
                pr = (Programmer)persons[3];
                pr.WriteLines();

                pr.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // 2 - use as
            pr = persons[2] as Programmer;
            if (pr != null)
            {
                pr.WriteLines();

                pr.Print();
            }
            else { Console.WriteLine("Null object!!!"); }
            //3 - use is and as
            if (persons[3] is Programmer)
            {
                pr = persons[3] as Programmer;
                pr.WriteLines();

                pr.Print();
            }
            else { Console.WriteLine("Null object!!!"); }
        }
    }
}
