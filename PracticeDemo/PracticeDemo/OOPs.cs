using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    public abstract class OOPs
    {
        public abstract void FirstName();
        
        public void LastName()
        {
            Console.WriteLine("Puri");
        }
      
    }
    public interface Animal
    {
        void AnimalName();
    }

    public class Display:OOPs,Animal
    {
        public override void FirstName()
        {
            Console.WriteLine("Kiran");
        }

        public void AnimalName()
        {
            Console.WriteLine("Tiger");
        }
    }

    public class EncapsulationDemo
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
