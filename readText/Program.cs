using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace readText
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Texto\SGD280RPED20170331MU000000005411N01.txt");

            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("Hay {0} Lineas", counter);
            System.Console.ReadLine();


        }
    }
}
