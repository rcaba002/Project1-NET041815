using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            for (int i = 1; i < 111; i++)
            {
                if (count < 12)
                {
                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                        Console.Write("CozaLozaWoza ");
                    else if (i % 3 == 0 && i % 5 == 0)
                        Console.Write("CozaLoza ");
                    else if (i % 3 == 0 && i % 7 == 0)
                        Console.Write("CozaWoza ");
                    else if (i % 5 == 0 && i % 7 == 0)
                        Console.Write("LozaWoza ");
                    else
                        if (i % 3 == 0)
                            Console.Write("Coza ");
                        else if (i % 5 == 0)
                            Console.Write("Loza ");
                        else if (i % 7 == 0)
                            Console.Write("Woza ");
                        else
                            Console.Write(i + " ");
                }
                else
                {
                    count = 1;                                          // reset count per line
                    Console.WriteLine();                                // create new line

                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                        Console.Write("CozaLozaWoza ");
                    else if (i % 3 == 0 && i % 5 == 0)
                        Console.Write("CozaLoza ");
                    else if (i % 3 == 0 && i % 7 == 0)
                        Console.Write("CozaWoza ");
                    else if (i % 5 == 0 && i % 7 == 0)
                        Console.Write("LozaWoza ");
                    else
                        if (i % 3 == 0)
                            Console.Write("Coza ");
                        else if (i % 5 == 0)
                            Console.Write("Loza ");
                        else if (i % 7 == 0)
                            Console.Write("Woza ");
                        else
                            Console.Write(i + " ");
                }
                count++;
            }
            Console.ReadLine();
        }
    }
}
