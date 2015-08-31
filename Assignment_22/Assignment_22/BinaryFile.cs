using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22
{
    class BinaryFile
    {
        private int _number = 10;
        private string _sentence = "hello....";
        private decimal _decimalNumber = 15.10M;

        public static void Main(string[] args)
        {
            BinaryFile classObject = new BinaryFile();
            try
            {
                using (BinaryWriter writerObject = new BinaryWriter(File.Open("file.bin", FileMode.OpenOrCreate)))
                {
                    writerObject.Write(classObject._number);
                    writerObject.Write(classObject._sentence);
                    writerObject.Write(classObject._decimalNumber);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            try
            {

                using (BinaryReader readerObject = new BinaryReader(File.Open("file.bin", FileMode.OpenOrCreate)))
                {
                    Console.WriteLine(readerObject.ReadInt32());
                    Console.WriteLine(readerObject.ReadString());
                    Console.WriteLine(readerObject.ReadDecimal());

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
