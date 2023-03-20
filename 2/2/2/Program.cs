namespace prakta2_2
{
    class nomer
    {
        internal class programma
        {
            static void Main(string[] args)
            {
                nomer num = new nomer();
                int number;
                for (int i = 1; i >= 0; i = num.GetNumber(number) + 1)
                {
                    Console.WriteLine($"Введи число {i}");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                Console.ReadKey(true);
            }
        }
        private int k = 0;
        private bool SetNumber(int nomer)
        {
            if (nomer == this.k + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetNumber(int nomer)
        {
            if (SetNumber(nomer))
            {
                this.k = nomer;
            }
            else
            {
                this.k = 0;
            }
            return this.k;
        }
    }
}