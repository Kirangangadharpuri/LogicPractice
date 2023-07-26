using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class ReverseVariable
    {
        public void ReverseNumber()
        {
            Console.WriteLine("Enter a number to reverse");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0) 
            {
                int Reminder = Number % 10;
                Reverse = (Reverse * 10) + Reminder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse number is : " + Reverse);
            Console.ReadLine();

            //Console.WriteLine("Enter a No. to reverse");
            //int Number = int.Parse(Console.ReadLine());
            //int Reverse = 0;
            //while (Number > 0)
            //{
            //    int remainder = Number % 10;
            //    Reverse = (Reverse * 10) + remainder;
            //    Number = Number / 10;
            //}
            //Console.WriteLine("Reverse No. is {0}", Reverse);
            //Console.ReadLine();
        }

        public void ReverseString()
        {
            {
                Console.WriteLine("Enter a string to reverse");
                string myString = Console.ReadLine();
                String Reverse = "";
                int len = myString.Length - 1;
                while (len >= 0)
                {
                    Reverse = Reverse + myString[len];
                    len--;
                   
                }
                Console.WriteLine("{0} is Reverse string", Reverse);
                Console.ReadLine();
            }
        }

        public void ReverseSentence()
        {
            
                Console.WriteLine("Enter sentence to reverse");
                string sentence = Console.ReadLine();
                string[] array = sentence.Split(' ');
            string reverse = " ";
            //Array.Reverse(array);
            int len = array.Length -1;
                //Console.WriteLine(" is Reverse Sentence");
                while(len>0)
                {
                      reverse=reverse + array[len];
                     len--;
                }
            Console.Write(reverse);


        }
    }
}
