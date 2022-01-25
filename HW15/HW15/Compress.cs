using System;
using System.IO;
using System.IO.Compression;

namespace HW15
{
    public class Compress
    {
        public static void ZipMethod(string streamCompress, string compressWriteFile)
        {
            using (FileStream soursePlace = new FileStream(compressWriteFile, FileMode.Open))
            {
                using (FileStream myStream = File.Create(streamCompress))
                {
                    using (GZipStream compressionStream = new GZipStream(myStream, CompressionMode.Compress))
                    {
                        soursePlace.CopyTo(compressionStream);
                        Console.WriteLine("The file {0} is compressed. Original size {1}, compressed size {2}.",
                        compressWriteFile, soursePlace.Length.ToString(), myStream.Length.ToString());
                    }
                }
            }
        }
    }
}
