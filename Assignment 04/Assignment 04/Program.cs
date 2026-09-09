using System.Drawing;
using System.Security.Cryptography;
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

        // Declare a string variable word1 and assign it the value "Clean Code".
        string word1 = "Clean Code";

        // Declare a string variable word2 and assign it the value "clean code".
        string word2 = "clean code";
        Console.WriteLine(ReferenceEquals(word1, word2)); // Output: False
        #endregion
    }
}
