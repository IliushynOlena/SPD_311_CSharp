
namespace _07_OverloadOperators
{
    class Point_3D
    {
        //private int x;
        //set(int value){x = value;}
        //get(){return x;}
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point_3D(): this(0,0,0) { }  
       
        public Point_3D(int x,int y,int z)
        {
            X = x; Y = y; Z = z;
        }
        public override string ToString()
        {
            return $"Point : x = {X}, y = {Y}, z = {Z}.";
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() : this(0, 0) { }

        public Point(int x, int y)
        {
            X = x; Y = y; 
        }
        //override ToString() from base class Object
        public override string ToString()
        {
            return $"Point : x = {X}, y = {Y}.";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        /*
//overload oprators
* ref and out  - now allow
public static return_type operator[symbol](parameters)
{
    //code
}
*/
        #region Uno operators
        public static Point operator-(Point p)
        {
            Point point = new Point()
            {
                X = p.X *-1,
                Y = p.Y *-1
            };
            return point ;
        }
        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p ;  
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion
        #region Binary Operators
        public static Point operator +(Point p1, Point p2)
        {
           Point res = new Point()
           {
               X = p1.X + p2.X, 
               Y = p1.Y + p2.Y
           };
            return res ;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return res;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return res;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return res;
        }
        #endregion
        #region Operator Equals
        public static bool operator ==(Point p1, Point p2)
        {
            //return p1.X == p2.X && p1.Y == p2.Y;
            return p1.Equals(p2);   
        }
        //in pair
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        #endregion
        #region Operator logic
        public static bool operator >(Point p1, Point p2)
        {

            return p1.X + p1.Y > p2.X + p2.Y;
        }
        //in pair
        public static bool operator <(Point p1, Point p2)
        {

            return !(p1> p2);
        }
        public static bool operator >=(Point p1, Point p2)
        {

            return p1.X + p1.Y >= p2.X + p2.Y;
        }
        //in pair
        public static bool operator <=(Point p1, Point p2)
        {

            return !(p1 >= p2);
        }
        #endregion
        #region true/false operators
        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0;
        }
        //in pair
        public static bool operator false(Point p)
        {
            return p.X == 0 || p.Y == 0;
        }
        #endregion
        #region Operator types
        public static implicit operator int(Point p)
        {
            return p.X + p.Y;
        }
        public static explicit operator double(Point p)
        {
            return p.X + p.Y;
        }
        public static explicit operator Point_3D(Point p)
        {
            return new Point_3D(p.X, p.Y,0);
        }
        #endregion

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;//int -> int
            double d = 6.7;//double -> double
            //implicit
            d = a;//int -> doble 5.00000000000000
            //explicit
            a = (int)d;//double -> int 5
            Point p = new Point(1,1);

            //a = p;// Point -> int
           // Console.WriteLine(a);
            d =(double) p;
            Console.WriteLine(d);

            Point_3D point_3D = (Point_3D)p;
            Console.WriteLine(point_3D);

            /*
            string str = "Hello";
            string str2 = "Hello";
            if (str.Equals(str2))
            {
                Console.WriteLine("Objects are equals");
            }
            else
            {
                Console.WriteLine("Objects are not equals");
            }
            Point point = new Point(0,0);
            
            Point point2 = new Point(4,9);
            if (point)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (point == point2)
            {
                Console.WriteLine("Point are equals");
            }
            else
            {
                Console.WriteLine("Point are not equals");
            }
            if (point >= point2)
            {
                Console.WriteLine("Point 1 > point 2 ");
            }
            else
            {
                Console.WriteLine("Point 1 < point 2");
            }




            if (point.Equals(point2))
            {
                Console.WriteLine("Objects are equals");
            }
            else
            {
                Console.WriteLine("Objects are not equals");
            }

            Console.WriteLine(point.ToString());
            point++;
            ++point; ;
            Console.WriteLine($"Point 1 : {point}");
            Console.WriteLine($"Point ++ : {++point}");
            Console.WriteLine($"Point ++ : {point++}");
            Console.WriteLine($"Point -- : {--point}");
            Console.WriteLine($"Point -- : {point--}");

            Point res = -point;
            Console.WriteLine($"Res point : {res}");
            Console.WriteLine($"Point 1 : {point}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Point 1 : {point}");
            Console.WriteLine($"Point 2 : {point2}");
            res = point + point2;
            Console.WriteLine($"Res point : {res}");
            res = point - point2;
            Console.WriteLine($"Res point : {res}");
            res = point * point2;
            Console.WriteLine($"Res point : {res}");
            res = point / point2;
            Console.WriteLine($"Res point : {res}");
            */
        }
    }
}
