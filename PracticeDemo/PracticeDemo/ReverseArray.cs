using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class ReverseArray
    {
        public void ArrayReverse()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            //string[] arr1 = { "kiran", "puri" };
            int length=arr.Length-1;
            int j = 0;
            
            Console.WriteLine("Reversing the array");
            while(j<length)
            {
                int temp = arr[length];
                arr[length] = arr[j];
                arr[j] = temp;
                j++;
                length--;
            }
            foreach(int ele in arr)
            {
                Console.WriteLine(ele);
            }

            string Arraystring = string.Join(" ", arr);
            Console.WriteLine("reverse int array is {0}",Arraystring);
        }

       
    }
}
