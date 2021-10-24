using System;
using Lab_1_1;
using Lab1_2;
using Lab1_3;


namespace Visual
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            Console.WriteLine("Gordeev Gleb Lab_1");
            Console.WriteLine("1 - Lab1_1 ");
            Console.WriteLine("2 - Lab1_2 ");
            Console.WriteLine("3 - Lab1_3 ");
            Console.WriteLine("0 - break ");
            while (input != "0")
            {
                input = Console.ReadLine();
                if (input == "1") { Lab_1_1.Lab_1_1.Main(); };
                if (input == "2") { Lab1_2.Lab1_2.Main(); }; 
                if (input == "3") { Lab1_3.Lab1_3.Main(); };
            }
        }
    }
}
