/***********************************************************
 * Write a program that reads a text file and displays the
 * longest word in the file.
 **********************************************************/

using System;
using System.IO;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputTextFile = File.ReadAllText(@"..\..\..\testFile.txt");
            var words = inputTextFile.Split(' ');

            int longestWord = 0;
            for (int i = 1; i < words.Length; i++)
            {
                longestWord = (words[i].Length > words[i - 1].Length) ? i : i-1;
            }

            Console.WriteLine("The longest word in the text file is \"{0}\"", words[longestWord]);
        }
    }
}
