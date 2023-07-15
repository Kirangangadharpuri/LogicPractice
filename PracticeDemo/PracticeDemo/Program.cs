using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-Tranfer data from array to list");
                Console.WriteLine("2-Change datat type of list");
                Console.WriteLine("3-Upper Case String and lower cae string");
                Console.WriteLine("4- Reverse the variable of array");
                Console.WriteLine("5- search element in array");
                Console.WriteLine("6- Odd numbers in given range");
                Console.WriteLine("Choose above option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DataTransfer dataTransfer = new DataTransfer();
                        dataTransfer.Example();
                        //dataTransfer.Example2();
                        //dataTransfer.Example3();
                        break;
                    case 2:
                        ChangeDataType changeDataType = new ChangeDataType();
                        List<int> myList = new List<int>();
                        myList.Add(1);
                        myList.Add(2);
                        myList.Add(3);
                        foreach (int i in myList)
                        {
                            Console.WriteLine(i);
                        }
                        string str = changeDataType.Display1(myList);
                        Console.WriteLine(str);
                        break;

                    //int[] array = new int[3] { 1, 2, 3 };
                    //ArrayList arrayList = new ArrayList();
                    //Stack<int> stack = new Stack<int>();
                    //Queue<int> queue = new Queue<int>();
                    //LinkedList<int> linkedlist = new LinkedList<int>();
                    //Dictionary<int, string> dictionary = new Dictionary<int, string>();
                    //Hashtable hashtable = new Hashtable();
                    case 3:

                        UpperCaseString upperCaseString = new UpperCaseString();
                        upperCaseString.UpperString();
                        upperCaseString.LowerString();
                        break;
                    case 4:
                        ReverseVariable reverseVariable = new ReverseVariable();
                        reverseVariable.ReverseNumber();
                        reverseVariable.ReverseString();
                        reverseVariable.ReverseSentence();
                        break;
                    case 5:
                        SearchArray searchArray = new SearchArray();
                        searchArray.SearchElement();
                        break;
                        case 6:
                        EvenOddInRange evenOddInRange = new EvenOddInRange();
                        evenOddInRange.OddInRange();
                        break;
                }
            }
        }
    }
}
