using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string[] writtenNumber = new string[10] 
            { "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "OTHER" };
            string results = "";

            NestedIf(number, writtenNumber, results);                   // (a) using nested-if statement
            SwitchCase(number, writtenNumber, results);                 // (b) using switch-case statement

            Console.ReadLine();
        }
        public static void NestedIf(int number, string[] writtenNumber, string results)
        {
            if (number > 0 && number < 10)
                if (number < 9)
                    if (number < 8)
                        if (number < 7)
                            if (number < 6)
                                if (number < 5)
                                    if (number < 4)
                                        if (number < 3)
                                            if (number < 2)
                                                results = writtenNumber[0];
                                            else results = writtenNumber[1];
                                        else results = writtenNumber[2];
                                    else results = writtenNumber[3];
                                else results = writtenNumber[4];
                            else results = writtenNumber[5];
                        else results = writtenNumber[6];
                    else results = writtenNumber[7];
                else results = writtenNumber[8];
            else results = writtenNumber[9];

            Console.WriteLine(results);
        }
        public static void SwitchCase(int number, string[] writtenNumber, string results)
        {
            switch (number)
            {
                case 1: results = writtenNumber[0];
                    break;
                case 2: results = writtenNumber[1];
                    break;
                case 3: results = writtenNumber[2];
                    break;
                case 4: results = writtenNumber[3];
                    break;
                case 5: results = writtenNumber[4];
                    break;
                case 6: results = writtenNumber[5];
                    break;
                case 7: results = writtenNumber[6];
                    break;
                case 8: results = writtenNumber[7];
                    break;
                case 9: results = writtenNumber[8];
                    break;
                default: results = writtenNumber[9];
                    break;
            }
            Console.WriteLine(results);
        }
    }
}
