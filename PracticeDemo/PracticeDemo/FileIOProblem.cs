﻿using System;
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
        public void CopyFile()
        {
            string copPath = @"C:\Users\HP\Desktop\RFP-288\Practice\LogicPractice\PracticeDemo\PracticeDemo\FileFolder\Puri.txt";
            File.Copy(path, copPath);
            Console.WriteLine("File has been copied");
        }
        public void CreateDirectory()
        {
            //Directory.CreateDirectory("C:\\Kiran");
            string[] array = Directory.GetFiles(@"C:\");
            Console.WriteLine("Files in the Directory");
            foreach (string data in array)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
        public void ReadFile_STreamReader()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string reader = " ";
                while ((reader = sr.ReadLine()) != null)
                {
                    Console.WriteLine(reader);
                }
            }
        }
        public void WriteFile_STreamWriter()
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine("Im an Engineer");
                writer.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }

}
