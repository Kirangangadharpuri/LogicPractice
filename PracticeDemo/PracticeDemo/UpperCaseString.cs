using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class UpperCaseString
    {
        public void UpperString()
        {
            //string str1 = "this is string";
            //string str2 = str1.ToUpper();
            //Console.WriteLine(str2);

            string str1 = "this is string";
            if (str1.Length == 0)
            {
                Console.WriteLine("string is empty");
            }
            else if (str1.Length == 1)
            {
                Console.WriteLine(char.ToUpper(str1[0]));
            }
            else
            {
                Console.WriteLine(Char.ToUpper(str1[0]) + str1.Substring(1));
            }

        }
        public void LowerString()
        {
            //string str3 = "THIS IS STRING";
            //string str4= str3.ToLower();
            //Console.WriteLine(str4);
            //if(str3.Length==0)
            //{
            //    Console.WriteLine("string is empty");
            //}
            //else if(str3.Length==1)
            //{
            //    Console.WriteLine(Char.ToLower(str3[0]));
            //}
            //else
            //{
            //    Console.WriteLine(Char.ToLower(str3[0])+ str3.Substring(1));
            //}
        }
    }
}
