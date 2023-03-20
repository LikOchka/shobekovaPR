namespace prakta2_3
{
    class shifrovanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи текст для шифровки");
            string text = Console.ReadLine();
            Console.WriteLine("Введи ключ для шифровки");
            int key = Convert.ToInt32(Console.ReadLine());
            string encodedText = zashifr(text, key);
            Console.WriteLine("Текст успешно зашифрован: " + encodedText);
            Console.WriteLine("Расшифрованный текст: " + rashifr(encodedText, key));
            Console.ReadLine();
        }
        static string rashifr(string text, int key)
        {
            string rashifrText = "";
            for (int i = 0; i < text.Length; i++)
            {
                rashifrText += (char)(text[i] - key);
            }
            return rashifrText;
        }

        static string zashifr(string text, int key)
        {
            string zashifrText = "";
            for (int i = 0; i < text.Length; i++)
            {
               zashifrText += (char)(text[i] + key);
            }
            return zashifrText;
        }
    }
}