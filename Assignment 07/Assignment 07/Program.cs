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

            //book.Title = "Clean code";
            //Console.WriteLine(book.Title);
            #endregion

            #region Question 04
            /*Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
assign it Genre.Science, and print it.*/
            //book.genre = Genre.Science;
            //Console.WriteLine(book.genre);
            #endregion

            #region Question 05
            /*Using the Genre enum above, print the underlying int value of
Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.*/


            //Console.WriteLine((int)Genre.Fiction); // 1
            //Console.WriteLine((int)Genre.NonFiction); // 2
            //Console.WriteLine((int)Genre.Science); // 3


            #endregion

            #region Question 06
            /*Given int genreNumber = 1;, cast it into a Genre value and print the result.*/
            //book.genre = (Genre)1;
            //Console.WriteLine(book.genre); // Fiction
            #endregion

            #region Question 07
            /*Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.*/
            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString());
            #endregion

            #region Question 08
            /*Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
print the result.*/

            string genreText = "Science";
            Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(genre);

            #endregion
        }
    }
}
