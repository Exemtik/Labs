using System;
using System.IO;

namespace Lab1_2
{
    public static class Lab1_2
    {   
        public static void Main()
        {
            f2();
        }
        static void f2()
        {
            int? mn = null;
            int? mx = null;
            int mnx = 0;
            int mny = 0;
            int mxy = 0;
            int mxx = 0;
            int[] vvod2 = null;
            int[,] matr2 = null;
            int[] vvod1 = null;
            int[,] matr = null;
            string a = Console.ReadLine();
            switch (a)
            {
                case "kb":
                    vvod1 = Array.ConvertAll(Console.ReadLine().Split(" "), z => int.Parse(z));
                    matr = new int[vvod1[0], vvod1[1]];
                    for (int x = 0; x < matr.GetLength(0); x++)
                    {
                        int[] mass1 = Array.ConvertAll(Console.ReadLine().Split(" "), z => int.Parse(z));
                        if (mn == null | mx == null)
                        {
                            mn = mass1[0];
                            mx = mass1[0];
                        }
                        for (int y = 0; y < matr.GetLength(1); y++)
                        {
                            matr[x, y] = mass1[y];
                            if (mn > mass1[y])
                            {
                                mn = mass1[y];
                                mnx = x;
                                mny = y;

                            }
                            if (mx < mass1[y])
                            {
                                mx = mass1[y];
                                mxx = x;
                                mxy = y;
                            }
                        }
                    }
                    vvod2 = Array.ConvertAll(Console.ReadLine().Split(" "), z => int.Parse(z));
                    matr2 = new int[vvod2[0], vvod2[1]];
                    for (int x = 0; x < matr.GetLength(0); x++)
                    {
                        int[] mass2 = Array.ConvertAll(Console.ReadLine().Split(" "), z => int.Parse(z));
                        for (int y = 0; y < matr.GetLength(1); y++)
                        {
                            matr2[x, y] = mass2[y];
                        }
                    }
                    for (int i = 0; i < matr.GetLength(0); i++)
                    {
                        for (int j = 0; j < matr.GetLength(1); j++)
                        {
                            Console.Write(matr[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"{mx} {mxx} {mxy}");
                    Console.WriteLine($"{mn} {mnx} {mny}");
                    func(matr, matr2, "*");
                    func(matr, matr2, "+");
                    func(matr, matr2, "-");
                    break;
                case "fl":
                    StreamReader sr = new StreamReader("Lab2.txt");
                    vvod1 = Array.ConvertAll(sr.ReadLine().Split(" "), z => int.Parse(z));
                    matr = new int[vvod1[0], vvod1[1]];
                    for (int x = 0; x < matr.GetLength(0); x++)
                    {
                        int[] mass1 = Array.ConvertAll(sr.ReadLine().Split(" "), z => int.Parse(z));
                        if (mn == null | mx == null)
                        {
                            mn = mass1[0];
                            mx = mass1[0];
                        }
                        for (int y = 0; y < matr.GetLength(1); y++)
                        {
                            matr[x, y] = mass1[y];
                            if (mn > mass1[y])
                            {
                                mn = mass1[y];
                                mnx = x;
                                mny = y;

                            }
                            if (mx < mass1[y])
                            {
                                mx = mass1[y];
                                mxx = x;
                                mxy = y;
                            }
                        }
                    }
                    vvod2 = Array.ConvertAll(sr.ReadLine().Split(" "), z => int.Parse(z));
                    matr2 = new int[vvod2[0], vvod2[1]];
                    for (int x = 0; x < matr.GetLength(0); x++)
                    {
                        int[] mass2 = Array.ConvertAll(sr.ReadLine().Split(" "), z => int.Parse(z));
                        for (int y = 0; y < matr.GetLength(1); y++)
                        {
                            matr2[x, y] = mass2[y];
                        }
                    }
                    for (int i = 0; i < matr.GetLength(0); i++)
                    {
                        for (int j = 0; j < matr.GetLength(1); j++)
                        {
                            Console.Write(matr[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"{mx} {mxx} {mxy}");
                    Console.WriteLine($"{mn} {mnx} {mny}");
                    func(matr, matr2, "*");
                    func(matr, matr2, "+");
                    func(matr, matr2, "-");
                    sr.Close();
                    break;
                default:
                    break;
            }

            static void func(int[,] matr, int[,] matr2, string k)
            {
                switch (k)
                {
                    case "*":
                        try
                        {
                            for (int x = 0; x < matr.GetLength(0); x++)
                            {
                                for (int y = 0; y < matr.GetLength(1); y++)
                                {
                                    Console.WriteLine("{0}", string.Join(" ", matr[x, y] * matr2[x, y]));
                                }
                            }
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Add недопустима!");
                            break;
                        }
                    case "+":
                        try
                        {
                            for (int x = 0; x < matr.GetLength(0); x++)
                            {
                                for (int y = 0; y < matr.GetLength(1); y++)
                                {
                                    Console.WriteLine("{0}", string.Join(" ", matr[x, y] + matr2[x, y]));
                                }
                            }
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Add недопустима!");
                            break;
                        }
                    case "-":
                        try
                        {
                            for (int x = 0; x < matr.GetLength(0); x++)
                            {
                                for (int y = 0; y < matr.GetLength(1); y++)
                                {
                                    Console.WriteLine("{0}", string.Join(" ", matr[x, y] - matr2[x, y]));
                                }
                            }
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Subtract недопустима!");
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}

