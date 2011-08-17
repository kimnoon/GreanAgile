using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int row = 0;
            //int col = 0;
            // Console.ReadLine();
            Console.WriteLine("Thai Ceckers");
            Console.WriteLine("");
            Console.WriteLine("Initail broad");
            Console.WriteLine("");

            char[][] a = new char[10][];
            a[0] = new char[10] { '*', '*', '*', '*', '*', '*', '*', '*', '*', '*' };
            a[1] = new char[10] { '*', 'x', 'O', 'x', 'O', 'x', 'O', 'x', 'O', '*' };
            a[2] = new char[10] { '*', 'O', 'x', 'O', 'x', 'O', 'x', 'O', 'x', '*' };
            a[3] = new char[10] { '*', 'x', ' ', 'x', ' ', 'x', ' ', 'x', ' ', '*' };
            a[4] = new char[10] { '*', ' ', 'x', ' ', 'x', ' ', 'x', ' ', 'x', '*' };
            a[5] = new char[10] { '*', 'x', ' ', 'x', ' ', 'x', ' ', 'x', ' ', '*' };
            a[6] = new char[10] { '*', ' ', 'x', ' ', 'x', ' ', 'x', ' ', 'x', '*' };
            a[7] = new char[10] { '*', 'x', '0', 'x', '0', 'x', '0', 'x', '0', '*' };
            a[8] = new char[10] { '*', '0', 'x', '0', 'x', '0', 'x', '0', 'x', '*' };
            a[9] = new char[10] { '*', '*', '*', '*', '*', '*', '*', '*', '*', '*' };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}


