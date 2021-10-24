using System;
using System.IO;

namespace Lab1_3
{
    public static class Lab1_3
    {   
        public static void Main()
        {
            f();
        }
        static void FindIndex(int[][] matrix, int? value)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix[x].Length; y++)
                {
                    if (matrix[x][y] == value)
                    {
                        Console.WriteLine($"{x} {y} {value}");
                    }
                }
            }
        }
        static void f()
        {
            int? mn = null;
            int? mx = null;
            int[] nom = null;
            int[][] stpmass = null;
            Random ran = new Random();
            string a = Console.ReadLine();
            switch (a)
            {
                case "kb":
                    stpmass = new int[int.Parse(Console.ReadLine())][];
                    for (int i = 0; i < stpmass.GetLength(0); i++)
                    {
                        int[] mass = Array.ConvertAll(Console.ReadLine().Split(" "), z => int.Parse(z));
                        stpmass[i] = new int[mass.Length];
                        if (mx == null | mn == null)
                        {
                            mn = mass[1];
                            mx = mass[1];
                        }
                        for (int x = 0; x < mass.Length; x++)
                        {
                            stpmass[i][x] = mass[x];
                            if (mn > mass[x])
                            {
                                mn = mass[x];
                            }
                            if (mx < mass[x])
                            {
                                mx = mass[x];
                            }
                        }
                    }
                    for (int c = 0; c < stpmass.GetLength(0); c++)
                    {
                        Console.WriteLine("{0}", string.Join(" ", stpmass[c]));
                    }
                    FindIndex(stpmass, mn);
                    FindIndex(stpmass, mx);
                    nom = Array.ConvertAll(Console.ReadLine().Split(" "), m => int.Parse(m));
                    stpmass[nom[0]][nom[1]] = ran.Next(0, 1000);
                    Console.WriteLine("{0}", string.Join(" ", stpmass[nom[0]]));
                    break;
                case "fl":
                    StreamReader sr = new StreamReader("Lab3.txt");
                    stpmass = new int[int.Parse(sr.ReadLine())][];
                    for (int i = 0; i < stpmass.GetLength(0); i++)
                    {
                        int[] mass = Array.ConvertAll(sr.ReadLine().Split(" "), z => int.Parse(z));
                        stpmass[i] = new int[mass.Length];
                        if (mx == null | mn == null)
                        {
                            mn = mass[1];
                            mx = mass[1];
                        }
                        for (int x = 0; x < mass.Length; x++)
                        {
                            stpmass[i][x] = mass[x];
                            if (mn > mass[x])
                            {
                                mn = mass[x];

                            }
                            if (mx < mass[x])
                            {
                                mx = mass[x];
                            }
                        }
                    }   
                    for (int c = 0; c < stpmass.GetLength(0); c++)
                    {
                        Console.WriteLine("{0}", string.Join(" ", stpmass[c]));
                    }
                    FindIndex(stpmass, mn);
                    FindIndex(stpmass, mx);
                    nom = Array.ConvertAll(sr.ReadLine().Split(" "), m => int.Parse(m));
                    stpmass[nom[0]][nom[1]] = ran.Next(0, 1000);
                    Console.WriteLine("{0}", string.Join(" ", stpmass[nom[0]]));
                    sr.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
