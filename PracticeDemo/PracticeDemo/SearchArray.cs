using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeDemo
{
    public class SearchArray
    {
       public void SearchElement()
        {
            string[] array ={ "cat", "dog", "donkey", "camel" };
            string v1 = Array.Find(array, element=>element.StartsWith("cam",StringComparison.Ordinal));
            string v2 = Array.Find(array,element => element.Length == 5);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(array.GetUpperBound(0).ToString());
            Console.WriteLine(array.GetLowerBound(0).ToString());

        }
    }
}
