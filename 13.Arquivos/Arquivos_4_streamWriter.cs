using ExceptionAsk.Entities.Exceptions;
using ExceptionAsk.Entities;
using System;
using System.IO;

namespace ExceptionAsk
{
    class Program
    {
        static void Main(string[] args)
        {
            string  sourcePath = @"C:\Users\Levi\Documents\teste_levi.txt";
            string  targetPath = @"C:\Users\Levi\Documents\teste_levi_2.txt";

            try
            {
                string[] lines = File.ReadAllLine(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }               
                
            }

            catch (IOException e)
            {
                Console.WriteLine(An error occurred);
                Console.WriteLine(e.Message);
            }
        }
    }
}