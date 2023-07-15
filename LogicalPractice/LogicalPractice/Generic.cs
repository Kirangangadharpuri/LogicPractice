using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    public class Generic
    {
        public void Display()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            foreach(int i in myArray)
            {
                Console.WriteLine("data in array",+i);
            }
            List<int> list = new List<int>();
            list.AddRange(myArray);
            Console.WriteLine(String.Join(",", list));
        }

        public string Display2(int[] array)
        {
            //Random random = new Random();
            //int option = random.Next(0, 4);
            //Console.WriteLine(option);


            string Variable = string.Concat(array);
            return Variable;
        }

    }
}
