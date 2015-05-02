using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string userNumber = Console.ReadLine();

            sumAndAverageMethod(userNumber);                            // compute sum and average using "while" loop
            Console.WriteLine();                                        // create a space

            Console.Write("Enter a new integer: ");
            string userLowNumber = Console.ReadLine();
            Console.Write("Enter an integer greater than " + userLowNumber + ": ");
            string userHighNumber = Console.ReadLine();

            withinRangeMethod(userLowNumber, userHighNumber);           // compute sum & average within a range
            Console.WriteLine();                                        // create a space

            Console.Write("Enter another integer: ");
            string anotherLowNumber = Console.ReadLine();
            Console.Write("Enter an integer greater than " + userLowNumber + ": ");
            string anotherHighNumber = Console.ReadLine();

            otherMethod(anotherLowNumber, anotherHighNumber);           // compute sum and average of odd numbers and numbers divisible by 7 
            // and sum of all numbers squared within a range
            Console.ReadLine();
        }

        public static void sumAndAverageMethod(string userNumber)
        {
            int i = 0;
            int getSum = 0;
            System.Decimal getAverage = 0;

            while (i <= Convert.ToInt32(userNumber))
            {
                getSum = getSum + i;
                i++;
            }
            Console.WriteLine("The sum is " + String.Format("{0:n0}", getSum));

            getAverage = Convert.ToDecimal(getSum) / Convert.ToInt32(userNumber);

            if ((getAverage % 1) > 0)
                Console.WriteLine("The average is " + String.Format("{0:n1}", getAverage));
            else Console.WriteLine("The average is " + String.Format("{0:n0}", getAverage));

        }

        public static void withinRangeMethod(string userLowNumber, string userHighNumber)
        {
            int i = Convert.ToInt32(userLowNumber);
            int getSum = 0;
            int count = 0;
            System.Decimal getAverage = 0;

            while (i <= Convert.ToInt32(userHighNumber))
            {
                getSum = getSum + i;
                i++;
                count++;                                                // counts numbers within specified range
            }

            Console.WriteLine("The sum is " + String.Format("{0:n0}", getSum));

            getAverage = getSum / Convert.ToDecimal(count);

            if ((getAverage % 1) > 0)
                Console.WriteLine("The average is " + String.Format("{0:n1}", getAverage));
            else Console.WriteLine("The average is " + String.Format("{0:n0}", getAverage));
        }

        public static void otherMethod(string anotherLowNumber, string anotherHighNumber)
        {
            int i = Convert.ToInt32(anotherLowNumber);
            int getSum = 0;
            int count = 0;
            System.Decimal getAverage = 0;
            int divisibleSum = 0;
            int divisibleCount = 0;
            System.Decimal divisibleAverage = 0;
            int sumOfSquares = 0;

            while (i <= Convert.ToInt32(anotherHighNumber))
            {
                if (i % 2 != 0)                                         // filters odd numbers only
                {
                    getSum = getSum + i;
                    count++;
                }
                if (i % 7 == 0)                                         // filters numbers divisible by 7 only
                {
                    divisibleSum = divisibleSum + i;
                    divisibleCount++;
                }
                i++;
            }

            for (int n = Convert.ToInt32(anotherLowNumber); n <= Convert.ToInt32(anotherHighNumber); n++)
            {
                sumOfSquares = sumOfSquares + (n * n);                // sums the squares of each number
            }

            Console.WriteLine("The sum of all odd numbers is " + String.Format("{0:n0}", getSum));

            getAverage = getSum / Convert.ToDecimal(count);

            if ((getAverage % 1) > 0)
                Console.WriteLine("The average of those numbers is " + String.Format("{0:n1}", getAverage));
            else Console.WriteLine("The average of those numbers is " + String.Format("{0:n0}", getAverage));

            Console.WriteLine("The sum of all numbers divisible by 7 is " + String.Format("{0:n0}", divisibleSum));

            divisibleAverage = divisibleSum / Convert.ToDecimal(divisibleCount);

            if ((divisibleAverage % 1) > 0)
                Console.WriteLine("The average of those numbers is " + String.Format("{0:n1}", divisibleAverage));
            else Console.WriteLine("The average of those numbers is " + String.Format("{0:n0}", divisibleAverage));

            Console.WriteLine("The sum of all numbers squared is " + String.Format("{0:n0}", sumOfSquares));
        }
    }
}