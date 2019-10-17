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
            catDog();
            OddEvent();
            inches();
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
        static void catDog()
        {
            Console.WriteLine("do you prefer cats or dogs?");
            int cat();
            int dog();
            if cat(
            Console.WriteLine("Do cats bark or meow?"));
            if dog(
            Console.WriteLine("Do dogs bark or meow?"));

        }

        private static bool dog()
        {
            throw new NotImplementedException();
        }

        static void OddEvent();
        {
            
        }
        static void Inches();
    }
}
