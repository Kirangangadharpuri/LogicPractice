using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class ReverseAndPalindrome
    {
        public void Display()
        {
            Console.WriteLine("Enter number");
            int num=int.Parse(Console.ReadLine());
            int reverse = 0;
            int temp = num;
            while (num > 0) 
            {
                int reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num = num / 10;
            }
            Console.WriteLine(reverse);

            if (temp == reverse)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
            }

        }
    }
}
