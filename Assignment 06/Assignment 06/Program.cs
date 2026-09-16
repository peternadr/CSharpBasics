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
            //int pages = 400;

            //Console.WriteLine(pages); //400
            //Helper.AddBonusPages(ref pages);
            //Console.WriteLine(pages); //450
            //the value type was passed by reference, the method could modify the original variable, so the value of pages changed. 

            #endregion

            #region Question 08
            /*Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
afterward.*/

            // creat a double array and assign it values { 25.5, 40.0 }
            //double[] prices = { 25.5, 40.0 };

            //Console.WriteLine(prices.Length);//2
            //Helper.ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);//3

            #endregion

            #region Question 09
            /*Write a method bool TryGetPrice(string title, out double price) that returns true and sets
price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it
and print the price if found*/

            // declear a string title and assign it "Clean Code"
            //string title = "Clean Code";
            //// declear a double price
            //double price;

            //if(Helper.TryGetPrice(title, out price))
            //{
            //    Console.WriteLine(price); // 25.5
            //}

            #endregion

            #region Question 10
            /*Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
it once with only a title, and once passing both a title and pages.*/

            Helper.PrintBookInfo("clean book");
            Helper.PrintBookInfo("clean book", 400);

            #endregion
        }
    }
}
