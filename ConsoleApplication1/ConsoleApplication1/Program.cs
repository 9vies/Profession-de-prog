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
            const string HARAMBE = "HARAMBE WAS NOT JUST A GORILLA U CUNTFACE";
            Console.WriteLine(HARAMBE);
            int chiffre = int.Parse(Console.ReadLine());
            for (int i = 1; i <= chiffre; i++)
            {               
                if (i < chiffre/4)
                {
                    Console.WriteLine("Cansur non généralisé" + " {0}", i);
                }
                else
                {
                    Console.WriteLine("Cansur" + " {0}", i);
                }
            }
        }
    }
}
