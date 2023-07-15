using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    public abstract class OOPsBasic
    {
        public abstract void Abstract_one();
      
        public void Normal_method()
        {
            Console.WriteLine("this is normal method");
        }

    }

    public interface Interface_one
    {
         void normal_method();
        
    }

    public class NormalClass:OOPsBasic, Interface_one
    {
        public override void Abstract_one()
        {
            Console.WriteLine("Abstract inheritance");
        }

        public void normal_method()
        {
            Console.WriteLine("Interface inheritance");
        }
    }
}
