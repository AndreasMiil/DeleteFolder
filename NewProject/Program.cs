using System;
using System.IO;

namespace NewProject
{
    class Program
    {
        static void Main(string[] args)

        {

            string rootPath = @"C:\Users\opilane\samples";
            DeleteAllfiles();
            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            Console.WriteLine("Hello World!");
        }
        public static void DeleteAllfiles()
        {
            string rootPath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
        }
        public static void DeleteAllfolders(string DirectoryName, bool ifExists)
        {
            if (Directory.Exists(DirectoryName))
            {
                Directory.Delete(DirectoryName, true);
            }
            else if (ifExists)
            {
                throw new SystemException("No such directory to delete");
            }
        }
    }
}

