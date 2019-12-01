using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towers_Of_Hanoi
{
    class Program
    {    //this makes the pegs and makes them able to stack onto eachother
        static Dictionary<string, Stack<int>> pegs = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {   //Writes the name of the game
            Console.WriteLine("This is the Towers Of Hanoi");
            //these are the "tiles"
            int[] num = { 1, 2, 3, 4 };

            //Calls the function initTower
            initTowers();
            //Calls the function  printTowers
            printTowers();
            //Calls the function playGame
            playGame();
            // makes the imput readable
            Console.ReadKey();

        }
        static void printTowers()
        {   //shows each peg name
            foreach (var name in pegs)
            {   //writes how it will be displayed
                Console.Write(name.Key + ":");
                //sepparates each of the tiles to use
                foreach (int value in name.Value)
                {
                    //writes the value
                    Console.Write(value.ToString());
                }
                //writes it out
                Console.WriteLine();
            }
        }
        static void initTowers()
        {
            //How to make a stack and the order its stacked in
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            //the order the pegs are in, also being able to contain a stack
            pegs.Add("A", stack);
            pegs.Add("B", new Stack<int>());
            pegs.Add("C", new Stack<int>());
        }
        static bool isFinished()
        {
            //
            Stack<int> stackC = pegs["C"];
            //if it is true it applys
            if (stackC.Count == 4)
            { return true; }
            //if its false then it will return false
            else
            { return false; }
        }
        static bool canMove(string from, string to)
        {
            if(!pegs.ContainsKey(from) || !pegs.ContainsKey(to))
            {
                return false;
            }
            Stack<int> fromTower = pegs[from];
            Stack<int> toTower = pegs[to];
            if(toTower.Count==0)
            {
                return true;
            }
            int fromDisk = fromTower.Peek();
            int toDisk = toTower.Peek();
            if (fromDisk > toDisk)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void move(string from, string to)
        {   //if it can't move ftom and to
            if (!canMove(from, to))
            {   //It will display an error messege
                Console.WriteLine("Error, illegal move!");
                return;
            }

            Stack<int> fromTower = pegs[from];
            Stack<int> toTower = pegs[to];
            int fromDisk = fromTower.Pop();
            toTower.Push(fromDisk);
        }
        static void playGame()
        {
            while (true)
            {
                Console.WriteLine("What tower should we move from? A, B, or C?");
                string fromTower = Console.ReadLine();
                Console.WriteLine("What tower should we move to?");
                string toTower = Console.ReadLine();
                move(fromTower, toTower);
                printTowers();
                if (isFinished())
                {
                 
                    Console.WriteLine("Congrads!!! You solved the tower!!!");
                    return;

                }
            }
        }
    }
}