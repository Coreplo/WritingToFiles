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
            Console.WriteLine(@"System.IO - Writing to files - writing to WritingToFiles\bin\Debug\text.txt");

            string str = "string stringa yo yo! (felicità)";
            File.WriteAllText("text.txt", str);

            string textFromFile = File.ReadAllText("text.txt");
            Console.WriteLine("Text read: "+textFromFile);

            //Some usefull File methods:

            //AppendAllText() - appends text to the end of the file.
            //Create() - creates a file in the specified location.
            //Delete() - deletes the specified file.
            //Exists() - determines whether the specified file exists.
            //Copy() - copies a file to a new location.
            //Move() - moves a specified file to a new location
            //all methods automatically close the file after having performed the operations


            Console.ReadKey();

        }
    }
}
