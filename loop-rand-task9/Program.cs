using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_rand_task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int kl = 0;
            int kr = 0;

            Random rnd = new Random();

            string message = string.Empty;
            Console.Write("Anna kolikonheittojen määrä: ");

            bool input = int.TryParse(Console.ReadLine(), out n);
            if (!input) // incorrect input
            {
                message = "Virhe. Anna luku.";
            }
            else
                for (int i = 0; i < n; i++)
                {

                    if (rnd.Next(2) == 1)
                    {
                        kl++;
                    }
                    else
                    {
                        kr++;
                    }
                }
            Console.WriteLine("Rahaa heitetty {0}", n);
            Console.WriteLine("Klaavoja tuli {0} ja kruunuja {1}", kl, kr);
            Console.ReadKey();
        }
    }
}
