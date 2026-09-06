namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01

            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            Book book1 = new Book();
            book1.Title = "My Book";
            book1.Pages = 100;
            object obj = book1;
            Console.WriteLine(obj.ToString());
            #endregion
        }
    }
}
