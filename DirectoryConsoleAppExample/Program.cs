using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\\Emre";
                DirectoryInfo dir = Directory.CreateDirectory(path);
                while (true)
                {

                    Console.WriteLine("Choose the operation that you would like to perform.");
                    Console.WriteLine("1)Remove Folder.\n2)Move Folder.\n3)Exit.");
                    bool flag = int.TryParse(Console.ReadLine(), out int enteredNumber);
                    if (flag)
                    {
                        if (enteredNumber == 1)
                        {
                            Console.WriteLine("Are you sure you want to remove chosen directory?: ");
                            ConsoleKeyInfo myKey = new ConsoleKeyInfo();
                            myKey = Console.ReadKey();
                            Console.WriteLine();

                            if (myKey.Key == ConsoleKey.Y)
                            {
                                if (Directory.Exists(path))
                                {
                                    Console.WriteLine($"Deleting directory {path}..");
                                    Directory.Delete(path);
                                    Console.WriteLine("Directory has been removed successfuly!");
                                }
                                else
                                {
                                    Console.WriteLine("You can't remove directory which doesn't exist!");
                                }
                            }
                            else if (myKey.Key == ConsoleKey.N)
                            {
                                Console.WriteLine("Directory removal process has been cancelled!");
                            }
                            else
                            {
                                throw new Exception("You can choose either 'Y' or 'N'.");
                            }
                        }
                        else if (enteredNumber == 2)
                        {
                            Console.WriteLine("Name of the target directory?: ");
                            string enteredPath = Console.ReadLine();
                            string targetPath = @"C:\\" + enteredPath;
                            Directory.Move(path, targetPath);
                            Console.WriteLine($"{path} has been moved to {targetPath}");
                        }
                        else if (enteredNumber == 3)
                        {
                            Console.WriteLine("Good Bye!");
                            break;
                        }

                    }
                    else
                    {
                        throw new Exception("Your choice should be in integer format!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error has occured. {ex.Message}");
            }
        }
    }
}
