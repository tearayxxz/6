using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to eat?");
            Console.WriteLine("Please,input 1 for mama input 2 for stir fried basil");
           int food;
            do
            {
                Console.Write("Input : ");
                food = int.Parse(Console.ReadLine());
            } while (food != 1 && food != 2);
            if (food == 1)
            {
                string boiled;
                do
                {
                    Console.WriteLine("Boiling . . . ");
                    Console.WriteLine("Is mama is done?");
                    Console.Write("input Y/N : ");
                    boiled = Console.ReadLine();
                } while (boiled != "Y");
                Console.WriteLine("MAMA is ready to eat");
            }
            if (food == 2)
            {
                string stir;
                do
                {
                    Console.WriteLine("stir frying . . . ");
                    Console.WriteLine("Is mama is done?");
                    Console.Write("input Y/N : ");
                    stir = Console.ReadLine();
                } while (stir != "Y");
                Console.WriteLine("Stir fried basil is ready to eat");
            }
        }
    }
}
