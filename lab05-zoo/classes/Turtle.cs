using System;
using System.Collections.Generic;
using System.Text;
using lab05_zoo.Interfaces;

namespace lab05_zoo.classes
{
    public class Turtle : Reptile , IPlay
    {
        public bool HasShell { get; set; }
        //int IPlay.PlayThings { get; set; } = 100; //why wouldn't this work and let me test it
        public override void Move()
        {
            Console.WriteLine("Move in Turtle class");
        }
        public override void Speak()
        {
            Console.WriteLine("Speak in Turtle class");
        }
        public int Play()
        {
            Console.WriteLine("Play from IPlay in Turtle");
            return 100;
        }
    }
}
