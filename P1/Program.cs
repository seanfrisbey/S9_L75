/***********************************************************
 * Write a program that reads a text file and displays the
 * number of words.
 **********************************************************/


using System;
using System.IO;
using System.Linq;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputTextFile = File.ReadAllText(@"..\..\..\testFile.txt");
            var words = inputTextFile.Split(' ');
            Console.WriteLine("The number of words in the text file is {0}", words.Count());
        }
    }
}
