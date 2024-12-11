using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            box.Add(1);
            box.Add(2); 
            box.Add(3);
            Console.WriteLine($"Premahnatiq element e:{box.Remove()}");
            

            box.Add(4); 
            box.Add(5);
            Console.WriteLine($"Premahnatiq element e:{box.Remove()}");

            Console.WriteLine($"Broqt na ostanalite elemnti: {box.Count}"); 
        }
    }
}
