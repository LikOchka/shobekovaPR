namespace practa5_1
{
    interface IAnimal
    {
        void Voice();
    }
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав!");
        }
    }
    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }
    class Owl : IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тисе, я сплю!");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }
    class Cow : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Му-уу!");
        }
    }
    class Bober : IAnimal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine("ААААААА!");
            }
            else
            {
                Console.WriteLine("аааа(");
            }
        }
    }
    internal class TEST
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Мы гладим зверюшку, а она нам говорит:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Cow());
            myAnimals.Add(new Bober());
            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
}