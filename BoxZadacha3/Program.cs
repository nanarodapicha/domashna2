using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxZadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi broi simvola:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Vuvedi simvol:");
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);

                Console.WriteLine(box.ToString());
                Console.WriteLine();
            }
        }
    }
}
