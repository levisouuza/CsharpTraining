using System.Globalization;
using System.IO;
using System;


namespace OperacaoArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Levi\Documents\summary.csv";
            string targetPath = @"C:\Users\Levi\Documents\out\summary2.csv";

            //criando diretorio out
            Directory.CreateDirectory(@"C:\Users\Levi\Documents\out");

            try
            {

                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string product = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(line[2]);

                        double priceTotal = price * qtd;
                        string row = product + "," + priceTotal.ToString("F2", CultureInfo.InvariantCulture);
                        Console.WriteLine(row);
                        
                        using (StreamWriter sw = File.AppendText(targetPath))
                        {
                            sw.WriteLine(row);
                        }
                    }
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
