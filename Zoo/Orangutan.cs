using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Orangutan
    {
        public Orangutan()
        {
            Name = "Орангутанг";
            NumberOfBananas = 0;
        }
        public Orangutan(string _name, int _numOfBananas)
        {
            Name = _name;
            NumberOfBananas = _numOfBananas;
        }


        public string Name { get; set; }
        public int NumberOfBananas { get; set; }

        public void Print()
        {
            Console.WriteLine($"Имя орангутанга: {Name}  Сколько у него бананов?: {NumberOfBananas}");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} спит");
        }
    }
}
