using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassFail
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 0;

            if (mark >= 50)
                Console.WriteLine("PASS");
            else
                Console.WriteLine("FAIL");

            Console.ReadLine();
        }
    }
}
