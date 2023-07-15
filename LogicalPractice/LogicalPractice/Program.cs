using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Program: AccessModifier
    {
        static void Main(string[] args)
        {
            //AccessModifier accessModifier = new AccessModifier();
            //accessModifier.Display();
            //accessModifier.Display_Three();
            //accessModifier.Display_Five();
            //Program demo = new Program();
            //demo.Display_Four();
            //OOPsBasic oOPsBasic = new OOPsBasic();
            //NormalClass normalClass = new NormalClass();
            //normalClass.Abstract_one();
            //normalClass.normal_method();
            //Animal_Sound demo = new Animal_Sound();
            //demo.Animal();
            //demo.Sound();
            //Animal_Meal animal_Meal = new Animal_Meal();
            //animal_Meal.Animal();
            //animal_Meal.Eat();
            //Animal_Sound animal_Sound = new Animal_Sound();
            //animal_Sound.Animal();
            //animal_Sound.Sound();
            //Polymorphism polymorphism = new Polymorphism();
            //polymorphism.Shades();
            //polymorphism.Shades(2);
            //polymorphism.Shades(3,4);
            //polymorphism.Shades(3,4,5);
            //polymorphism.Shades(3,"a");
            //Encapsulation encapsulation = new Encapsulation();
            //Console.WriteLine(encapsulation.Name = "a");
            //Console.WriteLine(encapsulation.Year = 1);

            //Generic<string> generic = new Generic<string>();
            //generic.Name("kiran");
            //generic.Display();

            Generic generic = new Generic();
            int[] array = { 1, 2, 3 };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            string str = generic.Display2(array);
            Console.WriteLine(str);
        }
    }
}
