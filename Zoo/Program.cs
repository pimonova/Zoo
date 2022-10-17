using System;

namespace Zoo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Squirrel squirrel = new Squirrel();
            Console.WriteLine("Введите имя белочки:");
            squirrel.Name = Console.ReadLine();
            Console.WriteLine("Введите количество орехов у белочки:");
            squirrel.NumberOfNuts = int.Parse(Console.ReadLine());
            squirrel.Print();
            squirrel.EatNuts();

            Console.WriteLine("\n");

            Orangutan orangutan = new Orangutan();
            Console.WriteLine("Введите имя орангутанга:");
            orangutan.Name = Console.ReadLine();
            Console.WriteLine("Введите количество бананов у орангутанга:");
            orangutan.NumberOfBananas = int.Parse(Console.ReadLine());
            orangutan.Print();
            orangutan.Sleep();
        }
    }
}