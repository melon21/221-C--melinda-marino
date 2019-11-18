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
            int[] num = { '1', '2', '3', '4' };
            char[] letter = { 'A', 'B', 'C', 'D' };

            foreach (char i in letter)
            {
                Console.WriteLine(i);
            }
            foreach (char i in num)
            {
                Console.WriteLine(num);
            }
          //  {
            //    List<int> A = new List<int>(num);
              //  List<int> B = new List<int>(num);
                //List<int> C = new List<int>(num);
               // for (int i = num; i > 0; i--) ;
                // Console.WriteLine("A: "(tiles);
                // Console.WriteLine("B: "(0));
                //Console.WriteLine(C: (0));
                // Console.ReadLine();
            }
        }
    }
