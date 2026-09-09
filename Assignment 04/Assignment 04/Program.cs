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

        // Declare string title = "clean code";
        string title = "clean code";

        // Call title.ToUpper() and store it in a new variable upperTitle
        string upperTitle = title.ToUpper();

        // Print both title and upperTitle to show that title did not change
        Console.WriteLine(title);
        Console.WriteLine(upperTitle); 
        #endregion
    }
}
