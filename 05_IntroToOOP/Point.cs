namespace _05_IntroToOOP
{
    partial class Point
    {
        private int xCoord;
        //Properties
        public int XCoord//value = 4000
        {
            get
            {
                return xCoord;
            }
            set
            {
                if (value >= 0)
                    this.xCoord = value;
                else
                    this.xCoord = 0;

            }
        }

        private int yCoord;
        public int YCoord//int value = 4000
        {
            get
            {
                return yCoord;
            }
            set
            {
                if (value >= 0)
                    this.yCoord = value;
                else
                    this.yCoord = 0;

            }
        }

        //Auto-property = prop + TAB
        public string Name { get; set; }
        //------ as
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        public string Type { get; } = "2D";//readonly
        public string Address { get; set; }
        //Full property - propfull + TAB
        private int age;

        public int Age
        {
            get { return age; }
            set {
                if (value > 0)
                {
                    age = value;
                }
                else
                    { age = 0; }    
                
            }
        }      
    }
}
