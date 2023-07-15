using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    public class InheritenceDemo
    {
        public virtual void Animal()
        {
            Console.WriteLine("Animal is tiger");
        }
    }

    public class Animal_Sound: InheritenceDemo
    {
        public virtual void Animal()
        {
            Console.WriteLine("Animal is Loin");
        }
        public void Sound()
        {
            Console.WriteLine("Tiger says: raaaa");
        }
    }

    public class Animal_Meal: InheritenceDemo
    {
        public override void Animal()
        {
            Console.WriteLine("Animal is Tiger");
        }
        public void Eat()
        {
            Console.WriteLine("lion eat meat");
        }
    }
    
}
