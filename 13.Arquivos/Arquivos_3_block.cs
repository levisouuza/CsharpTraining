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
            string  path = @"C:\Users\Levi\Documents\teste_levi.txt";

            try
            {

                usgin (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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


//////////////////////////

/*
using ExceptionAsk.Entities.Exceptions;
using ExceptionAsk.Entities;
using System;

namespace ExceptionAsk
{
    class Program
    {
        static void Main(string[] args)
        {
            string  path = @"C:\Users\Levi\Documents\teste_levi.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    usgin (StreamReader sr = new StreamReader(fs))
                    {
                        while(!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
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
}*/