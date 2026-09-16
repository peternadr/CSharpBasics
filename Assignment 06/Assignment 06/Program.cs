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

            //Helper.PrintBookTitle("Clean Code");

            #endregion

            #region Question 05
            /*Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
int pages = 400; and print pages afterward. What do you expect to see, and why?*/

            // Define a variable of type int and assign it the value 400
            //int pages = 400;

            //Console.WriteLine(pages); // 400
            //Helper.AddBonusPages(pages);
            //Console.WriteLine(pages); // 400
            //Because a copy of the pages value was passed to the method, changing it didn't affect the original value.

            #endregion

            #region Question 06
            /*Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
see, and why?*/

            // creat a double array and assign it values { 25.5, 40.0 }
            //double[] prices = { 25.5, 40.0 };

            //Console.WriteLine(prices[0]); // 25.5
            //Helper.ApplyDiscount(prices);
            //Console.WriteLine(prices[0]); // 20.5
            // Because a reference to the object was passed to the method, the method could modify the object, so the value of the first element of the array changed.

            #endregion

            #region Question 07
            /*Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
Call it and print pages afterward. How is the result different from question 5?*/

            //Define a variable of type int and assign it the value 400
            int pages = 400;

            Console.WriteLine(pages); //400
            Helper.AddBonusPages(ref pages);
            Console.WriteLine(pages); //450
            //the value type was passed by reference, the method could modify the original variable, so the value of pages changed. 

            #endregion
        }
    }
}
