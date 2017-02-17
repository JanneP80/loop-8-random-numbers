using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_t11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int kuutonen = 0;
            for (int i = 1; i < 1001; i++)
            {
                double die = rnd.Next(6)+1;
                Console.WriteLine("{0}. {1}", i, die);
                if (die == 6)
                {
                    kuutonen++;
                }
            }
            Console.WriteLine("Kuutonen arvottiin {0} kertaa.", kuutonen);
            Console.ReadKey();
        }
    }
}
