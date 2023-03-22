namespace prakta4_1
{
    class programma
    {
        static void Main(string[] args)
        {
            Spell abrakadabra = new Spell("Абракадабра", 60, "Замок открывается!");
            Spell shishelmishel = new Spell("Шишел Мышел", 40, "Предмет поднимается в воздух!");
            Magician koldun = new Magician("Колдун мудрый", 100);
            koldun.CastSpell(abrakadabra);
            koldun.CastSpell(shishelmishel);
            Console.ReadKey();
        }
    }
    class Spell
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        private string Effect { get; set; }
        public Spell(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void Use()
        {
            Console.WriteLine(Effect);
        }
    }
    class Magician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                Mana -= spell.Mana;
                Console.WriteLine("{0} колдует!", Name);
                spell.Use();
            }
            else
            {
                int mana = spell.Mana - Mana;
                Console.WriteLine(
                    "Для использования {0} не хватает {1} единиц маны. Хлебните зелья!",
                    spell.Name, mana);
            }
        }
    }
}