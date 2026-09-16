namespace Assignment_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            /*Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            the second price(index 1).*/

            // Create a one-dimensional array and assign it values 25.5 , 40.0 , 33.75
            //double[] prices = { 25.5, 40.0, 33.75 };

            //Console.WriteLine(prices[1]); // 40

            #endregion

            #region Question 02
            /*Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.*/

            // Creat a two-dimentional array and assign it the values shelf 0 : {3,5}, shelf 1 : {1,4}
            //int[,] shelfCopies =
            //{
            //    {3, 5 },
            //    {1, 4 }
            //};

            //Console.WriteLine(shelfCopies[1,0]); // 1

            #endregion

            #region Question 03
            /*Write a method called PrintWelcomeMessage that takes no parameters and prints
"Welcome to the Library!". Call it from Main.*/

            //Helper.PrintWelcomeMessage();

            #endregion

            #region Question 04
            /*Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
"Clean Code".*/

            Helper.PrintBookTitle("Clean Code");

            #endregion
        }
    }
}
