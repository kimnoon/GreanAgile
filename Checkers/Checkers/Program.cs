using System;
using System.Collections.Generic;

using System.Text;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine();
            Console.WriteLine("Thai Ceckers");
            Console.WriteLine("");
            Console.WriteLine("Initail broad");
            Console.WriteLine("");

            string[][] a = new string[10][];
            int rr, cc;
            a[0] = new string[10] { "[*]", "[1]", "[2]", "[3]", "[4]", "[5]", "[6]", "[7]", "[8]", "[*]" };
            a[1] = new string[10] { "[1]", "   ", "[O]", "   ", "[O]", "   ", "[O]", "   ", "[O]", "[*]" };
            a[2] = new string[10] { "[2]", "[O]", "   ", "[O]", "   ", "[O]", "   ", "[O]", "   ", "[*]" };
            a[3] = new string[10] { "[3]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "[*]" };
            a[4] = new string[10] { "[4]", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[*]" };
            a[5] = new string[10] { "[5]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "[*]" };
            a[6] = new string[10] { "[6]", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[ ]", "   ", "[*]" };
            a[7] = new string[10] { "[7]", "   ", "[0]", "   ", "[0]", "   ", "[0]", "   ", "[0]", "[*]" };
            a[8] = new string[10] { "[8]", "[0]", "   ", "[0]", "   ", "[0]", "   ", "[0]", "   ", "[*]" };
            a[9] = new string[10] { "[*]", "[*]", "[*]", "[*]", "[*]", "[*]", "[*]", "[*]", "[*]", "[*]" };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();




            while (true)
            {

                #region Choose

            L1: Console.Write("Enter row choose : ");
                int Rchoose = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter collumn choose : ");
                int Cchoose = Convert.ToInt32(Console.ReadLine());

                if (a[Rchoose][Cchoose] == "[O]" || a[Rchoose][Cchoose] == "[0]")
                {
                }
                else
                {
                    Console.WriteLine("Intput wrong!!");
                    goto L1;
                }
                #endregion



                if (a[Rchoose][Cchoose] == "[0]")
                {
                    #region eat 0
                     if ((a[Rchoose - 1][Cchoose - 1] == "[O]" && a[Rchoose - 2][Cchoose - 2] == "[ ]") || (a[Rchoose - 1][Cchoose + 1] == "[O]" && a[Rchoose - 2][Cchoose + 2] == "[ ]"))
                    {

                        Console.Write("Select row you want to eat : ");
                        cc = int.Parse(Console.ReadLine());
                        Console.Write("Select row you want to collumn : ");
                        rr = int.Parse(Console.ReadLine());
                        if (((cc == Rchoose - 1) && (rr == Cchoose - 1)) && a[Rchoose - 2][Cchoose - 2] == "[ ]")
                        {
                            a[Rchoose][Cchoose] = "[ ]";
                            a[cc][rr] = "[ ]";
                            a[Rchoose - 2][Cchoose - 2] = "[0]";
                            Rchoose = Rchoose - 2;
                            Cchoose = Cchoose - 2;
                        }
                        else if (((cc == Rchoose - 1) && (rr == Cchoose + 1)) && a[Rchoose - 2][Cchoose + 2] == "[ ]")
                        {
                            a[Rchoose][Cchoose] = "[ ]";
                            a[cc][rr] = "[ ]";
                            a[Rchoose - 2][Cchoose + 2] = "[0]";
                            Rchoose = Rchoose - 2;
                            Cchoose = Cchoose + 2;
                        }
                        #region showBo

                        Console.WriteLine(" ");

                        for (int i = 0; i < a.Length; i++)
                        {
                            for (int j = 0; j < a[i].Length; j++)
                            {
                                Console.Write(a[i][j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();

                        #endregion

                        goto L1;
                    }
                    else
                    {
                        Console.Write("Enter First Array Go : ");
                        int Fgo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second Array Go : ");
                        int Sgo = Convert.ToInt32(Console.ReadLine());

                        if (a[Fgo][Sgo] == "[ ]")
                        {
                            a[Fgo][Sgo] = "[0]";
                            a[Rchoose][Cchoose] = "[ ]";
                        }
                        else
                        {
                            Console.WriteLine("Intput wrong!!");
                            goto L1;
                        }

                    }
                    #endregion

                    #region showBo

                    Console.WriteLine(" ");

                    for (int i = 0; i < a.Length; i++)
                    {
                        for (int j = 0; j < a[i].Length; j++)
                        {
                            Console.Write(a[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();

                    #endregion

                }

                else if (a[Rchoose][Cchoose] == "[O]")
                {
                    #region eat O

                    if ((a[Rchoose - 1][Cchoose + 1] == "[0]" && a[Rchoose - 2][Cchoose + 2] == "[ ]") || (a[Rchoose + 1][Cchoose + 1] == "[0]" && a[Rchoose + 2][Cchoose + 2] == "[ ]"))
                    {
                        Console.Write("Select row you want to eat : "); 
                        cc = int.Parse(Console.ReadLine());
                        Console.Write("Select row you want to collumn : "); 
                        rr = int.Parse(Console.ReadLine());

                        if (((cc == Rchoose - 1) && (rr == Cchoose + 1)) && a[Rchoose - 2][Cchoose + 2] == "[ ]")
                        {
                            a[Rchoose][Cchoose] = "[ ]";
                            a[cc][rr] = "[ ]";
                            a[Rchoose - 2][Cchoose + 2] = "[O]";
                            Rchoose = Rchoose - 2;
                            Cchoose = Cchoose - 2;
                        }
                        else if (((cc == Rchoose + 1) && (rr == Cchoose + 1)) && a[Rchoose + 2][Cchoose + 2] == "[ ]")
                        {
                            a[Rchoose][Cchoose] = "[ ]";
                            a[cc][rr] = "[ ]";
                            a[Rchoose + 2][Cchoose + 2] = "[O]";
                            Rchoose = Rchoose + 2;
                            Cchoose = Cchoose - 2;
                        }

                        #region showBo

                        Console.WriteLine(" ");

                        for (int i = 0; i < a.Length; i++)
                        {
                            for (int j = 0; j < a[i].Length; j++)
                            {
                                Console.Write(a[i][j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();

                        #endregion

                        goto L1;

                    #endregion

                    }
                    else
                    {
                        Console.Write("Enter First Array Go : ");
                        int Fgo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second Array Go : ");
                        int Sgo = Convert.ToInt32(Console.ReadLine());
                        if (a[Fgo][Sgo] == "[ ]")
                        {
                            a[Fgo][Sgo] = "[O]";
                            a[Rchoose][Cchoose] = "[ ]";
                        }
                        else
                        {
                            Console.WriteLine("Intput wrong!!");
                            goto L1;
                        }
                    }

                    #region showBo

                    Console.WriteLine(" ");

                    for (int i = 0; i < a.Length; i++)
                    {
                        for (int j = 0; j < a[i].Length; j++)
                        {
                            Console.Write(a[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();

                    #endregion
                }

            }
        }
    }
}


