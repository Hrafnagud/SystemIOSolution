using System;
using System.IO;

namespace SystemIODirectoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPath = @"C:\NetworkAcademy103\";
            if (doesDirectoryExists(myPath))
            {
                Console.WriteLine($"{myPath} Directory already exists.");
            }
            else
            {
                CreateNewDirectory(myPath);
                Console.WriteLine("Directory created successfully");
            }

            Console.WriteLine();

            //RemoveDirectory(myPath);
            //Console.WriteLine($"{myPath} directory has been removed");

            //CreateNewDirectory(@"C:\\TargetDirectory");
            MoveDirectory(myPath, @"C:\\TargetDirectoryy");


        }

        private static void CreateNewDirectory(string path)
        {
            DirectoryInfo dir = Directory.CreateDirectory(path);
        }

        private static bool doesDirectoryExists(string path)
        {
            bool doesExists = false;
            doesExists = Directory.Exists(path);
            return doesExists;
        }

        private static void RemoveDirectory(string path)
        {
            Directory.Delete(path);
        }

        private static void MoveDirectory(string sourcePath, string targetPath)
        {
            Directory.Move(sourcePath, targetPath); //target path created by Move() method automatically.
            Console.WriteLine($"Directory {sourcePath} has been moved to target {targetPath}");
        }
    }
}
