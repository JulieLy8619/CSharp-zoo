using lab05_zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Goldfish : Fish , IPotty
    {
        public bool Shiney { get; set; }
        //int IPlay.PlayThings { get; set; } = 1000;
        public override int Move()
        {
            Console.WriteLine("Move in goldfish class");
            return 2;
        }
        public override int Speak()
        {
            Console.WriteLine("Speak in goldfish class");
            return 50;
        }

        public string PottyInterface()
        {
            Console.WriteLine("PottyInterface from IPotty in Goldfish");
            return "Hello from PottyInterface IPotty Goldfish";
        }

    }
}
