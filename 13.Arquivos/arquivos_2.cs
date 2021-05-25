using System;
using System.IO;

namespace OperacaoArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Levi\Documents\teste_levi.txt";
            string targetPath = @"C:\Users\Levi\Downloads\teste_levi.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
