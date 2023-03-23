namespace practa6_2
{
    class TransportnoeSredstvo
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public TransportnoeSredstvo(string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
        }
    }
    class PolytechMachine : TransportnoeSredstvo
    {
        public void TurnMusic()
        {
            Console.WriteLine("Плохая музыка включена");
        }
        public PolytechMachine(string name, int speed) : base(name, speed)
        {
        }
    }
    class Airplane : TransportnoeSredstvo
    {
        public void PollinateField()
        {
            Console.WriteLine("Поле опылено");
        }
        public Airplane(string name, int speed) : base(name, speed)
        {
        }
    }
    class Mixer : TransportnoeSredstvo
    {
        public void MixConcrete()
        {
            Console.WriteLine("Бетон перемешан");
        }
        public Mixer(string name, int speed) : base(name, speed)
        {
        }
    }
    internal class programma
    {
        static void Main(string[] args)
        {
            TransportnoeSredstvo Car = new TransportnoeSredstvo("Cadillac", 210);
            PolytechMachine Polytech = new PolytechMachine("Политех-машина", 150);
            Polytech.TurnMusic();
            Airplane Samolet = new Airplane("Бумажный самолётик", 10);
            Samolet.PollinateField();
            Mixer betonomesh = new Mixer("МешалоБетонка", 120);
            betonomesh.MixConcrete();
            Console.ReadKey(true);
        }
    }
}