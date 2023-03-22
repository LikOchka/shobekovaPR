namespace prakta4_2
{
    class programma
    {
        static void Main(string[] args)
        {
            Pacage package_1 = new Pacage("Лёгкая посылка", 2);
            Pacage package_2 = new Pacage("Утяжелённая посылка", 9);
            sending_service sendingService = new sending_service();
            sendingService.SendPackage(package_1);
            sendingService.SendPackage(package_2);
            Console.ReadKey(true);
        }
    }
    class Pacage
    {
        public int Weight
        {
            get;
            private set;
        }
        public string Pacage_Description
        {
            get;
            private set;
        }
        public Pacage(string description, int weight)
        {
            Pacage_Description = description;
            Weight = weight;
        }
    }
    class sending_service
    {
        private static int LimitWeight;
        private const int Limit = 12;
        public void SendPackage(Pacage package)
        {
            LimitWeight += package.Weight;
            if (LimitWeight >= Limit)
            {
                Console.WriteLine("Весь посылок слишком большой! Бан");
            }
            else
            {
                Console.WriteLine("{0} весом {1} фунтов успешно отправлена.", package.Pacage_Description, package.Weight);
            }
        }
    }
}