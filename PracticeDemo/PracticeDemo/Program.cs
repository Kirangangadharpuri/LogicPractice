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
                FileIOProblem problem = new FileIOProblem();
                Console.WriteLine("1-Tranfer data from array to list");
                Console.WriteLine("2-Change datat type of list");
                Console.WriteLine("3-Upper Case String and lower cae string");
                Console.WriteLine("4- Reverse the variable of array");
                Console.WriteLine("5- search element in array");
                Console.WriteLine("6- Odd numbers in given range");
                Console.WriteLine("7- Reverse the array");
                Console.WriteLine("8 - miltiplication table");
                Console.WriteLine("9- multiple of 3 and 5");
                Console.WriteLine("10- Sum of digit of number");
                Console.WriteLine("11-Reverse and Palindrome number");
                Console.WriteLine("12-Linked List");
                Console.WriteLine("13- Opps");
                Console.WriteLine("14-Encapsulation");
                Console.WriteLine("15-Check file Exist or not");
                Console.WriteLine("16-Read all lines from file");
                Console.WriteLine("17- read all text");
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
                        //reverseVariable.ReverseNumber();
                        //reverseVariable.ReverseString();
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
                    case 7:
                        ReverseArray reverseArray = new ReverseArray();
                        reverseArray.ArrayReverse();
                        break;
                    case 8:
                        MultipleTable multipleTable = new MultipleTable();
                        multipleTable.Table();
                        break;
                    case 9:
                        Mutiple_Three_Five mutiple_Three_Five = new Mutiple_Three_Five();
                        mutiple_Three_Five.Multiple();
                        break;
                    case 10:
                        SumOfDigits sumOfDigits = new SumOfDigits();
                        sumOfDigits.Sum();
                        break;
                    case 11:
                        ReverseAndPalindrome reverseAndPalindrome = new ReverseAndPalindrome();
                        reverseAndPalindrome.Display();
                        break;
                    case 12:
                        ListLinked listLinked  = new ListLinked();
                        listLinked.InsertData(1);
                        listLinked.InsertData(2);
                        listLinked.InsertData(3);
                        listLinked.InsertData(4);
                        listLinked.InsertData(5);
                        listLinked.InsertAtPerticularPosition(3,6);
                        listLinked.Display();
                        break;
                    case 13:
                        Display display = new Display();
                        display.FirstName();
                        display.LastName();
                        display.AnimalName();
                        break;
                    case 14:
                        EncapsulationDemo demo = new EncapsulationDemo();
                        Console.WriteLine(demo.Name="Kiran");
                        break;
                    case 15:
                        problem.CkeckFile();
                        break;
                    case 16:
                        problem.ReadAllLines();
                        break;
                    case 17:
                        problem.ReadAllText();
                        break;
                }
            }
        }
    }
}
