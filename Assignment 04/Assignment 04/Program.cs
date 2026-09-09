using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Assignment_04;

internal class Program
{
    static void Main(string[] args)
    {
        #region Quesstion 01
        /*Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
        both title and upperTitle to show that title did not change.*/

        //// Declare string title = "clean code";
        //string title = "clean code";

        //// Call title.ToUpper() and store it in a new variable upperTitle
        //string upperTitle = title.ToUpper();

        //// Print both title and upperTitle to show that title did not change
        //Console.WriteLine(title);
        //Console.WriteLine(upperTitle);
        #endregion

        #region Question 02
        /*Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
        to check if they point to the same object in memory.*/

        //// Declare a string variable word1 and assign it the value "Clean Code".
        //string word1 = "Clean Code";

        //// Declare a string variable word2 and assign it the value "clean code".
        //string word2 = "clean code";
        //Console.WriteLine(ReferenceEquals(word1, word2)); // Output: False
        #endregion

        #region Question 03
        /*Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
        object.Print the final result.*/

        // //Create a StringBuilder
        //StringBuilder sb = new StringBuilder();

        //// Append the text "Book List"
        //sb.Append("Book List");

        //// Append " - Updated" onto the same object
        //sb.Append(" - Updated");

        //Console.WriteLine(sb); // Output: Book List - Updated
        #endregion

        #region Question 04
        /*Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
        Print the result.*/

        //// Use Replace() to change "Book List" into "Library"
        //sb.Replace("Book List", "Library");
        //Console.WriteLine(sb); // Output: Library - Updated
        #endregion

        #region Question 05
        /*Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
Pages: 464" using the + operator.*/

        // Declear a string variable title and assign it the value "Clean Code".
        //string title = "Clean Code";

        // Declare an integer variable pages and assign it the value 464.
        //int pages = 464;

        // Print the values of title and pages in a single line using string concatenation.
        //Console.WriteLine("Book: " + title + ", Pages: " + pages);
        #endregion

        #region Question 06
        //Build the same sentence as above, but using string interpolation ($"...").

        //Console.WriteLine($"Book: {title}, Pages: {pages}");
        #endregion

        #region Question 07
        //Build the same sentence again, but using string.Format().

        //Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));

        #endregion

        #region Question 08
        /*Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
        300, otherwise prints "Short Book".*/

        // Declare an integer variable pages and assign it the value 464.
        //int pages = 464;

        //if(pages > 300)
        //{
        //    Console.WriteLine("Long Book");
        //}
        //else
        //{
        //    Console.WriteLine("Short Book");
        //}
        #endregion

        #region Question 09
        /*Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
greater than 300 and isAvailable is true. Use the && operator.*/

        // Declare an integer variable pages and assign it the value 464.
        //int pages = 464;

        // Declare a boolean variable isAvailable and assign it the value true.
        //bool isAvailable = true;


        //if (pages > 300 && isAvailable)
        //{
        //    Console.WriteLine("You can borrow this book");
        //}
        #endregion

        #region Question 10
        /*Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.*/

        // Declare a string variable title and assign it the value "Refactoring".
        string title = "Refactoring";

        //switch (title)
        //{
        //    case "Clean Code":
        //        Console.WriteLine("Great choice!");
        //        break;
        //    case "Refactoring":
        //        Console.WriteLine("Nice pick!");
        //        break;
        //    default:
        //        Console.WriteLine("Never heard of it");
        //        break;


        //}
        #endregion

        #region Question 11
        /*Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
variable sizeLabel (same rule as question 8: long if pages > 300).*/

        // Declare an integer variable pages and assign it the value 464.
        int pages = 464;

        // Use the ternary operator to assign a message based on the value of pages.    
        //string Message = pages > 300 ? "Long Book" : "Short Book";
        //Console.WriteLine(Message);
        #endregion

        #region Question 12
        /*Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
to print each book with its position number, like 1. Clean Code.*/

        // Declare an array of strings called books that contains the titles "Clean Code", "The Pragmatic Programmer", and "Refactoring".
        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

        // Print books[] elements
        //for (int i = 0; i < books.Length; i++)
        //{
        //    Console.WriteLine($"position : {i + 1} Book : {books[i]}");
        //}
        #endregion

        #region Question 13
        /*Using the same books array, use a while loop to print every book title.*/

        //int i = 0;
        //while (i < books.Length)
        //{
        //    Console.WriteLine($"position : {i + 1} Book : {books[i]}");
        //    i++;
        //}
        #endregion

        #region Question 14
        /*Write a do-while loop that prints "Checking book..." exactly 3 times.*/

        //int i = 0;
        //do
        //{
        //    Console.WriteLine("Checking book...");
        //    i++;
        //} while (i < 2);
        #endregion

        #region Question 15
        /*Using the same books array, use a foreach loop to print every book title.*/
        //foreach (string book in books)
        //{
        //    Console.WriteLine($"Book : {book}");
        //}
        #endregion

        #region Question 16
        /*Using the same books array, loop through it and print each title, but stop completely (break) once
        you reach "Refactoring".*/

        //for (int i = 0; i < books.Length; i++)
        //{
        //    if (books[i] == "Refactoring")
        //    {
        //        break;
        //    }
        //    Console.WriteLine($"Book : {books[i]}");
        //}
        #endregion

        #region Question 17
        /*Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
continue, don't stop the loop).*/

        //for (int i = 0; i < books.Length; i++)
        //{
        //    if (books[i] == "The Pragmatic Programmer")
        //    {
        //        continue;
        //    }
        //    Console.WriteLine($"Book : {books[i]}");
        //}
        #endregion

        #region Question 18
        /*Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
use return to exit the method early instead of printing anything.*/

        PrintFirstBook();
        #endregion
    }
    static void PrintFirstBook()
    {
        string[] books = {};

        if (books.Length == 0)
        {
            
            return;
        }
        else
        {
            Console.WriteLine(books[0]);
        }
    }
}
