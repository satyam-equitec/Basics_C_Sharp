using System.Text;
string ReverseString(string str)
{
    StringBuilder temp = new StringBuilder(str.Length);
    for (int i = str.Length-1;i >= 0; i--)
    {
        temp.Append(str[i]);
    }
    return temp.ToString();
}
Console.WriteLine(ReverseString("Satyam"));
 

/*
    /// <summary>
    /// Reverses the given string.
    /// </summary>
    /// <param name="str">The input string to be reversed.</param>
    /// <param name="temp">A temporary string (not needed, defaults to an empty string).</param>
    /// <returns>A new string with characters in reverse order.</returns>
    /// <remarks>
    /// This approach uses string concatenation (temp += str[i]), which is inefficient.
    /// Since strings are immutable in C#, each concatenation creates a new string in memory,
    /// leading to O(n²) time complexity due to repeated allocations.
    /// </remarks>
    static string ReverseString(string str, string temp = "")
    {
        /// <summary>
        /// Loops through the string in reverse order and appends each character to temp.
        /// </summary>
        for (int i = str.Length - 1; i >= 0; i--)
        {
            /// <remarks>
            /// Inefficient operation: temp += str[i] creates a new string in memory each time.
            /// Using StringBuilder would be more efficient.
            /// </remarks>
            temp += str[i];
        }

        /// <summary>
        /// Returns the reversed string.
        /// </summary>
        return temp;
    }

*/