using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Security.AccessControl;
using System.IO.Compression;


namespace Assignment_20
{
    class FileHandling
    {
        // printing Drive info...
        public static void WriteDriveInfo(String writeFile)
        {
            DriveInfo driveInfo = new DriveInfo("C");
            using (StreamWriter writerObject = new StreamWriter(writeFile))
            {
                writerObject.WriteLine(" Drive {0} ", driveInfo.Name);
                writerObject.WriteLine(" Drive type {0} ", driveInfo.DriveType);
                writerObject.WriteLine(" Volume Label {0}", driveInfo.VolumeLabel);
                writerObject.WriteLine(" File System {0} ", driveInfo.DriveFormat);
                writerObject.WriteLine(" Available space {0} GB ", (driveInfo.AvailableFreeSpace / (1024 * 1024 * 1024)));
                writerObject.WriteLine(" Total Space {0} GB ", (driveInfo.TotalSize / (1024 * 1024 * 1024)));
            }

        }

        // reading and writing to files
        public static void ReadWriteFile(string readFile, string writeFile)
        {
            using (StreamWriter writerObject = new StreamWriter(writeFile))
            using (StreamReader readerObject = new StreamReader(readFile))
            {
                string line;
                while ((line = readerObject.ReadLine()) != null)
                {
                    writerObject.WriteLine(line);
                }
            }
        }

        // compresing file
        public static void Compress(FileInfo targetFile)
        {
            using (FileStream filestream = targetFile.OpenRead())
            {
                using (FileStream outputFile = File.Create("FileWriteZip" + ".gz"))
                {
                    using (GZipStream compressStream = new GZipStream(outputFile, CompressionMode.Compress))
                    {
                        filestream.CopyTo(compressStream);
                    }

                }
            }
        }

        //changing file mode to read only
        public static void ChangingFileMode(string readFile)
        {
            var attriubute = File.GetAttributes(readFile);
            attriubute = attriubute | FileAttributes.ReadOnly;
            File.SetAttributes(readFile, attriubute);
        }

        public static void Main(string[] args)
        {
            string readFile = @"FileRead.Txt";
            string writeFile = @"WriteFile.txt";

            System.IO.Directory.CreateDirectory("myDir");
            
            FileStream readerObject = new FileStream("C:\\FileRead.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            FileStream writerObject = new FileStream("C:\\FileWrite.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            FileHandling.WriteDriveInfo(readFile);
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("you are in this directory {0}", Directory.GetCurrentDirectory());
            FileHandling.ReadWriteFile(readFile, writeFile);

            FileHandling.ChangingFileMode(readFile);

            FileHandling.Compress(new FileInfo(writeFile));



         //   FileHandling.CreatingZip(writeFile);

            Console.ReadKey();

        }
    }
}
