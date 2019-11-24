using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towers_Of_Hanoi
{
    class Program
    {
        static Dictionary<string, Stack<int>> pegs = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Towers Of Hanoi");
            int[] num = { 1, 2, 3, 4 };


            initTowers();

            printTowers();
            playGame();

            Console.ReadKey();

        }
        static void printTowers()
        {
            foreach (var name in pegs)
            {
                Console.Write(name.Key + ":");
                foreach (int value in name.Value)
                {
                    Console.Write(value.ToString());
                }
                Console.WriteLine();
            }
        }
        static void initTowers()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            pegs.Add("A", stack);
            pegs.Add("B", new Stack<int>());
            pegs.Add("C", new Stack<int>());
        }
        static bool isFinished()
        {
            Stack<int> stackC = pegs["C"];
            if (stackC.Count == 4)
            { return true; }
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
        {
            if (!canMove(from, to))
            {
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