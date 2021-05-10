using System;
using System.IO;

namespace FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Test\Help\mui\0412";  // @ = Verbatim string 
            var dirs = Directory.CreateDirectory(path);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
