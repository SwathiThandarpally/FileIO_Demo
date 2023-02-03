namespace FileIODemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Diaplaying File Stream Reader Program");
            StreamReaderWriter readerWriter = new StreamReaderWriter();
            readerWriter.CheckFileExist();
            readerWriter.ReadFile();
            readerWriter.WriteFile();
        }
    }
}