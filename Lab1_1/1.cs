using System;
using System.IO;

namespace Lab_1_1
{
    public static class Lab_1_1
    {   
        public static void Main()
        {
            f1();
        }
        static void f1()
        {
            string k = null;
            int[] mass1 = null;
            int mn = 0;
            int mx = 0;
            int imn = 0;
            int imx = 0;
            int value = 0;
            string a = Console.ReadLine();
            switch (a)
            {
                case "kb":
                    k = Console.ReadLine();
                    mass1 = Array.ConvertAll(Console.ReadLine().Split(' '), mass1 => int.Parse(mass1));
                    Console.WriteLine("{0}", string.Join(" ", mass1));
                    for (int i = 0; i < mass1.Length; i++)
                    {
                        if (i == 0)
                        {
                            mn = mass1[i];
                            mx = mass1[i];
                        }
                        if (mn > mass1[i])
                        {
                            mn = mass1[i];
                            imn = i;
                        }
                        if (mx < mass1[i])
                        {
                            mx = mass1[i];
                            imx = i;
                        }

                    }
                    Console.WriteLine($"{mx} {imx} ");
                    Console.WriteLine($"{mn} {imn} ");
                    switch (k)
                    {
                        case "a":
                            int ch = 0;
                            for (int i = 0; i < mass1.Length; i++)
                            {
                                for (int j = i + 1; j < mass1.Length; j++)
                                {
                                    if (mass1[i] > mass1[j])
                                    {
                                        ch = mass1[i];
                                        mass1[i] = mass1[j];
                                        mass1[j] = ch;
                                    }

                                }
                            }
                            Console.WriteLine("{0}", string.Join(" ", mass1)); ;
                            var reversemass1 = (int[])mass1.Clone();
                            ch = mass1.Length - 1;

                            foreach (var item in mass1)
                            {
                                reversemass1[ch] = item;
                                ch -= 1;
                            }
                            Console.WriteLine("{0}", string.Join(" ", reversemass1)); ;
                            break;
                        case "b":
                            Array.Sort(mass1);
                            Console.WriteLine("{0}", string.Join(" ", mass1)); ;
                            Array.Reverse(mass1);
                            Console.WriteLine("{0}", string.Join(" ", mass1)); ;
                            break;
                        default:
                            Console.WriteLine("Режим не выбран,заканчиваю работу...");
                            break;
                    }
                    string[] mass2 = new string[mass1.Length];
                    for (int i = 0; i < mass1.Length; i++)
                    {
                        if (mass1[i] % 2 == 0)
                        {
                            mass2[i] = mass1[i].ToString();
                        }
                    }
                    mass2 = new string[mass1.Length];
                    value = 0;
                    foreach (var item in mass1)
                    {
                        if (item % 2 == 0)
                        {
                            mass2[value] = item.ToString();
                            value++;
                        }

                    }
                    Console.WriteLine("{0}", string.Join(" ", mass2));
                    break;
                case "fl":
                    StreamReader sr = new StreamReader("Lab1.txt");
                    k = sr.ReadLine();
                    mass1 = Array.ConvertAll(sr.ReadLine().Split(' '), mass1 => int.Parse(mass1));
                    Console.WriteLine("{0}", string.Join(" ", mass1));
                    for (int i = 0; i < mass1.Length; i++)
                    {
                        if (i == 0)
                        {
                            mn = mass1[i];
                            mx = mass1[i];
                        }
                        if (mn > mass1[i])
                        {
                            mn = mass1[i];
                            imn = i;
                        }
                        if (mx < mass1[i])
                        {
                            mx = mass1[i];
                            imx = i;
                        }

                    }
                    Console.WriteLine($"{mx} {imx} ");
                    Console.WriteLine($"{mn} {imn} ");
                    switch (k)
                    {
                        case "a":
                            int ch = 0;
                            for (int i = 0; i < mass1.Length; i++)
                            {
                                for (int j = i + 1; j < mass1.Length; j++)
                                {
                                    if (mass1[i] > mass1[j])
                                    {
                                        ch = mass1[i];
                                        mass1[i] = mass1[j];
                                        mass1[j] = ch;
                                    }

                                }
                            }
                            Console.WriteLine("{0}", string.Join(" ", mass1)); ;
                            var reversemass1 = (int[])mass1.Clone();
                            ch = mass1.Length - 1;

                            foreach (var item in mass1)
                            {
                                reversemass1[ch] = item;
                                ch -= 1;
                            }
                            Console.WriteLine("{0}", string.Join(" ", reversemass1)); ;
                            break;
                        case "b":
                            Array.Sort(mass1);
                            Console.WriteLine("{0}", string.Join(" ", mass1)); ;
                            Array.Reverse(mass1);
                            Console.WriteLine("{0}", string.Join(" ", mass1)); ;
                            break;
                        default:
                            Console.WriteLine("Режим не выбран,заканчиваю работу...");
                            break;
                    }
                    mass2 = new string[mass1.Length];
                    value = 0;
                    foreach (var item in mass1)
                    {
                        if (item % 2 == 0)
                        {
                            mass2[value] = item.ToString();
                            value++;
                        }

                    }
                    Console.WriteLine("{0}", string.Join(" ", mass2));
                    break;
                default:
                    break;
            }
        }
    }
}