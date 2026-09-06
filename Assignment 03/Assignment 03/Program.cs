using System.Numerics;
using System.Timers;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01

            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            //Book book1 = new Book();
            //book1.Title = "My Book";
            //book1.Pages = 100;
            //object obj = book1;
            //Console.WriteLine(obj);
            #endregion

            #region Question 02
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            //Book book1 = new Book();
            //Console.WriteLine(book1.ToString());
            //Console.WriteLine(book1.Equals(book1));
            //Console.WriteLine(book1.GetHashCode());
            //Console.WriteLine(book1.GetType());
            #endregion

            #region Question 03
            //Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //Compile - time error — you can't put text (string) into an int variable.
            //int pages = 464;

            #endregion

            #region Question 04
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block
            //try
            //{
            //    int num1 = 10;
            //    int num2 = 0;
            //    int result = num1 / num2;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question 05
            //Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double d = pages;
            #endregion

            #region Question 06
            //Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int i = (int)price;
            #endregion
        }
    }
}
