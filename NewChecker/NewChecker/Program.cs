using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Name Player1 : ");
            string player1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Name Player2 : ");
            string player2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            
            Console.Clear();
            

            #region Broad input

            string[][] a = new string[10][];
            a[0] = new string[10] { "   ", " 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", "   " };
            a[1] = new string[10] { " A ", "   ", "[O]", "   ", "[O]", "   ", "[O]", "   ", "[O]", " A " };
            a[2] = new string[10] { " B ", "[O]", "   ", "[O]", "   ", "[O]", "   ", "[O]", "   ", " B " };
            a[3] = new string[10] { " C ", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", " C " };
            a[4] = new string[10] { " D ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", " D " };
            a[5] = new string[10] { " E ", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", " E " };
            a[6] = new string[10] { " F ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", " F " };
            a[7] = new string[10] { " G ", "   ", "[0]", "   ", "[0]", "   ", "[0]", "   ", "[0]", " G " };
            a[8] = new string[10] { " H ", "[0]", "   ", "[0]", "   ", "[0]", "   ", "[0]", "   ", " H " };
            a[9] = new string[10] { "   ", " 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", "   " };

            #endregion

            ShowBroad.ShowBr(a);

            while (true)
            {

                Walk.SimpleWalk(a,player1,player2);
            }
        }
    }
}
