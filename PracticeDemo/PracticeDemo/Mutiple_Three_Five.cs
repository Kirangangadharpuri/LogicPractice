using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class Mutiple_Three_Five
    {
        public void Multiple()
        {
            int a, b, i, value = 0;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            value = 0;
            for( i = 0; i < num; i++)
            {
                a = i % 3;
                b= i % 5;
                if(a==0||b==0)
                {
                    Console.WriteLine(" {0}\t",i);
                    value = value + i;
                }
            }
            Console.WriteLine("\n The sum of 3 and 5 "+value);
        }
    }
}
