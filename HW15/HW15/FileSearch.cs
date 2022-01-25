using System;
using System.Collections.Generic;
using System.IO;

namespace HW15
{
    public class CustomFileNotFoundException : Exception
    {
        public CustomFileNotFoundException(string message) : base(message) { }
    }

    public class FileSearch
    {
        public static List<string> FoundFiles(string fileName, string path)

        {
            fileName = fileName.ToUpper();
            var myList = new List<string>();
            try
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    var a = new FileInfo(file);
                    if (a.Name.ToUpper() == fileName)
                    {
                        myList.Add(file);
                    }
                }

                foreach (var file2 in Directory.GetDirectories(path))
                {
                    myList.AddRange(FoundFiles(file2, fileName));
                }

                return myList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
