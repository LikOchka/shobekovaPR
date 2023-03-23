namespace practa6_4
{
    class Figures
    {

        public void calculatePerimeter(int length, int sides)
        {

            int result = length * sides;
            Console.WriteLine("Периметр: " + result);
        }
    }

    class Square : Figures
    {

        public int length = 48;
        public int sides = 4;
        public void calculateArea()
        {

            int area = length * length;
            Console.WriteLine("Площадь квадрата: " + area);
        }
    }

    class Rectangle : Figures
    {

        public int length = 28;
        public int breadth = 50;
        public int sides = 4;

        public void calculateArea()
        {

            int area = length * breadth;
            Console.WriteLine("Площадь прямоугольника: " + area);
        }
    }

    class programma
    {

        static void Main(string[] args)
        {

            Square s1 = new Square();
            s1.calculateArea();
            s1.calculatePerimeter(s1.length, s1.sides);


            Rectangle t1 = new Rectangle();
            t1.calculateArea();
            t1.calculatePerimeter(t1.length, t1.sides);

        }
    }
}