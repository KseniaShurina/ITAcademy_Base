using System;
using System.Collections;
using System.IO;

namespace HW15_DataStreams
{
    class Program
    {

        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"D:\Ksenia\Repos\ITAcademy_Base");

            ArrayList list = new ArrayList();

            directory.FindInDir();

            void FindInDir(DirectoryInfo dir, string pattern, bool recursive, ArrayList list)
            {

                FileInfo[] files = directory.GetFiles("*.txt");
                foreach (FileInfo file in files)
                {
                    list.Add(file.FullName);
                    Console.WriteLine($"file {file} is found");
                }

                if (recursive)
                {
                    foreach (DirectoryInfo subdir in dir.GetDirectories())
                    {
                        FindInDir(subdir, pattern, recursive, list);
                    }
                }
            }
        }


        //public void FindFiles(string dir, string pattern)
        //{
        //    this.FindInDir(new DirectoryInfo(dir), pattern, true);
        //}
    }

}
