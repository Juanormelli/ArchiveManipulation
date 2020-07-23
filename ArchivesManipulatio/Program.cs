using System;
using System.IO;

namespace ArchivesManipulatio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path");
            string sourcefilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourcefilePath);
                
                string sourcefolderPath = Path.GetDirectoryName(sourcefilePath);
                string targetfolderPath = sourcefolderPath + @"\out";
                string targetfilePath = targetfolderPath + @"Summary.csv";

                Directory.CreateDirectory(targetfolderPath);

                using (StreamWriter sw= File.AppendText(targetfilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] folder = line.Split(";");

                        string name = folder[0];
                        double price = double.Parse(folder[1]);
                        int quantity = int.Parse(folder[2]);

                        Product produc = new Product(name, price, quantity);

                        sw.WriteLine(produc.Name + ", " + produc.total());



                    } 
                }
            }
            catch(Exception e )
            {
                Console.WriteLine("Error"+ e.Message);
            }
        }
    }
}
