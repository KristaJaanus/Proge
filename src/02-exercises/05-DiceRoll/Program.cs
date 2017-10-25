using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();

            int diceroll = number.Next(1, 6);


            Console.WriteLine("/ roll 3d6 2d8");
            for (int i = 1; i <= 3; i++) ;

            {
                Random.diseroll
                for (int i = 1; i <= 2; i++) ;
            }


            Console.WriteLine("1d6: " + diceroll);
            diceroll = number.Next(1, 6);
            Console.WriteLine("1d6: " + diceroll);
            diceroll = number.Next(1, 6);
            Console.WriteLine("1d6: ");
            diceroll = number.Next(1, 6);
            Console.WriteLine("1d8: " + diceroll);
            diceroll = number.Next(1, 8);
            Console.WriteLine("1d8: " + diceroll);
            diceroll = number.Next(1, 8);
            Console.WriteLine();
            Console.WriteLine("Roll total: ");

            Console.ReadLine();
        }
    }
}
