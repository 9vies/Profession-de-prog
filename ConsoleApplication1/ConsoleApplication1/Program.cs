using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chiffre = int.Parse(Console.ReadLine());
            for (int i = 1; i <= chiffre; i++)
            {
                Console.WriteLine("Cansur" +  " {0}", i);
            }
        }
    }
}
