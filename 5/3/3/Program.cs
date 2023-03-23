namespace practa5_3
{
    interface IFilter
    {
        string Execute(string textLine);
    }
    class Digit_Filter : IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            char[] symbols = { ':', '.', ' ', ';', '-', '"', '(', ')', ',', '?', '!' };
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    class Letter_Filter : IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    internal class programma
    {
        static void Main(string[] args)
        {
            Digit_Filter stringLetters = new Digit_Filter();
            Console.WriteLine(stringLetters.Execute("На1м все2м к4он1е11ц н2а к5у6рс3ов3ой ра23б1о4т2е"));
            Letter_Filter stringDigits = new Letter_Filter();
            Console.WriteLine(stringDigits.Execute("А мо11же10т 9и н8е ко7не6ц, мо5же4т пр3орв2ёмся1?"));
            Console.ReadKey(true);
        }
    }
}