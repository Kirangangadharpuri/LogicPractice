using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class SumOfDigits
    {
        public void Sum()
        {
            int num, sum = 0, r;
            Console.WriteLine("Enter number");
            num=int.Parse(Console.ReadLine());
            while(num!=0)
            {
                r = num % 10;
                num = num / 10;
                sum = num + r;
            }
            Console.WriteLine("Sum of Digit of numbers is {0}", sum);
        }
    }
}
