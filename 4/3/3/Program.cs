namespace prakta4_3
{
    class programma
    {
        static void Main(string[] args)
        {
            Orc orc_1 = new Orc();
            Console.WriteLine(Orc.VsegoZolota);
            Orc orc_2 = new Orc();
            Orc orc_3 = new Orc();
            Console.WriteLine(Orc.VsegoZolota);
            Orc orc_4 = new Orc();
            Orc orc_5 = new Orc();
            Orc orc_6 = new Orc();
            Console.WriteLine(orc_6.UkrZoloto);
            Console.ReadKey(true);
        }
    }
    class Orc
    {
        private static int count;
        public static int VsegoZolota { get; private set; }
        public int UkrZoloto { get; private set; }
        public Orc()
        {
            count++;
            VsegoZolota += 2;
            if (count > 5)
            {
                UkrZoloto += 2;
            }
        }
    }
}