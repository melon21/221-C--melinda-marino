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
            Addition();
            CatDog();
            OddEvent();
            Inches();
            Echo();
            KillGrams();
            DateTime();
            Age();
            Guess();
        }
        public static void Hello()
        {
            //type your name and then it tells you Hello, "Your Name"
            Console.WriteLine("Please tell me your name");
            string responce = Console.ReadLine();
            Console.WriteLine("Hello, " + responce);

        }
        static void Addition()
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
        Console.WriteLine("Give me a number");
        Console.ReadLine();
        int inches = 67;

        totalFeet(inches);

        Console.ReadLine();
        int total;

        feet = inches / 12;

        inchesTotal = feet
        Console.WriteLine("{0} Feet and {1} Inches", feet, inchesTotal);
    }
    static void Echo()
    {
        using System;


    public class Echo
    {
        string myString;

        public Echo(string aString)
        {
            myString = aString;
        }

        public void Tell()
        {
            Console.WriteLine(myString);
        }
    }

    public class Hello
    {
        public static void Main()
        {
            Echo h = new Echo("Hello my 1st C# object !");
            h.Tell();
        }
    }

}
    static void KillGrams()
    {
        Console.WriteLine("Give me a number if a weight in pounds");
        Console.ReadLine();
    }
    static void Date()
    {
        Console.WriteLine("Today's date is (0).");
        Console.ReadLine();
    }
    static void Age()
    {
        Console.WriteLine("What year were you born?");
        Console.ReadLine();
    }
    static void Guess()
    {
        Console.WriteLine("Guess a word");
        Console.ReadLine();
    }
}
