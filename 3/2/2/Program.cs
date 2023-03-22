namespace prakta3_2
{
    internal class programma
    {
        static void Main(string[] args)
        {
            SMSMessage sms = new SMSMessage("Дорогая Бритни Спирс, я прошу вас перестать выпускать свои песни, ведь у вас совершенно нет ни слуха ни харизмы, с наилучшими пожеланиями, А.");
            sms.SendMessage();
            Console.ReadKey(true);
        }
        class SMSMessage
        {
            private string message_text;
            public string MessageText
            {
                get
                {
                    return message_text;
                }
                private set
                {
                    message_text = NormalizeMessageText(value);
                }
            }
            private double Price
            {
                get
                {
                    return CalculatePrice();
                }
            }
            public SMSMessage(string text)
            {
                MessageText = text;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Отправлено сообщение '{message_text}' длиной {message_text.Length} символов и стоимостью {Price} руб.");
            }
            private double CalculatePrice()
            {
                if (message_text.Length < 65)
                {
                    return 1.5;
                }
                else
                {
                    int length = MessageText.Length - 65;
                    return 1.5 + length * 0.5;
                }
            }
            private string NormalizeMessageText(string text)
            {
                if (text.Length > 250)
                {
                    return text.Substring(0, text.Length - 250);
                }
                return text;
            }
        }
    }
}