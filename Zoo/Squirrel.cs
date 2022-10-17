using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Squirrel
    {
        public Squirrel()
        {
            Name = "Белочка";
            NumberOfNuts = 0;
        }
        public Squirrel(string _name, int _numberOfNuts)
        {
            Name = _name;
            NumberOfNuts = _numberOfNuts;
        }

        public string Name { get; set; }
        public int NumberOfNuts { get; set; }

        public void Print()
        {
            Console.WriteLine($"Имя белочки: {Name}  Сколько у неё орехов?: {NumberOfNuts}");
        }

        public void EatNuts()
        {
            Console.WriteLine($"{Name} ест орешки");
        }
    }
}
