﻿namespace practa5_4
{
    interface IShare
    {
        void Draw(int size);
    }
    class VerticalLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("+");
            }
        }
    }
    class HorizontalLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("+");
            }
        }
    }
    class Square : IShare
    {
        public void Draw(int size)
        {
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }

        }
    }
    internal class programma
    {
        static void Main(string[] args)
        {
            List<IShare> shapes = new List<IShare>();
            shapes.Add(new VerticalLine());
            shapes.Add(new HorizontalLine());
            shapes.Add(new Square());
            foreach (IShare figure in shapes)
            {
                figure.Draw(5);
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}