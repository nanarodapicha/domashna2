using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxZadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> chisla = new Box<int>(123123);
            Console.WriteLine(chisla); 

            Box<string> dumi = new Box<string>("life in a box");
            Console.WriteLine(dumi); 
        }
    }
}
