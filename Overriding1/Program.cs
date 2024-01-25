using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r = new Rettangolo();
            r.lato = 3;
            r.ToString();
            Console.WriteLine(r);
            Cerchio c = new Cerchio();
            c.Raggio = 2;
            Console.WriteLine(c.ToString());
            Console.ReadLine();

        }
    }
}
