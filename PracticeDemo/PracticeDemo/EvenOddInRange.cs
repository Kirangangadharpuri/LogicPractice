using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class EvenOddInRange
    {
        public void OddInRange()
        {
            IEnumerable<int> range= Enumerable.Range(20,20).Where(x=>x%2!=0);
            foreach(int ele in range)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
