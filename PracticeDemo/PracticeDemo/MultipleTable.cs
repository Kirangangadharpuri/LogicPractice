using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class MultipleTable
    {
        public void Table()
        {
            int value=0;
            Console.WriteLine("Enter a number for table");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the range for table");
            int range = Convert.ToInt32(Console.ReadLine());
            for ( int i = 1; i <= range; i++)
            {
                value = num * i;
                Console.WriteLine(num + "*" + i + "=" + value);

            }
        }
    }
}
