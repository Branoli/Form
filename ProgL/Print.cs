using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgL
{
    static class Print
    {
        public static void PrintMas(Game3 print)
        {
            Console.Clear();
            for (int i = 0; i < print.Size; i++)
            {
                for (int j = 0; j < print.Size; j++)
                {

                    if (print[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t{0}", print[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\t{0}", print[i, j]);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            if (print.history != null)
            {
                for (int i = 0; i < print.history.Count; i++)
                {
                    Console.Write(print.history[i] + " ->  0|");
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Какую костяшку ПО ОНОШЕНИЮ ---К НУЛЮ---, передвинуть ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintWIN()
        {
            Console.WriteLine("Вы это сделали!!!\n\n\n История ходов");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
