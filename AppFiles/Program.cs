using System;
using System.IO;
using System.Globalization;

namespace AppFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string local = @"D:\Aprendendo C#\Files\Arquivo teste\File1.csv";
            string outLocal = @"D:\Aprendendo C#\Files\Arquivo teste\File2.csv";

            try
            {
                string[] lines = File.ReadAllLines(local);

                using (StreamWriter sw = File.AppendText(outLocal))
                {
                    foreach(string line in lines)
                    {
                        string[] linha = line.Split(",");
                        string produto = linha[0];
                        double valor = double.Parse(linha[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(linha[2]);

                        Product product = new Product(produto, valor, quantidade);
                        product.PrecoFinal();

                        sw.WriteLine(product);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro no arquivo: ");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro não tratado: " + e.Message);
            }
        }
    }
}