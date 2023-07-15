using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    public class AccessModifier
    {
        public void Display()
        {
            Console.WriteLine("This is public access modifier");
        }
        private void Display_Two()
        {
            Console.WriteLine("this is private access modifier");
        }
        public void Display_Three()
        {
            AccessModifier accessModifier = new AccessModifier();
            accessModifier.Display_Two();
            Console.WriteLine("This is public access modifier");
        }
        protected void Display_Four()
        {
            Console.WriteLine("this is protected access modifier");
        }

        internal void Display_Five()
        {
            Console.WriteLine("this is internal access modifier");
        }

    }
}
