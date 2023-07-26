using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public class FileIOProblem
    {
        string path = @"C:\Users\HP\Desktop\RFP-288\Practice\LogicPractice\PracticeDemo\PracticeDemo\FileFolder\Kiran.txt";
        public void CkeckFile()
        {
            if(File.Exists(path))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
        }
        public void ReadAllLines()
        {
            string[] Lines = File.ReadAllLines(path);
            foreach (string Line in Lines)
            {
                Console.WriteLine(Line);
            }
        }
        public void ReadAllText()
        {
            string Lines = File.ReadAllText(path);
            Console.WriteLine(Lines);
        }
    }
   
}
