using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
       
        
       public static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static int player = 1;
        public static int choice;
         static string X = "X";
        static string O = "O";
        public static int flag = 0;

      
        
        static void Main(string[] args)
        {
            string player1 = "", player2 = "";
            int choice = 0, turn = 1, score1 = 0, score2 = 0;
            bool winFlag = false, playing = true, correctInput = false;
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("What is Player 1's name?");
            player1 = Console.ReadLine();
            Console.WriteLine("What is Player 2's name?");
            player2 = Console.ReadLine();
            Console.WriteLine("Player 1 {0} is O, and Player 2 {1} is X", player1, player2);
            Console.WriteLine("{0} The First player starts!!!", player1);
            Console.ReadLine();
            Console.Clear();

            Console.Clear();
            //this writes the board with 3 rows and columns
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
            Console.ReadLine();

            if(X == "win")
            {
                 Console.WriteLine("You have won!!!!");
            }
            if (O == "win")
            {
                Console.WriteLine("You have won!!!!");
            }



        }


    }
    }
