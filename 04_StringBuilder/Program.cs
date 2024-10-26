using System.Text;

namespace _04_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array.GroupBy(x => x).Where(x =>x.Count() == 1).First()
            string str = "hello";
        


            str += "!";         
            str += "hello";         
            str += "hello";         
            str += "hello";         
            str += "hello";         
            str += "hello";         
            str += "hello";         
            str += "hello";         

            StringBuilder builder = new StringBuilder();//as vector
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");

            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");

            builder.AppendLine("world");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");


            Console.WriteLine(builder);
            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");
            Console.WriteLine(builder);
        }
    }
}
