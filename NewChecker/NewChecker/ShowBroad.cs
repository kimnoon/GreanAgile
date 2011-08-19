using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewChecker
{
    class ShowBroad
    {
        static void white()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }
        static void black()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void black2()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void black3()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void yellow()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        static void yellow2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        static void bule()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        static void red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        static void green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void magenta()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        public static void ShowBr(string[][] a)
        {
            white();
            red();
            Console.WriteLine("==============================");
            black2();
            bule();
            Console.WriteLine("======== Thai Ceckers ========");
            black2();
            red();
            Console.WriteLine("==============================");
            black2();
            black2();
            Console.WriteLine("");

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] == " 1 "
                        || a[i][j] == " 2 "
                        || a[i][j] == " 3 "
                        || a[i][j] == " 4 "
                        || a[i][j] == " 5 "
                        || a[i][j] == " 6 "
                        || a[i][j] == " 7 "
                        || a[i][j] == " 8 "
                        || a[i][j] == " A "
                        || a[i][j] == " B "
                        || a[i][j] == " C "
                        || a[i][j] == " D "
                        || a[i][j] == " E "
                        || a[i][j] == " F "
                        || a[i][j] == " G "
                        || a[i][j] == " H ")
                    {
                        yellow();
                        black3();
                        Console.Write(a[i][j]);
                        black2();
                        black();

                    }

                    else if (a[i][j] == "   ")
                    {
                        white();
                        Console.Write(a[i][j]);
                        black();
                    }
                    else if (a[i][j] == "[O]")
                    {
                        magenta();
                        Console.Write(a[i][j]);
                        black2();
                    }
                    else if (a[i][j] == "[0]")
                    {
                        green();
                        Console.Write(a[i][j]);
                        black2();
                    }
                    else if (a[i][j] == "]H[")
                    {
                        green();
                        Console.Write(a[i][j]);
                        black2();
                    }
                    else if (a[i][j] == "]X[")
                    {
                        magenta();
                        Console.Write(a[i][j]);
                        black2();
                    }
                    else
                    {
                        Console.Write(a[i][j]);
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
