using System.Collections.Generic;
using System.IO;
using System;

///////////listando arquivos
namespace ExceptionAsk
{
    class Program
    {
        static void Main(string[] args)
        {
            string  Path = @"C:\temp\myfolder";
            

            try
            {   
                ///////////listando diretorios    

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:")
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                // LISTANDO ARQUIVOS
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:")
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder") //@"\newfolder"
                
            }

            catch (IOException e)
            {
                Console.WriteLine(An error occurred);
                Console.WriteLine(e.Message);
            }
        }
    }
}
