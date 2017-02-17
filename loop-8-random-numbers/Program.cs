using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_8_random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // guide :

            Random rnd = new Random(); // Luodaan uusi ilmentymä rnd oliosta Random.

            // rnd.NextDouble(); // metodi arpoo luvun 0...1 väliltä

            // rnd.Next(100); // metodi arpoo kokonaisluvun 0 ja 100 väliltä ]0...100[

            // guide out

            // program for printing 20 random numbers out of 50

            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < 5; y++)
                {

                    Console.Write(" {0},",rnd.Next(50));
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
