namespace prakta3_6
{
    internal class programma
    {
            static void Main(string[] args)
        {
            Randomizzzee chisla = new Randomizzzee();
            for (int i = 0; i < 11; i++)
            {
                chisla.AddChislo();
            }
            Console.WriteLine(chisla.Dispersiya);
            Console.WriteLine(chisla.Otklon);
            Console.WriteLine(chisla.Mediana);
            Console.ReadKey(true);
        }
        class Randomizzzee
        {
            private List<int> numbersList = new List<int>();
            Random rand = new Random();
            private int n
            {
                set
                {
                    SetLength(value);
                }
            }
                        public double Otklon
            {
                get
                {
                    return CalculateStandardOtklon();
                }
            }
            public double Average
            {
                get
                {
                    return CalculateDisperiya();
                }
            }
            public double Dispersiya
            {
                get
                {
                    return CalculateVariance();
                }
            }
            public double Mediana
            {
                get
                {
                    return CalculateMedian();
                }
            }
            private void SetLength(int R)
            {
                R = numbersList.Count;
            }
            public void AddChislo()
            {
                numbersList.Add(rand.Next(102));
            }
            public void RemoveChislo(int number)
            {
                numbersList.Remove(number);
            }
            private double CalculateDisperiya()
            {
                int sum = 0;
                foreach (int number in numbersList)
                {
                    sum += number;
                }
                return sum / numbersList.Count;
            }
            private double CalculateVariance()
            {
                double sum = 0;
                foreach (int number in numbersList)
                {
                    sum += Math.Pow((number - Average), 2);
                }
                return Math.Round(sum / numbersList.Count, 2);
            }
            private double CalculateStandardOtklon()
            {
                CalculateVariance();
                return Math.Round(Math.Sqrt(Dispersiya), 2);
            }
            private double CalculateMedian()
            {
                numbersList.Sort();
                if (numbersList.Count % 2 == 0)
                {
                    return (numbersList[numbersList.Count / 2] + numbersList[numbersList.Count / 2 - 1]) / 2;
                }
                else
                {
                    double middle = numbersList.Count / 2;
                    middle = Math.Ceiling(middle);
                    return numbersList[Convert.ToInt32(middle)];
                }
            }
        }
    }
}