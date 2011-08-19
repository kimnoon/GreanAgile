using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewChecker
{
    class Walk
    {
        static void green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void magenta()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        static void black2()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void SimpleWalk(string[][] a, string player1, string player2)
        {
            int kill = 0, turn = 0;

     Begin: if (turn == 0)
            {
                magenta();
                Console.WriteLine("player1 " + player1 + " GO!");
                black2();
                Console.WriteLine();
                kill = 0;
            }
            else
            {
                green();
                Console.WriteLine("player2 " + player2 + " GO!");
                black2();
                Console.WriteLine();
                kill = 0;
            }

            Console.Write("Enter choose : ");
            string b = Convert.ToString(Console.ReadLine());

            #region choose

            int[] c = new int[2];
            c = Input.ex(b);
            int Rchoose = c[0];
            int Cchoose = c[1];

            if ((a[Rchoose][Cchoose] == "[O]" || a[Rchoose][Cchoose] == "[0]") || (a[Rchoose][Cchoose] == "]X[" || a[Rchoose][Cchoose] == "]H["))
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
                turn = 1;
            EatO:
                if (((a[Rchoose + 1][Cchoose + 1] == "[0]" && a[Rchoose + 2][Cchoose + 2] == "[ ]") || (a[Rchoose + 1][Cchoose - 1] == "[0]" && a[Rchoose + 2][Cchoose - 2] == "[ ]")) || ((a[Rchoose + 1][Cchoose + 1] == "]H[" && a[Rchoose + 2][Cchoose + 2] == "[ ]") || (a[Rchoose + 1][Cchoose - 1] == "]H[" && a[Rchoose + 2][Cchoose - 2] == "[ ]")))
                {
                    kill = 1;

                    int[] e = new int[2];
                    Console.Write("Eat  :");
                    e = Input.ex(Console.ReadLine());
                    int Erow = e[0];
                    int Ecol = e[1];

                    if (((Erow == Rchoose + 1) && (Ecol == Cchoose + 1)) && a[Rchoose + 2][Cchoose + 2] == "[ ]")
                    {
                        a[Rchoose][Cchoose] = "[ ]";
                        a[Erow][Ecol] = "[ ]";
                        a[Rchoose + 2][Cchoose + 2] = "[O]";
                        Rchoose = Rchoose + 2;
                        Cchoose = Cchoose + 2;
                        if (Rchoose == 8)
                        {
                            a[Rchoose][Cchoose] = "]X[";

                        }
                    }
                    else if (((Erow == Rchoose + 1) && (Ecol == Cchoose - 1)) && a[Rchoose + 2][Cchoose - 2] == "[ ]")
                    {
                        a[Rchoose][Cchoose] = "[ ]";
                        a[Erow][Ecol] = "[ ]";
                        a[Rchoose + 2][Cchoose - 2] = "[O]";
                        Rchoose = Rchoose + 2;
                        Cchoose = Cchoose - 2;
                        if (Rchoose == 8)
                        {
                            a[Rchoose][Cchoose] = "]X[";

                        }
                    }

                    Console.WriteLine();
                    Console.Clear();
                    ShowBroad.ShowBr(a);

                    goto EatO;
                }
                else if (kill == 0)
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
                        if (Rgo == 8)
                        {
                            a[Rgo][Cgo] = "]X[";
                            a[Rchoose][Cchoose] = "[ ]";
                        }
                        else
                        {
                            a[Rgo][Cgo] = "[O]";
                            a[Rchoose][Cchoose] = "[ ]";
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Clear();
                        ShowBroad.ShowBr(a);
                        Console.WriteLine("Intput wrong please try again!!");
                    }

                }
                Console.Clear();
                ShowBroad.ShowBr(a);
                goto Begin;
            }

            #endregion

            #region walk 0 and Eat of 0

            else if (a[Rchoose][Cchoose] == "[0]")
            {
                turn = 0;
            Eat0:
                if (((a[Rchoose - 1][Cchoose - 1] == "[O]" && a[Rchoose - 2][Cchoose - 2] == "[ ]") || (a[Rchoose - 1][Cchoose + 1] == "[O]" && a[Rchoose - 2][Cchoose + 2] == "[ ]")) || ((a[Rchoose - 1][Cchoose - 1] == "]X[" && a[Rchoose - 2][Cchoose - 2] == "[ ]") || (a[Rchoose - 1][Cchoose + 1] == "]X[" && a[Rchoose - 2][Cchoose + 2] == "[ ]")))
                {
                    kill = 1;

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
                        if (Rchoose == 1)
                        {
                            a[Rchoose][Cchoose] = "]H[";

                        }
                    }
                    else if (((Erow == Rchoose - 1) && (Ecol == Cchoose + 1)) && a[Rchoose - 2][Cchoose + 2] == "[ ]")
                    {
                        a[Rchoose][Cchoose] = "[ ]";
                        a[Erow][Ecol] = "[ ]";
                        a[Rchoose - 2][Cchoose + 2] = "[0]";
                        Rchoose = Rchoose - 2;
                        Cchoose = Cchoose + 2;
                        if (Rchoose == 1)
                        {
                            a[Rchoose][Cchoose] = "]H[";

                        }
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
                        if (Rgo == 1)
                        {
                            a[Rgo][Cgo] = "]H[";
                            a[Rchoose][Cchoose] = "[ ]";
                        }
                        else
                        {
                            a[Rgo][Cgo] = "[0]";
                            a[Rchoose][Cchoose] = "[ ]";
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Clear();
                        ShowBroad.ShowBr(a);
                        Console.WriteLine("Intput wrong please try again!!");
                    }

                }
                Console.Clear();
                ShowBroad.ShowBr(a);
                goto Begin;
            }
            #endregion

            #region horse O
            else if (a[Rchoose][Cchoose] == "]X[")
            {
                turn = 1;
            Eathorse0: int[] e = new int[2];
                Console.Write("Hot GO :");
                e = Input.ex(Console.ReadLine());
                int Erow = e[0];
                int Ecol = e[1];

                
                if (((Erow < Rchoose) && (Ecol < Cchoose)) && (a[Erow - 1][Ecol - 1] == "[ ]"))
                {
                    kill = 1;
                    a[Rchoose][Cchoose] = "[ ]";
                    a[Erow][Ecol] = "[ ]";
                    a[Erow - 1][Ecol - 1] = "]X[";
                    Rchoose = Ecol - 1;
                    Cchoose = Erow - 1;
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    goto Eathorse0;
                }
                else if (((Erow < Rchoose) && (Ecol > Cchoose)) && (a[Erow - 1][Ecol + 1] == "[ ]"))
                {
                    kill = 1;
                    a[Rchoose][Cchoose] = "[ ]";
                    a[Erow][Ecol] = "[ ]";
                    a[Erow - 1][Ecol + 1] = "]X[";
                    Rchoose = Ecol - 1;
                    Cchoose = Erow + 1;
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    goto Eathorse0;
                }
                else if (((Erow > Rchoose) && (Ecol < Cchoose)) && (a[Erow + 1][Ecol - 1] == "[ ]"))
                {
                    kill = 1;
                    a[Rchoose][Cchoose] = "[ ]";
                    a[Erow][Ecol] = "[ ]";
                    a[Erow + 1][Ecol - 1] = "]X[";
                    Rchoose = Ecol + 1;
                    Cchoose = Erow - 1;
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    goto Eathorse0;
                }
                else if (((Erow > Rchoose) && (Ecol > Cchoose)) && (a[Erow + 1][Ecol + 1] == "[ ]"))
                {
                    kill = 1;
                    a[Rchoose][Cchoose] = "[ ]";
                    a[Erow][Ecol] = "[ ]";
                    a[Erow + 1][Ecol + 1] = "]X[";
                    Rchoose = Ecol + 1;
                    Cchoose = Erow + 1;
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    goto Eathorse0;
                }
                else if ((kill == 0)&&(a[Erow][Ecol] == "[ ]"))
                {
                    a[Erow][Ecol] = "]X[";
                    a[Rchoose][Cchoose] = "[ ]";
                }
                else 
                
                {
                    Console.WriteLine();
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    Console.WriteLine("Intput wrong please try again!!");
                }

                Console.WriteLine();
                Console.Clear();
                ShowBroad.ShowBr(a);
                goto Begin;
            }

            #endregion

            #region horse 0
            else if (a[Rchoose][Cchoose] == "]H[")
            {
                turn = 0;
            Eathorse0:
                int[] e = new int[2];
                Console.Write("Hot GO :");
                e = Input.ex(Console.ReadLine());
                int Erow = e[0];
                int Ecol = e[1];

                
                if (((Erow < Rchoose) && (Ecol < Cchoose)) && (a[Erow - 1][Ecol - 1] == "[ ]"))
                {
                    kill = 1 ;
                    a[Rchoose][Cchoose] = "[ ]";
                    a[Erow][Ecol] = "[ ]";
                    a[Erow - 1][Ecol - 1] = "]H[";
                    Rchoose = Ecol - 1;
                    Cchoose = Erow - 1;
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    goto Eathorse0;
                }
                else if (((Erow < Rchoose) && (Ecol > Cchoose)) && (a[Erow - 1][Ecol + 1] == "[ ]"))
                {
                    kill = 1;
                    a[Rchoose][Cchoose] = "[ ]";
                    a[Erow][Ecol] = "[ ]";
                    a[Erow - 1][Ecol + 1] = "]H[";
                    Rchoose = Ecol - 1;
                    Cchoose = Erow + 1;
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    goto Eathorse0;
                }
                else if (((Erow > Rchoose) && (Ecol < Cchoose)) && (a[Erow + 1][Ecol - 1] == "[ ]"))
                {
                    kill = 1;
                    a[Rchoose][Cchoose] = "[ ]";
                    a[Erow][Ecol] = "[ ]";
                    a[Erow + 1][Ecol - 1] = "]H[";
                    Rchoose = Ecol + 1;
                    Cchoose = Erow - 1;
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    goto Eathorse0;
                }
                else if (((Erow > Rchoose) && (Ecol > Cchoose)) && (a[Erow + 1][Ecol + 1] == "[ ]"))
                {
                    kill = 1;
                    a[Rchoose][Cchoose] = "[ ]";
                    a[Erow][Ecol] = "[ ]";
                    a[Erow + 1][Ecol + 1] = "]H[";
                    Rchoose = Ecol + 1;
                    Cchoose = Erow + 1;
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    goto Eathorse0;
                }
                else if ((kill == 0) && (a[Erow][Ecol] == "[ ]"))
                {
                    a[Erow][Ecol] = "]H[";
                    a[Rchoose][Cchoose] = "[ ]";
                }
                else
                {
                    Console.WriteLine();
                    Console.Clear();
                    ShowBroad.ShowBr(a);
                    Console.WriteLine("Intput wrong please try again!!");
                }

                Console.WriteLine();
                Console.Clear();
                ShowBroad.ShowBr(a);

                goto Begin;
            }

            #endregion
        }
    }
}


