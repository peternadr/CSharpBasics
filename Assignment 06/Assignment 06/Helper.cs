
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
    }
}
