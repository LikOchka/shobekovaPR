namespace practa5_2
{
    interface IHello
    {
        void SayHello();
    }
    class Russian : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class French : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Bonjour!");
        }
    }
    class Hindi : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Namaste!");
        }
    }
    class Finnish : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Terve!");
        }
    }
    internal class programma
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new French());
            greetings.Add(new Hindi());
            greetings.Add(new Finnish());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}