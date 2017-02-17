using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_t10_1x2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            

            for (int i =1; i<14; i++)
            {
                double win = rnd.NextDouble();
                Console.Write("{0}", i);

                if (win < 0.4)
                {
                    Console.WriteLine(" 1"); //Kotivoitto
                }
                else if (win < 0.6)
                {
                    Console.WriteLine(" X"); //Tasapeli
                }
                else
                    Console.WriteLine(" 2"); //Vierasvoitto

            }
            Console.ReadKey();
        }
    }
}
