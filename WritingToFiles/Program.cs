using System;
using System.IO;

namespace WritingToFiles
{

    //to write to files we need System.IO
    // File is a class of System.io;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("System.IO - Writing to files - writing to WritingToFiles\\bin\\Debug\\text.txt");

            string str = "string stringa yo yo! (felicità)";
            File.WriteAllText("text.txt", str);

            Console.ReadKey();

        }
    }
}
