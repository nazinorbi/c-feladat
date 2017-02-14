using System;
using System.Collections.Generic;
using System.IO;

namespace VisualStudioCleaner
{
    class VisualStudioCleaner
    {
        public static void Process(string rootDir)
        {
            // Read all the folder names in the specified directory tree
            string[] dirNames = Directory.GetDirectories(rootDir, "*.*", SearchOption.AllDirectories);
            List<string> errorsList = new List<string>();

            // delete any .suo and csproj.user file
            foreach (string dir in dirNames)
            {
                var files = new List<string>();
                files.AddRange(Directory.GetFiles(dir, "*.suo"));
                files.AddRange(Directory.GetFiles(dir, "*.user"));
                foreach (string fileName in files)
                {
                    try
                    {
                        Console.Write("Deleting {0} ...", fileName);
                        File.Delete(fileName);
                        Console.WriteLine("DONE");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" ERROR: {0}", ex.Message);
                        errorsList.Add(fileName + ": " + ex.Message);
                    }
                }
            }

            // Delete all the BIN, OBJ and .VS subdirectories
            foreach (string dir in dirNames)
            {
                string dirName = Path.GetFileName(dir).ToLower();
                if (dirName == "bin" || dirName == "obj" || dirName == ".vs")
                {
                    try
                    {
                        Console.Write("Deleting {0} ...", dir);
                        Directory.Delete(dir, true);
                        Console.WriteLine("DONE");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" ERROR: {0}", ex.Message);
                        errorsList.Add(dir + ": " + ex.Message);
                    }
                }
            }
            Console.WriteLine(new string('-', 60));
            if (errorsList.Count == 0)
            {
                Console.WriteLine("All directories and files were removed successfully");
            }
            else
            {
                Console.WriteLine("{0} directories or directories couldn't be removed", errorsList.Count);
                Console.WriteLine(new string('-', 60));
                foreach (string msg in errorsList)
                {
                    Console.WriteLine(msg);
                }
            }
        }

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Process(args[0]);
            } else
            {
                Process(Directory.GetCurrentDirectory());
            }
            Console.ReadKey();
        }
    }
}