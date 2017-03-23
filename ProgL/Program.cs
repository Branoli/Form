using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgL
{
    class Program
    {
        static void Main(string[] args)
        {
            Game3 game = new Game3(3);
            do
            {
                Print.PrintMas(game);
                string q = Convert.ToString(Console.ReadLine());
                game.MovingTheKnuckles(q);
            } while (game.CheckInBox() == true);
            Print.PrintWIN();
            Console.ReadKey();
        }
    }
}
