using System.Security.Cryptography;

namespace _06_StructRefOutParams
{
    /*
         *Accesss spetificators
         - private 
         - public (default for field)
         - internal
         - protected internal
    */
    class MyClass
    {
      
    }
    partial struct Point
    {
        public int X;
     
        public void Print()
        {
            //cw+ TAB  =  Console.WriteLine();
            Console.WriteLine($" x = {X}. y = {Y}");
        }
        public override string ToString()
        {
            return $" x = {X}. y = {Y}";
        }
    }

    partial struct Point
    {
        public int Y;
    }
    //partial class Point
    //{
    //    public int X { get; set; }
    //    public void Print()
    //    {
    //        //cw+ TAB  =  Console.WriteLine();
    //        Console.WriteLine($" x = {X}. y = {Y}");
    //    }
    //    public override string ToString()
    //    {
    //        return $" x = {X}. y = {Y}";
    //    }
    //}

    //partial class Point
    //{
    //    public int Y { get; set; }
    //}

    internal class Program
    {
        //params
        static void MethodWithParams(string name, string name2, int avg1, int avg2,
            params int[] marks)
        {
            Console.WriteLine("------------" + name + "-------------");
            Console.WriteLine("------------" + name2 + "-------------");
            Console.WriteLine("Average 1 : " + avg1);
            Console.WriteLine("Average 2 : " + avg2);
            foreach (var mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine("\n\n");
        }
        //ref = &  - reference
        static void Modify(ref int num,ref string str,ref Point point )
        {
            num += 1;
            str += "!!!";
            point.X++;
            point.Y++;
        }        //out 

        static void GetCurrentTime(out int hour, out int minute, out int second)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;        
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();//new - create dynamic memory - CLR
            Point point = new Point();//invoke default constructor


            MyClass myClass1;
            Point point1;
            int a = 0; ;

            try
            {
                if(a == 0)
                {
                    throw new Exception("Can*t divide by zero");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(myClass);

            Console.WriteLine(point);
            //int h, m, s;
            ////Console.WriteLine($"{h}:{m}:{s}");
            //GetCurrentTime(out h, out m, out s);
            //Console.WriteLine($"{h}:{m}:{s}");
            //int num = 10;
            //string str = "Hello academy";
            //Point point = new Point() { X = 10, Y = 12 };
            //Console.WriteLine($"num = {num}");
            //Console.WriteLine($"str = {str}");
            //Console.WriteLine($"Point = {point}");
            //Modify(ref num,ref  str,ref point );
            //Console.WriteLine();
            //Console.WriteLine($"num = {num}");
            //Console.WriteLine($"str = {str}");
            //Console.WriteLine($"Point = {point}");



            ////params
            //int[] marks = { 11, 12, 5, 7, 8, 9, 10, 11, 12 };
            ////MethodWithParams("Olga", marks);
            ////MethodWithParams("Ivan", new int[] { 7,6,5,4,8,6,5,7});
            //MethodWithParams("Kateruna","Ivan",  7,6,5,4,8,6,5,7,12,11,12);




            //Point point = new Point();
            //point.Print();

            //_3D_object.Point point1 = new _3D_object.Point();
            //point1.Print();
        }
    }
}

namespace _3D_object
{
     struct Point
    {
        public int X;
        public int Y;
        public int Z;
        public void Print()
        {
            //cw+ TAB  =  Console.WriteLine();
            Console.WriteLine($" x = {X}. y = {Y} . z = {Z}");
        }
    }

}