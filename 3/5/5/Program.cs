namespace prakta3_5
{
    internal class programma
    {
        static void Main(string[] args)
        {
            SMSMessage sms = new SMSMessage("Дорогая Бритни Спирс, я прошу вас перестать выпускать свои песни, ведь у вас совершенно нет ни слуха ни харизмы, с наилучшими пожеланиями, А.", 100, 3, 0.6);
            sms.SendMessage();
            Console.ReadKey(true);
        }
        class SMSMessage
        {
            private string message_text;
            private int max_length;
            private double initial_price;
            private double symv_price;
            public string MessageText
            {
                get
                {
                    return message_text;
                }
                private set
                {
                    message_text = NormalizeMessageText(value, max_length);
                }
            }
            public int MaxLength
            {
                get
                {
                    return max_length;
                }
                private set
                {
                    max_length = value;
                }
            }
            public double InitialPrice
            {
                get
                {
                    return initial_price;
                }
                private set
                {
                    initial_price = value;
                }
            }
            public double SymbolPrice
            {
                get
                {
                    return symv_price;
                }
                private set
                {
                    symv_price = value;
                }
            }
            private double Price
            {
                get
                {
                    return CalculatePrice(initial_price, symv_price);
                }
            }
            public SMSMessage(string text, int length, double initialprice, double symbolprice)
            {
                MessageText = text;
                MaxLength = length;
                InitialPrice = initialprice;
                SymbolPrice = symbolprice;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Отправлено сообщение '{message_text}' длиной {message_text.Length} символов и стоимостью {Price} руб.");
            }
            private string NormalizeMessageText(string text, int length)
            {
                if (text.Length > length)
                {
                    return text.Substring(0, text.Length - length);
                }
                return text;
            }
            private double CalculatePrice(double initialprice, double symbolprice)
            {
                if (message_text.Length < 65)
                {
                    return initialprice;
                }
                else
                {
                    int length = MessageText.Length - 65;
                    return initialprice + length * symbolprice;
                }
            }
        }
    }
}