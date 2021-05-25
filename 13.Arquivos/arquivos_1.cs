
using System;
using System.IO;

namespace OperacaoArquivo
{
    class ProgramTwo
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Levi\Documents\teste_levi.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path);                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }

            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
