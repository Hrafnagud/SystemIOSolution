using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Selam\\Hello.txt";
            string destPath = @"C:\\Selam\\Destinationn.txt";
            bool fileDoesExists = false;
            fileDoesExists = File.Exists(@"C:\\Selam\\Hello.txt");
            if (!fileDoesExists)
            {
                CreateFile(@"C:\\Selam\\Hello.txt");
                Console.WriteLine("File Created Aye!");
            }
            else
            {
                Console.WriteLine("File already exists!");
            }

            Console.Write("Enter the text to append to the file: ");
            string text = Console.ReadLine();
            FileAppendTheText(@"C:\\Selam\\Hello.txt", text);

            Console.WriteLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Copying file..");
            FileCopy(path, destPath);
            //FileMove(@"C:\\Selam\\Hello.txt", @"C:\\Selamm\\Moved.txt");

            Console.WriteLine("Are you sure that you want to obliterate hello.txt?(Y/N): ");
            ConsoleKeyInfo myKey = new ConsoleKeyInfo();
            myKey = Console.ReadKey();
            Console.WriteLine();
            if (myKey.Key == ConsoleKey.Y)
            {
                File.Delete(path);
            }
            else if(myKey.Key == ConsoleKey.N)
            {
                Console.WriteLine("Obliteration cancelled :)");
            }
            else
            {
                Console.WriteLine("Erroneous Choice!");
            }
            Console.ReadKey();
        }

        private static void CreateFile(string path)
        {
            FileStream fileStream = File.Create(path);
            fileStream.Close();
        }

        private static void FileAppendTheText(string path, string text)
        {
            text = "\n" + text;
            File.AppendAllText(path, text);
        }

        private static void FileDelete(string path)
        {
            File.Delete(path);
        }

        private static void FileCopy(string sourceFile, string destinationFile)
        {
            File.Copy(sourceFile, destinationFile, true);   //override true, if given false, can not manipulate existing file content.
        }

        private static void FileMove(string sourceFile, string destinationFile)
        {
            File.Move(sourceFile, destinationFile);
        }
    }
}
