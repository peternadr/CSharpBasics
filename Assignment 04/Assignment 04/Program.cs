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
        string title = "Clean Code";

        // Declare an integer variable pages and assign it the value 464.
        int pages = 464;

        // Print the values of title and pages in a single line using string concatenation.
        //Console.WriteLine("Book: " + title + ", Pages: " + pages);
        #endregion

        #region Question 06
        //Build the same sentence as above, but using string interpolation ($"...").

        //Console.WriteLine($"Book: {title}, Pages: {pages}");
        #endregion

        #region Question 07
        //Build the same sentence again, but using string.Format().

        Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));

        #endregion
    }
}
