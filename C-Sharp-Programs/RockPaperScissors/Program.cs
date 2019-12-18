using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, or Scissors");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "Rock")
                {
                    Console.WriteLine("The computer chose Rock");
                    Console.WriteLine("It is a tie");
                }
                else if (userChoice == "Paper")
                {
                    Console.WriteLine("The computer chose Paper");
                    Console.WriteLine("It is a tie");

                }
                else if (userChoice == "Scissors")
                {
                    Console.WriteLine("The computer chose Scissors");
                    Console.WriteLine("It is a tie");
                }
                else
                {
                    Console.WriteLine("You must choose Rock, Paper, or Scissors!");

                }

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "Rock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Sorry you lose, Paper beat Rock");

                }
                else if (userChoice == "Paper")
                {
                    Console.WriteLine("The computer chose Scissors");
                    Console.WriteLine("Sorry you lose, Scissors beat Paper ");

                }
                else if (userChoice == "Scissors")
                {
                    Console.WriteLine("The computer chose Rock");
                    Console.WriteLine("Sorry you lose, Rock beats Scissors");
                }
                else
                {
                    Console.WriteLine("You must choose Rock, Paper, or Scissors!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "Rock")
                {
                    Console.WriteLine("The computer chose Scissors");
                    Console.WriteLine("You win, Rock beats Scissors");

                }
                else if (userChoice == "Paper")
                {
                    Console.WriteLine("The computer chose Rock");
                    Console.WriteLine("You win, Paper beats Rock");

                }
                else if (userChoice == "Scissors")
                {
                    Console.WriteLine("The computer chose Paper");
                    Console.WriteLine("You win, Scissors beat Paper");

                }
                else
                {
                    Console.WriteLine("You must choose Rock, Paper, or Scissors!");

                }

            }

            Console.ReadLine();
        }
    }
    
}
