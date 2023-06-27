using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("prueba.txt");

            writer.WriteLine("Hola mundo");
            writer.Close();

            Console.ReadKey();
        }
    }
}
