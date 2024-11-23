namespace _08_Indexers
{
    class Laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Model : {Model}. Price : {Price}";
        }
    }
    class Shop
    {
        Laptop[] laptops;
        public Shop(int size)//3
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length; }
        }
        public Laptop GetLaptop(int index)
        {
            if (index >= 0 && index < laptops.Length)
            {
                return laptops[index];
            }
            else { throw new IndexOutOfRangeException(); }
        }
        public void SetLaptop(int index, Laptop laptop)
        {
            if (index >= 0 && index < laptops.Length)
            {
                laptops[index] = laptop;
            }           
        }
        public Laptop this[int index]//value
        {
            get
            {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                else { throw new IndexOutOfRangeException(); }
            } 
            set {

                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
            }
        }
        public Laptop this[string name]//value
        {
            get
            {
                foreach (var l in laptops)
                {
                    if( l.Model == name )
                        return l;
                }
                return null;
            }
            //private set
            //{
            //    for (int i = 0; i < laptops.Length; i++)
            //    {
            //        if (laptops[i].Model == name)
            //        {
            //            laptops[i] = value;
            //            break;
            //        }
            //    }
            //}
        }
        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                {
                    return i;
                }
            }
            return -1;
        }
        public Laptop this[double price]
        {
            get
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    return laptops[index];
                }
                throw new Exception("Incorrect price");
            }
            set
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    this[index] = value;
                }
            }
        }
    }
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MultArray multArray = new MultArray(2, 3);

            //for (int i = 0; i < multArray.Rows; i++)
            //{
            //    for (int j = 0; j < multArray.Cols; j++)
            //    {
            //        multArray[i, j] = i + j;//indexator - set
            //        Console.Write($"{multArray[i, j]} ");//indexator - get
            //    }
            //    Console.WriteLine();
            //}
            
            Shop shop = new Shop(3);
            try
            {
                //shop.SetLaptop(0, new Laptop() { Model = "HP", Price = 45000.99 });
                //Console.WriteLine(shop.GetLaptop(10));
                shop[0] = new Laptop() { Model = "HP", Price = 45000.99 };//set
                shop[1] = new Laptop() { Model = "ASUS", Price = 32000.99 };//set
                shop[2] = new Laptop() { Model = "DELL", Price = 12000.99 };//set
                Console.WriteLine(shop["DELL"]);
                //shop["DELL"] = new Laptop() {  Model = "Mac", Price=100000.33};
                Console.WriteLine(shop["Mac"]);
                //Console.WriteLine(shop[0]);//get
                for (int i = 0; i < shop.Length + 1; i++)
                {
                    Console.WriteLine(shop[i]);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            shop[45000.99] = new Laptop() { Model = "Lenovo", Price = 15000 };
            Console.WriteLine(shop[15000.00]);

            for (int i = 0; i < shop.Length; i++)
            {
                Console.WriteLine(shop[i]);
            }

        }
    }
}
