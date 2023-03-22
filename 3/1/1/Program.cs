namespace prakta3_1
{
    class Color
    {
        private int RED;
        private int GREEN;
        private int BLUA;

        public int red_
        {
            get { return RED; }
            set { RED = NormalizeColorValue(value); }
        }

        public int green_
        {
            get { return GREEN; }
            set { GREEN = NormalizeColorValue(value); }
        }

        public int blue_
        {
            get { return BLUA; }
            set { BLUA = NormalizeColorValue(value); }
        }


        public void DisplayColor()
        {
            Console.WriteLine($" {RED}, {GREEN}, {BLUA}");
        }

        public Color(int red, int green, int blue)
        {
            red_ = red;
            green_ = green;
            blue_ = blue;
        }

        public Color() { }
        static void Main(string[] args)
        {
            Color yellow = new Color(300, 300, 0);
            yellow.DisplayColor();

            Color pink = new Color();

            pink.red_ = 255;
            pink.green_ = -20;
            pink.blue_ = 147;

            pink.DisplayColor();

            Console.ReadKey();
        }
        private int NormalizeColorValue(int colorValue)
        {
            if (colorValue > 255)
            {
                return 255;
            }
            else if (colorValue < 0)
            {
                return 0;
            }

            return colorValue;
        }
    }
}