using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewChecker
{
    class Walk
    {
        public static void SimpleWalk(string b,string[][] a)
        {
            #region choose

            int[] c = new int[2];
            c = Input.ex(b);
            int Rchoose = c[0];
            int Cchoose = c[1];

            if (a[Rchoose][Cchoose] == "[O]" || a[Rchoose][Cchoose] == "[0]")
            {
            }
            else
            {
                Console.WriteLine();
                Console.Clear();
                ShowBroad.ShowBr(a);
                Console.WriteLine("Intput wrong please try again!!");
            }

            #endregion

            #region walk O and Eat of O

            if (a[Rchoose][Cchoose] == "[O]")
            {
            EatO:
                if ((a[Rchoose - 1][Cchoose + 1] == "[0]" && a[Rchoose - 2][Cchoose + 2] == "[ ]") || (a[Rchoose + 1][Cchoose + 1] == "[0]" && a[Rchoose + 2][Cchoose + 2] == "[ ]"))
                {
                    int[] e = new int[2];
                    Console.Write("Eat  :");
                    e = Input.ex(Console.ReadLine());
                    int Erow = e[0];
                    int Ecol = e[1];

                    if (((Erow == Rchoose - 1) && (Ecol == Cchoose + 1)) && a[Rchoose - 2][Cchoose + 2] == "[ ]")
                    {
                        a[Rchoose][Cchoose] = "[ ]";
                        a[Erow][Ecol] = "[ ]";
                        a[Rchoose - 2][Cchoose + 2] = "[O]";
                        Rchoose = Rchoose - 2;
                        Cchoose = Cchoose - 2;
                    }
                    else if (((Erow == Rchoose + 1) && (Ecol == Cchoose + 1)) && a[Rchoose + 2][Cchoose + 2] == "[ ]")
                    {
                        a[Rchoose][Cchoose] = "[ ]";
                        a[Erow][Ecol] = "[ ]";
                        a[Rchoose + 2][Cchoose + 2] = "[O]";
                        Rchoose = Rchoose + 2;
                        Cchoose = Cchoose - 2;
                    }

                    Console.WriteLine();
                    Console.Clear();
                    ShowBroad.ShowBr(a);

                    goto EatO;
                }
                else
                {
                    int[] g = new int[2];
                    Console.Write("Enter go : ");
                    g = Input.ex(Console.ReadLine());
                    int Rgo = g[0];
                    int Cgo = g[1];
                    if (((Rgo == Rchoose + 1) && (Cgo == Cchoose - 1))
                        || ((Rgo == Rchoose + 1) && (Cgo == Cchoose + 1))
                        && a[Rgo][Cgo] == "[ ]")
                    {
                        a[Rgo][Cgo] = "[O]";
                        a[Rchoose][Cchoose] = "[ ]";
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Clear();
                        ShowBroad.ShowBr(a);
                        Console.WriteLine("Intput wrong please try again!!");
                    }

                }
            }

            #endregion

            #region walk 0 and Eat of 0

            else if (a[Rchoose][Cchoose] == "[0]")
            {
            Eat0:
                if ((a[Rchoose - 1][Cchoose - 1] == "[O]" && a[Rchoose - 2][Cchoose - 2] == "[ ]") || (a[Rchoose - 1][Cchoose + 1] == "[O]" && a[Rchoose - 2][Cchoose + 2] == "[ ]"))
                {
                    int[] e = new int[2];
                    Console.Write("Eat  :");
                    e = Input.ex(Console.ReadLine());
                    int Erow = e[0];
                    int Ecol = e[1];

                    if (((Erow == Rchoose - 1) && (Ecol == Cchoose - 1)) && a[Rchoose - 2][Cchoose - 2] == "[ ]")
                    {
                        a[Rchoose][Cchoose] = "[ ]";
                        a[Erow][Ecol] = "[ ]";
                        a[Rchoose - 2][Cchoose - 2] = "[0]";
                        Rchoose = Rchoose - 2;
                        Cchoose = Cchoose - 2;
                    }
                    else if (((Erow == Rchoose - 1) && (Ecol == Cchoose + 1)) && a[Rchoose - 2][Cchoose + 2] == "[ ]")
                    {
                        a[Rchoose][Cchoose] = "[ ]";
                        a[Erow][Ecol] = "[ ]";
                        a[Rchoose - 2][Cchoose + 2] = "[0]";
                        Rchoose = Rchoose - 2;
                        Cchoose = Cchoose + 2;
                    }

                    Console.WriteLine();
                    Console.Clear();
                    ShowBroad.ShowBr(a);

                    goto Eat0;
                }
                else
                {
                    int[] g = new int[2];
                    Console.Write("Enter go : ");
                    g = Input.ex(Console.ReadLine());
                    int Rgo = g[0];
                    int Cgo = g[1];
                    if (((Rgo == Rchoose - 1) && (Cgo == Cchoose - 1))
                        || ((Rgo == Rchoose - 1) && (Cgo == Cchoose + 1))
                        && a[Rgo][Cgo] == "[ ]")
                    {
                        a[Rgo][Cgo] = "[0]";
                        a[Rchoose][Cchoose] = "[ ]";
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Clear();
                        ShowBroad.ShowBr(a);
                        Console.WriteLine("Intput wrong please try again!!");
                    }

                }
            }

            #endregion
        }

        public static void turnPlayer(int kill, int turn)
        {
            if (turn == 0)
            {
                Console.WriteLine("Player O Go!");
            }
            else
            {
                Console.WriteLine("Player 0 Go!");
            }
        }
    }
}


