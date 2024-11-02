namespace _05_IntroToOOP
{
    /*
     *Accesss spetificators
     - private (default for field)
     - protected
     - public
     - internal
     - protected internal
     */
    public class MyClass
    {
        //class body
        //field and method
        private int number;
        protected internal int number2;
        public int number3;
        private string name;
        private const float PI = 3.14f;
        private readonly int id;
        public MyClass()
        {
            id = 10;
        }
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

    }
    class MyClass1
    {

    }
    class DerivedClass : MyClass { }//public
    partial class Point
    {
        public void SetX(int newX)
        {
            if (newX >= 0)
                this.xCoord = newX;
            else
                this.xCoord = 0;
        }
        public void SetY(int newY)
        {
            if (newY >= 0)
                this.yCoord = newY;
            else
                this.yCoord = 0;
        }
        public int GetX()
        {
            return xCoord;
        }
        public int GetY()
        {
            return yCoord;
        }
    }
    partial class Point
    {
        public void Print()
        {
            Console.WriteLine($"X : {xCoord} . Y : {yCoord}");
        }
        public override string ToString()
        {
            return $"X : {xCoord} . Y : {yCoord}";
        }
    }
    struct MyPoint//value
    {
        public int X;
        public int Y;
        public void Print()
        {
            Console.WriteLine($"X : {X} . Y : {Y}");
        }
    }
    //partial
    internal class Program
    {
        static void Main(string[] args)
        {
            //numbers = 0
            //references = null
            //bool = false
            Point @class = new Point();

            Point p = new Point(10,7);
            p.Print();
           
            Console.WriteLine(p.ToString());

            p.SetX(100);
            Console.WriteLine(p.ToString());


            p.SetY(12);
            Console.WriteLine(p.GetY());
            p.XCoord = 4000;//set
            int x= p.XCoord;
            Console.WriteLine(x);
            Console.WriteLine(p.XCoord);
            Console.WriteLine(p.ToString());

            p.Name = "2D_Point ";
            Console.WriteLine(p.Name);
            Console.WriteLine("---------------------");
            Point[]points = new Point[3];
            for (int i = 0; i < points.Length; i++)
            {
                try
                {
                    points[i].Age = int.Parse(Console.ReadLine()!);
                }
                catch (Exception ex)
                {

                    throw;
                }
               
                //Date = 2024-12-25

            }
            points[0] = new Point(10,7);    
            points[1] = new Point(1120,17);    
            points[2] = new Point(140,2);    


            foreach(Point point in points)
                Console.WriteLine(point);




        }
    }
}
