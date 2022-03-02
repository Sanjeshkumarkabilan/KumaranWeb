using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delecates
{
    internal class Program
    {
        delegate void demoDelegate(string x, int n);

        public static void PrintPersonalDetails(string xName, int xAge)
        {
            Console.WriteLine($"Name {xName}");
            Console.WriteLine($"Age  {xAge}");
        }

        

        static void Main(string[] args)
        {
            demoDelegate dd;

            dd = new demoDelegate(PrintPersonalDetails);
            dd("Deepeck", 20);


            Console.ReadKey();
        }
    }
}
