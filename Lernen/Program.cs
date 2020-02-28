using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernen
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] Klass = new string[4];
            Klass[0]="Nabil";
            Klass[1] = "Achraf";
            Klass[2] = "Moussa";

            for(i=0; i<Klass.LongCount();i++) 
            {
                Console.WriteLine(Klass[i]);

            }

            Console.ReadKey();

        }
    }
}
