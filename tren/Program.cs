using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tren
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = "C:/For lesson 8";

            if (Directory.Exists(folder))
            {
                Console.WriteLine("Подкаталоги:");
                string[] folders = Directory.GetDirectories(folder);
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(folder);
                foreach (string s in files)
                
                Console.WriteLine(s);
                Console.ReadKey();
                }
            }

        }
    }

