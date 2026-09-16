
namespace Assignment_06
{
    internal class Helper
    {
     
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        public static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        public static void AddBonusPages( ref int pages)
        {
            pages += 50;
        }

        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[]{ 10.0, 12.5, 15.0 };
            
        }

        public static bool TryGetPrice(string title, out double price)
        {
            bool result = false;
            price = 0.0;
            if(title == "Clean Code")
            {
                price = 25.5;
                result = true;
            }
            return result;
        }

        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book title is: {title}, Book pages is: {pages} ");
        }
    }
}
