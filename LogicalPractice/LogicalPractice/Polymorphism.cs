using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    public class Polymorphism
    {
        public virtual void Shades()
        {
            Console.WriteLine("Shade is red");
        }

        public void Shades(int a) 
        {
            Console.WriteLine();
            
        }
        public void Shades(int a, int b)
        {
            Console.WriteLine();

        }
        public void Shades(string b, int a)
        {
            Console.WriteLine();

        }
        public void Shades(int a, string b)
        {
            Console.WriteLine();

        }
        public void Shades(int a, int b, int c)
        {
            Console.WriteLine();

        }
    }

    public class Method_Overriding:Polymorphism
    {
        public override void Shades()
        {
            Console.WriteLine("Shade is red");
        }        
    }
}
