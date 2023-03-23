namespace zadacha_3
{
    class human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public human(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Employee : human
    {
        public string Post { get; set; }
        public Employee(string name, int age, char gender, string post)
            : base(name, age, gender)
        {
            Post = post;
        }
    }
    internal class programma
    {
        static void Main(string[] args)
        {
            human Pheshelets = new human("Инопрешелец", 221, 'М');
            Console.WriteLine(Pheshelets.Name);
            Employee Cow = new Employee("Корова домашняя", 10, 'Ж', "Муууу!");
            Console.WriteLine(Cow.Post);
            Console.ReadKey(true);
        }
    }
}