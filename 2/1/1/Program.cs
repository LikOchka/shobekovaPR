
namespace prakta2_1
{
    internal class programma
    {
        static void Main(string[] args)
        {
            CvadrUravnenIE equation = new CvadrUravnenIE(2, 4, -8);
            equation.GetRoots();
            Console.ReadKey(true);
        }
    }
    class CvadrUravnenIE
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double X1;
        private double X2;
        private double Discriminant()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            return D;
        }
        void CalculateRoots()
        {
            this.D = Discriminant();
            if (D > 0)
            {
                X1 = (-b + Math.Sqrt(D)) / (2 * a);
                X2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"X1 = {X1}");
                Console.WriteLine($"X2 = {X2}");
            }
            else if (D == 0)
            {
                X1 = -b / (2 * a);
                Console.WriteLine($"x = {X1}");
            }
            else
            {
                Console.WriteLine("В уравнении корней нет");
            }
        }
        public CvadrUravnenIE(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void GetRoots()
        {
            CalculateRoots();
        }
    }
}