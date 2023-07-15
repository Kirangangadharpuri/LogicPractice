using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    public class DataStructure
    {
        public void Display()
        {
            //Array
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };//collection
            string[] myArray_two = { "kiran", "pori" };
            //var ArrayList = new int() { };
            ArrayList obj = new ArrayList();//collection
            obj.Add(1);
            obj.Add('a');
            obj.Add("Kiran");
            List<int> myList = new List<int>();//colltion.generic

            Stack<string> myStack= new Stack<string>();//collection.generic
            Queue<string> myQueue= new Queue<string>();//collection.generic
            LinkedList<int> myLinkedList= new LinkedList<int>();//collection.generic
            Dictionary<int,string> myDictonary = new Dictionary<int, string>();
        }
    }
}
