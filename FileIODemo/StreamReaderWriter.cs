using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    public  class StreamReaderWriter
    {
        public string path;
        public StreamReaderWriter()
        {
            path = @"C:\Users\sai\source\repos\RFP-244\FileIODemo\FileIODemo\DataText.txt";
        }
        public void CheckFileExist()
        {
            if(!File.Exists(path))
            {
                return;
            }
        }
        public void ReadFile()
        {
            CheckFileExist();
            using(StreamReader reader = File.OpenText(path))
            {
                string line = string.Empty;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
        public void WriteFile()
        {
            CheckFileExist();
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine("\n Class is at eight o' clock \n Please be available \n Will have fun!!!");
                writer.Close();
            }
            Console.ReadKey();
        }
    }
}
