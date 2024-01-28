using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerchioParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio c1 = new Cerchio(10);
            Console.WriteLine(c1.ToString());

            Cerchio c2 = Cerchio.Parse("3");
            Console.WriteLine("{0}", c2.r);

            Console.ReadLine();
        }
    }
}
