namespace Assignment_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            /*Add a private string password = "secret"; field to a Book class. Try to print it from Main
(outside the class). What happens, and why?*/

            Book book = new Book();

            //Console.WriteLine(book.password); // error
            //we can not access password only in Book class

            #endregion

            #region Question 02
            /*Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
Why?*/

            //Console.WriteLine(book.copiesInStock);
            // Compile, We can access internal feild in the same project only

            #endregion

            #region Question 03
            /*Add a public string Title; field to Book. Set it and print it from Main.*/

            book.Title = "Clean code";
            Console.WriteLine(book.Title);
            #endregion
        }
    }
}
