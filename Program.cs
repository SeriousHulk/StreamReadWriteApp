using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReadWriteApp 
{
    class StreamReadWrite
    {
        static void Main()
        {
            StreamReadWriteMethod();
            FileExample();
            DirectoryExample();
        }

        private static void StreamReadWriteMethod()
        {
            string inputFile = "C:\\Users\\Kadam\\Desktop\\input.txt";
            string outputFile = "C:\\Users\\Kadam\\Desktop\\output2.txt";
            using (FileStream inputStream = File.OpenRead(inputFile))
            {
                using (FileStream outputStream = File.Create(outputFile))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
            Console.WriteLine("File copied successfully.");
        }
        private static void FileExample()
        {
            string filePath = "C:\\Users\\Kadam\\Desktop\\input.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            Console.WriteLine("File name: " + fileInfo.Name);
            Console.WriteLine("File Exists: " + fileInfo.Exists);
            Console.WriteLine("File LastAccessTime: " + fileInfo.LastAccessTime);
            Console.WriteLine("File FullName: " + fileInfo.FullName);
            Console.WriteLine("File Directory: " + fileInfo.Directory);
            Console.WriteLine("File IsReadOnly: " + fileInfo.IsReadOnly);
            Console.WriteLine("File size: " + fileInfo.Length + " bytes");
            Console.WriteLine("File attributes: " + fileInfo.Attributes);
            Console.WriteLine("File creation time: " + fileInfo.CreationTime);
            Console.WriteLine("File last write time: " + fileInfo.LastWriteTime + "\n");
        }

        private static void DirectoryExample()
        {
            string dirPath = "C:\\Users\\Kadam\\Desktop\\output.txt";
            DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);

            Console.WriteLine("Directory name: " + directoryInfo.Name);
            Console.WriteLine("Directory Attributes: " + directoryInfo.Attributes);
            Console.WriteLine("Directory FullName: " + directoryInfo.FullName);
            Console.WriteLine("Directory LastAccessTime: " + directoryInfo.LastAccessTime);
            Console.WriteLine("Directory Parent: " + directoryInfo.Parent);
            Console.WriteLine("Directory Exists: " + directoryInfo.Exists);
            Console.WriteLine("Parent directory: " + directoryInfo.Parent.FullName);
            Console.WriteLine("Directory creation time: " + directoryInfo.CreationTime);
            Console.WriteLine("Directory last write time: " + directoryInfo.LastWriteTime);
        }
    }
}

