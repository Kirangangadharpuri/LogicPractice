using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeDemo
{
    public class DataTransfer
    {
        public void Example()
        {
            int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int elements in myArray)
            {
                Console.WriteLine(elements);
            }
            List<int> myList = myArray.ToList();
            Console.WriteLine(String.Join(",", myList));
            string str= string.Join(",", myList);
            Console.WriteLine("string type array {0}",str);
        }
        public void Example2()
        {
            int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            List<int> myList = new List<int>(myArray);
            Console.WriteLine(String.Join(",", myList));
        }
        public void Example3()
        {
            string[] myArray = new string[3] { "Kiran", "Gangadhar", "Puri" };
            List<string> myList = new List<string>();
            myList.AddRange(myArray);
            Console.WriteLine(String.Join(",", myList));
        }
    }
}
