using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewChecker
{
    class Input
    {
        public static int[] ex(string input)
        {
            int[] a = new int[2];

            if ((input[0] == 'a') || (input[0] == 'A'))
            {
                a[0] = 1;
            }
            else if ((input[0] == 'b') || (input[0] == 'B'))
            {
                a[0] = 2;
            }
            else if ((input[0] == 'C') || (input[0] == 'c'))
            {
                a[0] = 3;
            }
            else if ((input[0] == 'D') || (input[0] == 'd'))
            {
                a[0] = 4;
            }
            else if ((input[0] == 'E') || (input[0] == 'e'))
            {
                a[0] = 5;
            }
            else if ((input[0] == 'F') || (input[0] == 'f'))
            {
                a[0] = 6;
            }
            else if ((input[0] == 'g') || (input[0] == 'G'))
            {
                a[0] = 7;
            }
            else if ((input[0] == 'h') || (input[0] == 'H'))
            {
                a[0] = 8;
            }
            else
            {
                Console.WriteLine("input wrong!!");
            }

            if (input[1] == '1')
            {
                a[1] = 1;
            }
            else if (input[1] == '2')
            {
                a[1] = 2;
            }
            else if (input[1] == '3')
            {
                a[1] = 3;
            }
            else if (input[1] == '4')
            {
                a[1] = 4;
            }
            else if (input[1] == '5')
            {
                a[1] = 5;
            }
            else if (input[1] == '6')
            {
                a[1] = 6;
            }
            else if (input[1] == '7')
            {
                a[1] = 7;
            }
            else if (input[1] == '8')
            {
                a[1] = 8;
            }
            else
            {
                Console.WriteLine("input wrong!!");
            }
            return a;
        }
    }
}
