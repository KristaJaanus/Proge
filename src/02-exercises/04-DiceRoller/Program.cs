using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("/ roll 3d6 2d8");

            Console.WriteLine();

            var random = new Random();
            var total = 0;

            for (var i = 0; i < 3; i++)
            {
                var roll = random.Next(1, 6);
                total += roll;

                Console.WriteLine($"1d6: {roll}");

            }
            for (var i = 0; i < 2; i++)
            {
                var roll = random.Next(1, 8);
                total += roll;

                Console.WriteLine($"1d8: {roll}");

            }
            Console.WriteLine();
            Console.WriteLine($"Roll total: {total}");
            Console.WriteLine();
            Console.WriteLine(">);

            Console.ReadLine();
        }
    }
}
