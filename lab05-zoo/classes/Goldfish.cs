using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    class Goldfish : Fish
    {
        public bool Shiney { get; set; }
        public override void Move()
        {
            Console.WriteLine("Move in goldfish class");
        }
        public override void Speak()
        {
            Console.WriteLine("Speak in goldfish class");
        }
    }
}
