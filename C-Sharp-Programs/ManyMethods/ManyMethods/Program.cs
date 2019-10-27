using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            addition();
            CatDog();
            OddEvent();
            Inches();
        }
        public static void Hello()
        {
            //type your name and then it tells you Hello, "Your Name"
            Console.WriteLine("Please tell me your name");
            string responce = Console.ReadLine();
            Console.WriteLine("Hello, " + responce);

        }
        static void addition()
        {
            Console.WriteLine("Give me a number");
            string oneint = Console.ReadLine();

            Console.WriteLine("Give me A second number");
            string twoint = Console.ReadLine();
            int x = int.Parse(oneint);
            int y = int.Parse(twoint);
            Console.WriteLine(x + y);
            Console.ReadKey();

        }
        static void CatDog()
        {
            Console.WriteLine("Do you prefer cats or dogs?");
            string pet = Console.ReadLine();
            string cat = "cat";
            string dog = "dog";

            if (cat == pet)
            {
                Console.WriteLine("Meow");
            }
            if (dog == pet)
            {
                Console.WriteLine("Bark");
            }
        }

        static void OddEvent()
        {
            Console.WriteLine("Give me a number.");
            string number = Console.ReadLine();
            int x = int.Parse(number);
            if (x % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
    static void Inches()
    {
      Console.WriteLine("How tall are you in feet?");
        string tall = Console.ReadLine();

       
    }
}
