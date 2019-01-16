using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Turtle : Reptile
    {
        public bool HasShell { get; set; }
        public override void Move()
        {
            Console.WriteLine("Move in Turtle class");
        }
        public override void Speak()
        {
            Console.WriteLine("Speak in Turtle class");
        }
    }
}
