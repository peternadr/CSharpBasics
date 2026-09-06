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
            Book book1 = new Book();
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.GetType());
            #endregion
        }
    }
}
