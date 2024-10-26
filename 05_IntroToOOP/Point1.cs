namespace _05_IntroToOOP
{
    partial class Point
    {
        private static int count;
        static Point()
        {
            count = 0;
        }

        public Point() : this(0, 0) { }
        public Point(int value) : this(value, value) { }
        public Point(int x, int y)
        {
            XCoord = x;
            YCoord = y;
            count++;
            //SetX(x);
            //SetY(y); 
        }
    }
}
