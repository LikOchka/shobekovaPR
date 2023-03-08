Car impala = new Car();
impala.name = "импала винчестеров";
impala.maxspeed = 200;
impala.Print();

Car mark = new Car();
mark.name = "марк заряженный";
mark.maxspeed = 230;
mark.Print();

Car jiguli = new Car();
jiguli.name = "жигули";
jiguli.maxspeed = 142;
jiguli.Print();

Car lada = new Car();
lada.name = "лада самара";
lada.maxspeed = 185;
lada.Print();

Console.WriteLine($"гонки");
if (mark.maxspeed > impala.maxspeed)
{
    Console.WriteLine($"марк заряженный пришел первым");
}

if (impala.maxspeed > lada.maxspeed)
{
    Console.WriteLine($"импала винчестеров пришла второй");
}

if (lada.maxspeed > jiguli.maxspeed)
{
    Console.WriteLine($"лада пришла третьей, жигуль четвертым");
}
class Car
{
    public string name;
    public int maxspeed;
    public void Print()
    {
        Console.WriteLine($"название автомобиля: {name}");
        Console.WriteLine($"максимальная скорость: {maxspeed} км/ч");
    }
}
