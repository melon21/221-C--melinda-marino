using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Mind
{
    class Program
    {
       static string[] colors = new string[] {"orange","pink", "red" };
       static string color1;
       static string color2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Master Mind");
            initColors();
            askColors();
            Console.ReadLine();
        }
        static void initColors()
        {
            Random rand = new Random();
            int index1 = rand.Next(0, colors.Length);
            int index2 = rand.Next(0, colors.Length);
            color1 = colors[index1];
            color2 = colors[index2];

        }
        static void askColors()
        {
            bool isWon = false;
            while (!isWon)
            {
                Console.WriteLine("Enter your guess");
                string guess = Console.ReadLine();
                isWon = checkGuess(guess);
            }
        }
        static bool checkGuess(string guess)
        {
            int colorsCorrect = 0;
            int positionsCorrect = 0;
            if(guess.Contains(color1))
            {
                colorsCorrect++;

            }
            if (guess.Contains(color2))
            {
                colorsCorrect++;

            }
            string[] parsedGuess = guess.Split(' ');
            if (parsedGuess[0] == color1)
            {
                positionsCorrect++;
            }
            if (parsedGuess[1] == color2)
            {
                positionsCorrect++;
            }
            if (positionsCorrect == 2)
            {
                Console.WriteLine("You Won!!!");
                return true;
            }
            else
            {
                Console.WriteLine($"Your hint is: {colorsCorrect}-{positionsCorrect}");
                return false;

            }
         
        }
    }
}
