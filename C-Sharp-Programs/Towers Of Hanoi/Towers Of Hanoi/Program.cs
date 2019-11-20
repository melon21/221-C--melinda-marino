using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towers_Of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Towers Of Hanoi");
            int[] num = { 1, 2, 3, 4 };
            char[] letter = { 'A', 'B', 'C', 'D' };

            Dictionary<string, Stack<int>> pegs = new Dictionary<string, Stack<int>>();
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            pegs.Add("A", stack);
            pegs.Add("B", new Stack<int>());
            pegs.Add("C", new Stack<int>());
            pegs.Add("D", new Stack<int>());


            foreach (var name in pegs)
            {
                Console.Write(name.Key + ":");
                foreach (int value in name.Value)
                {
                    Console.Write(value.ToString());
                }
                Console.WriteLine();
            }
                Console.ReadKey();

            if(num)
            {

            }



        }
    }
}
